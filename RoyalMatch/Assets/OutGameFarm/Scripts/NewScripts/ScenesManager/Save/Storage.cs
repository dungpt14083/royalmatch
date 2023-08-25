using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Debug = UnityEngine.Debug;

//ĐỌC GHI FILE LOCAL
public class Storage
{
    //[StructLayout(2)]
    [StructLayout(LayoutKind.Explicit)]
    private struct UIntToFloat
    {
        [FieldOffset(0)]
        public float FloatValue;

        [FieldOffset(0)]
        public uint UIntValue;
    }

    private class CaughtException : Exception
    {
        public CaughtException(string message, Exception ex)
            : base(message, ex)
        {
        }
    }

    public const string DataFilename = "Data";

    private const int SerializationBufferLength = 20;

    private const int OldVersionCount = 14;

    private const long TimestampGranularity = 864000000000L;

    private const string CreationTimestampKey = "~Creation~";

    private const string UpdateTimestampKey = "~Update~";

    private const string VersionKey = "~Version~";

    [CompilerGenerated] [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Action m_NewGameEvent;

    private string _path;

    private Dictionary<string, object> _root;

    public StorageWarning StorageWarning { get; private set; }

    public Dictionary<string, object> Root
    {
        get { return _root; }
    }

    public DateTime CreationTimestamp
    {
        get
        {
            object value;
            if (_root.TryGetValue("~Creation~", out value))
            {
                return new DateTime((long)value, DateTimeKind.Utc);
            }

            return DateTime.MinValue;
        }
        private set
        {
            if (value.Kind != DateTimeKind.Utc)
            {
                value = value.ToUniversalTime();
            }

            _root["~Creation~"] = value.Ticks;
        }
    }

    public DateTime UpdateTimestamp
    {
        get
        {
            object value;
            if (_root.TryGetValue("~Update~", out value))
            {
                return new DateTime((long)value, DateTimeKind.Utc);
            }

            return DateTime.MinValue;
        }
        private set
        {
            if (value.Kind != DateTimeKind.Utc)
            {
                value = value.ToUniversalTime();
            }

            _root["~Update~"] = value.Ticks;
        }
    }

    public long Version
    {
        get
        {
            object value;
            if (_root.TryGetValue("~Version~", out value))
            {
                return (long)value;
            }

            return 0L;
        }
        private set { _root["~Version~"] = value; }
    }

    public event Action NewGameEvent
    {
        add
        {
            Action action = this.m_NewGameEvent;
            Action action2;
            do
            {
                action2 = action;
                action = Interlocked.CompareExchange(ref this.m_NewGameEvent, (Action)Delegate.Combine(action2, value),
                    action);
            } while (action != action2);
        }
        remove
        {
            Action action = this.m_NewGameEvent;
            Action action2;
            do
            {
                action2 = action;
                action = Interlocked.CompareExchange(ref this.m_NewGameEvent, (Action)Delegate.Remove(action2, value),
                    action);
            } while (action != action2);
        }
    }

    public Storage(string path)
    {
        _path = path;
        StorageWarning = StorageWarning.None;
        Load();
    }

    public static bool ExceptionMeansFullDisk(Exception ex)
    {
        return ex != null && !string.IsNullOrEmpty(ex.Message) && ex.Message.ToLower().Contains("disk full");
    }

    public static StorageWarning GetStorageWarning(Exception ex)
    {
        if (ExceptionMeansFullDisk(ex) || ExceptionMeansFullDisk(ex.InnerException))
        {
            return StorageWarning.DiskFull;
        }

        if (ex is UnauthorizedAccessException)
        {
            return StorageWarning.CreateDirectoryUnauthorizedException;
        }

        return StorageWarning.None;
    }

    public static bool HasStorageAt(string path)
    {
        return ListSaveFiles(path).Length != 0;
    }

    //TRUYỀN PATH VÀO LẤY FILE LÊN TÂT CẢ FILE 
    private static string[] ListSaveFiles(string storagePath)
    {
        List<string> list = new List<string>();
        try
        {
            list.AddRange(Directory.GetFiles(storagePath, "Data*"));
        }
        catch (DirectoryNotFoundException)
        {
        }
        catch (Exception ex2)
        {
            Debug.LogWarning("Unable to get files from " + storagePath + ": " + ex2.ToString());
        }

        //SAU ĐÓ THÌ S SORT FILE THEO THỨ TỰ CHIỀU DÀI FILE NAM TỪ DATA VỀ SAU
        if (list.Count > 0)
        {
            Exception parseException = null;
            string parseExceptionName = null;
            list.Sort(delegate(string file1, string file2)
            {
                long num = 0L;
                string fileName = Path.GetFileName(file1);
                if (fileName.StartsWith("Data") && fileName.Length > "Data".Length)
                {
                    try
                    {
                        num = Convert.ToInt64(fileName.Substring("Data".Length), CultureInfo.InvariantCulture);
                    }
                    catch (Exception ex3)
                    {
                        Debug.LogWarning(string.Format("Unable to parse fileVersion of {0}: {1}", fileName, ex3));
                        parseException = ex3;
                        parseExceptionName = fileName;
                    }
                }

                long num2 = 0L;
                string fileName2 = Path.GetFileName(file2);
                if (fileName2.StartsWith("Data") && fileName2.Length > "Data".Length)
                {
                    try
                    {
                        num2 = Convert.ToInt64(fileName2.Substring("Data".Length), CultureInfo.InvariantCulture);
                    }
                    catch (Exception ex4)
                    {
                        Debug.LogWarning(string.Format("Unable to parse fileVersion of {0}: {1}", fileName, ex4));
                        parseException = ex4;
                        parseExceptionName = fileName2;
                    }
                }

                if (num < num2)
                {
                    return -1;
                }

                return (num > num2) ? 1 : 0;
            });
            if (parseException != null)
            {
                string message = string.Format("Unable to parse fileVersion of {0}", parseExceptionName);
                Debug.LogError(message);
            }
        }

        return list.ToArray();
    }
    
    //GỌI LƯU FILE LƯU DỮ LIỆU VÀO LOCAL:::
    public void Save()
    {
        if (_path != null)
        {
            bool isNew;
            string text = FindSaveFile(out isNew);
            DeleteOldVersions(isNew ? (-1) : 0);
            Dictionary<string, object> root = Root;
            Exception outException = null;
            
            
            
            
            
            
            //XONG SAU Đ THÌ LƯU FILE MỚI VÀO LƯU TỪ ROOT VÀO ĐÂY ???ROOT????
            if (!SaveDictionary(root, text, out outException))
            {
                string message = string.Format("Unable to save dictionary to {0}: {1}", text, outException);
                Debug.LogError(message);
            }
        }
    }

    public void NewGame()
    {
        Delete();
        if (this.m_NewGameEvent != null)
        {
            this.m_NewGameEvent();
        }
    }

    //LOAD VỚI TÊN FILE VÀO TRONG ROOT DUYỆT QUA DANH SÁCH FILE VÀ ĐƯA VÀO ROOT
    public Dictionary<string, object> LoadDictionary(string filename)
    {
        Dictionary<string, object> result = null;
        if (filename != null && File.Exists(filename))
        {
            try
            {
                using (Stream stream = File.Open(filename, FileMode.Open, FileAccess.Read))
                {
                    // GIAI MA RA DUA VAO
                    result = (Dictionary<string, object>)DeserializeObject(stream, new byte[20], new List<string>());
                    return result;
                }
            }
            catch (Exception ex)
            {
                string message = string.Format("Unable to load dictionary to {0}: {1}", filename, ex.ToString());
                Debug.LogError(message);
                return result;
            }
        }

        return result;
    }


    public bool SaveDictionary(Dictionary<string, object> dictionary, string filename, out Exception outException)
    {
        outException = null;
        if (filename == null || dictionary == null)
        {
            return false;
        }

        try
        {
            string directoryName = Path.GetDirectoryName(filename);
            if (directoryName != null && !Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }
        }
        catch (Exception ex)
        {
            if (ExceptionMeansFullDisk(ex) || ExceptionMeansFullDisk(ex.InnerException))
            {
                StorageWarning = StorageWarning.DiskFull;
            }
            else if (ex is UnauthorizedAccessException)
            {
                StorageWarning = StorageWarning.CreateDirectoryUnauthorizedException;
            }

            outException = ex;
            return false;
        }

        string text = Path.Combine(Path.GetDirectoryName(filename), "tmp_" + Path.GetFileName(filename));
        Stream stream = null;
        try
        {
            stream = File.Open(text, FileMode.Create, FileAccess.Write);
            SerializeObject(stream, dictionary, new byte[20], new Dictionary<string, uint>());
        }
        catch (Exception ex2)
        {
            if (ExceptionMeansFullDisk(ex2) || ExceptionMeansFullDisk(ex2.InnerException))
            {
                StorageWarning = StorageWarning.DiskFull;
            }

            outException = ex2;
            return false;
        }
        finally
        {
            try
            {
                stream.Dispose();
            }
            catch (Exception)
            {
            }
        }

        if (File.Exists(filename))
        {
            try
            {
                File.Delete(filename);
            }
            catch (Exception ex4)
            {
                outException = ex4;
                return false;
            }
        }

        try
        {
            File.Move(text, filename);
        }
        catch (Exception ex5)
        {
            outException = ex5;
            return false;
        }

        return true;
    }

    public Dictionary<string, object> CloneDictionary(Dictionary<string, object> dictionary)
    {
        if (dictionary == null)
        {
            return null;
        }

        Dictionary<string, object> dictionary2 = new Dictionary<string, object>(dictionary.Count);
        foreach (KeyValuePair<string, object> item in dictionary)
        {
            dictionary2[item.Key] = CloneObject(item.Value);
        }

        return dictionary2;
    }

    public List<object> CloneList(List<object> list)
    {
        if (list == null)
        {
            return null;
        }

        List<object> list2 = new List<object>(list.Count);
        foreach (object item in list)
        {
            list2.Add(CloneObject(item));
        }

        return list2;
    }

    public object[] CloneArray(object[] array)
    {
        if (array == null)
        {
            return null;
        }

        object[] array2 = new object[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array2[i] = CloneObject(array[i]);
        }

        return array2;
    }

    public object CloneObject(object o)
    {
        if (o is Dictionary<string, object>)
        {
            return CloneDictionary((Dictionary<string, object>)o);
        }

        if (o is List<object>)
        {
            return CloneList((List<object>)o);
        }

        if (o is object[])
        {
            return CloneArray((object[])o);
        }

        if (o is ICloneable)
        {
            return ((ICloneable)o).Clone();
        }

        if (o != null && !o.GetType().IsValueType)
        {
            Debug.LogErrorFormat("\"Cloning\" type {0}", o.GetType());
        }

        return o;
    }

    public bool VerifyType(object o)
    {
        return VerifyType(o, false);
    }

    public bool VerifyType(object o, bool throwException)
    {
        if (object.ReferenceEquals(o, null) || o is Dictionary<string, object> || o is List<object> || o is object[] ||
            o is string || o is bool || o is char || o is float || o is double || o is sbyte || o is byte ||
            o is short || o is ushort || o is int || o is uint || o is long || o is ulong || o is decimal)
        {
            return true;
        }

        if (throwException)
        {
            throw new ArgumentException(string.Concat("Value ", o, " of type ", o.GetType().AssemblyQualifiedName,
                " is not a storable type."));
        }

        return false;
    }

    public string DictToString(Dictionary<string, object> storage)
    {
        using (Stream stream = new MemoryStream())
        {
            SerializeObject(stream, storage, new byte[20], new Dictionary<string, uint>());
            stream.Flush();
            stream.Position = 0L;
            return Convert.ToBase64String(ReadFully(stream));
        }
    }

    public Dictionary<string, object> StringToDict(string input)
    {
        byte[] buffer = Convert.FromBase64String(input);
        using (MemoryStream memoryStream = new MemoryStream(buffer))
        {
            memoryStream.Flush();
            memoryStream.Position = 0L;
            return (Dictionary<string, object>)DeserializeObject(memoryStream, new byte[20], new List<string>());
        }
    }

    public bool UnityVersionIsAtLeast(string version, int major, int minor, int revision, int patch)
    {
        Regex regex = new Regex("^([0-9]+)\\.([0-9]+)\\.([0-9]+)(?:(.)([0-9]+))?$", RegexOptions.CultureInvariant);
        Match match = regex.Match(version);
        if (!match.Success)
        {
            return true;
        }

        int num = int.Parse(match.Groups[1].ToString());
        int num2 = int.Parse(match.Groups[2].ToString());
        int num3 = int.Parse(match.Groups[3].ToString());
        int num4 = (match.Groups[5].Success ? int.Parse(match.Groups[5].ToString()) : 0);
        if (num != major)
        {
            return num > major;
        }

        if (num2 != minor)
        {
            return num2 > minor;
        }

        if (num3 != revision)
        {
            return num3 > revision;
        }

        return num4 >= patch;
    }

    public Dictionary<string, object> GetDictionary(string key)
    {
        if (string.IsNullOrEmpty(key))
        {
            return new Dictionary<string, object>();
        }

        object value;
        if (Root.TryGetValue(key, out value) && value is Dictionary<string, object>)
        {
            return (Dictionary<string, object>)value;
        }

        Dictionary<string, object> dictionary = new Dictionary<string, object>();
        _root.Add(key, dictionary);
        return dictionary;
    }

    //BẮT ĐẦU GIẢI MÃ ĐỌC FILE RA NGOÀI VÀ LẤY 
    private object DeserializeObject(Stream stream, byte[] buffer, List<string> stringTable)
    {
        int num = stream.ReadByte();
        if (num < 0)
        {
            throw new FormatException("Unexpected end of stream.");
        }

        char c = (char)num;
        switch (c)
        {
            case 'n':
                return null;
            case '{':
            {
                int num3 = (int)ReadLength(stream);
                Dictionary<string, object> dictionary = new Dictionary<string, object>(num3);
                for (int j = 0; j < num3; j++)
                {
                    string key = (string)DeserializeObject(stream, buffer, stringTable);
                    object value = DeserializeObject(stream, buffer, stringTable);
                    dictionary.Add(key, value);
                }

                return dictionary;
            }
            case '[':
            {
                int num4 = (int)ReadLength(stream);
                List<object> list = new List<object>();
                for (int k = 0; k < num4; k++)
                {
                    object item = DeserializeObject(stream, buffer, stringTable);
                    list.Add(item);
                }

                return list;
            }
            case ']':
            {
                int num10 = (int)ReadLength(stream);
                object[] array3 = new object[num10];
                for (int l = 0; l < num10; l++)
                {
                    array3[l] = DeserializeObject(stream, buffer, stringTable);
                }

                return array3;
            }
            case '$':
            {
                int num7 = (int)ReadLength(stream);
                byte[] array2 = new byte[num7];
                if (stream.Read(array2, 0, num7) != num7)
                {
                    throw new FormatException("Unexpected end of stream.");
                }

                string @string = Encoding.UTF8.GetString(array2, 0, array2.Length);
                stringTable.Add(@string);
                return @string;
            }
            case '#':
            {
                int num9 = (int)ReadLength(stream);
                if (num9 < 0 || num9 >= stringTable.Count)
                {
                    throw new FormatException("String table index out of bounds.");
                }

                return stringTable[num9];
            }
            case '1':
                return true;
            case '0':
                return false;
            case 'c':
                if (stream.Read(buffer, 0, 2) != 2)
                {
                    throw new FormatException("Unexpected end of stream.");
                }

                return (char)((buffer[0] << 8) | buffer[1]);
            case 'f':
            {
                UIntToFloat uIntToFloat = default(UIntToFloat);
                uIntToFloat.UIntValue = ReadInt(stream, buffer);
                return uIntToFloat.FloatValue;
            }
            case 'd':
            {
                uint num5 = ReadInt(stream, buffer);
                uint num6 = ReadInt(stream, buffer);
                return BitConverter.Int64BitsToDouble((long)(((ulong)num5 << 32) | num6));
            }
            case 'b':
            {
                int num2 = stream.ReadByte();
                if (num2 < 0)
                {
                    throw new FormatException("Unexpected end of stream.");
                }

                return (sbyte)num2;
            }
            case 'B':
            {
                int num8 = stream.ReadByte();
                if (num8 < 0)
                {
                    throw new FormatException("Unexpected end of stream.");
                }

                return (byte)num8;
            }
            case 's':
                if (stream.Read(buffer, 0, 2) != 2)
                {
                    throw new FormatException("Unexpected end of stream.");
                }

                return (short)((buffer[0] << 8) | buffer[1]);
            case 'S':
                if (stream.Read(buffer, 0, 2) != 2)
                {
                    throw new FormatException("Unexpected end of stream.");
                }

                return (ushort)((buffer[0] << 8) | buffer[1]);
            case 'i':
                return (int)ReadInt(stream, buffer);
            case 'I':
                return ReadInt(stream, buffer);
            case 'l':
                if (stream.Read(buffer, 0, 8) != 8)
                {
                    throw new FormatException("Unexpected end of stream.");
                }

                return (long)(((ulong)buffer[0] << 56) | ((ulong)buffer[1] << 48) | ((ulong)buffer[2] << 40) |
                              ((ulong)buffer[3] << 32) | ((ulong)buffer[4] << 24) | ((ulong)buffer[5] << 16) |
                              ((ulong)buffer[6] << 8) | buffer[7]);
            case 'L':
                if (stream.Read(buffer, 0, 8) != 8)
                {
                    throw new FormatException("Unexpected end of stream.");
                }

                return ((ulong)buffer[0] << 56) | ((ulong)buffer[1] << 48) | ((ulong)buffer[2] << 40) |
                       ((ulong)buffer[3] << 32) | ((ulong)buffer[4] << 24) | ((ulong)buffer[5] << 16) |
                       ((ulong)buffer[6] << 8) | buffer[7];
            case 'a':
            {
                int[] array = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    array[i] = (int)ReadInt(stream, buffer);
                }

                return new decimal(array);
            }
            default:
                throw new FormatException("Unknown type (" + c + ") encountered.");
        }
    }

    //MÃ HÒA DICTINARY VÀO Ể LƯU FILE THEO LIST OBJET VÀ DICTINAYR
    private void SerializeObject(Stream stream, object o, byte[] buffer, Dictionary<string, uint> stringTable)
    {
        try
        {
            if (object.ReferenceEquals(o, null))
            {
                stream.WriteByte(110);
                return;
            }

            if (o is Dictionary<string, object>)
            {
                Dictionary<string, object> dictionary = (Dictionary<string, object>)o;
                stream.WriteByte(123);
                WriteLength(stream, (uint)dictionary.Count, buffer);
                {
                    foreach (KeyValuePair<string, object> item in dictionary)
                    {
                        SerializeObject(stream, item.Key, buffer, stringTable);
                        SerializeObject(stream, item.Value, buffer, stringTable);
                    }

                    return;
                }
            }

            if (o is List<object>)
            {
                List<object> list = (List<object>)o;
                stream.WriteByte(91);
                WriteLength(stream, (uint)list.Count, buffer);
                {
                    foreach (object item2 in list)
                    {
                        SerializeObject(stream, item2, buffer, stringTable);
                    }

                    return;
                }
            }

            if (o is object[])
            {
                object[] array = (object[])o;
                stream.WriteByte(93);
                WriteLength(stream, (uint)array.Length, buffer);
                object[] array2 = array;
                foreach (object o2 in array2)
                {
                    SerializeObject(stream, o2, buffer, stringTable);
                }

                return;
            }

            if (o is string)
            {
                string text = (string)o;
                uint value;
                if (stringTable.TryGetValue(text, out value))
                {
                    stream.WriteByte(35);
                    WriteLength(stream, value, buffer);
                    return;
                }

                byte[] bytes = Encoding.UTF8.GetBytes(text);
                stream.WriteByte(36);
                WriteLength(stream, (uint)bytes.Length, buffer);
                stream.Write(bytes, 0, bytes.Length);
                stringTable[text] = (uint)stringTable.Count;
                return;
            }

            if (o is bool)
            {
                if ((bool)o)
                {
                    stream.WriteByte(49);
                }
                else
                {
                    stream.WriteByte(48);
                }

                return;
            }

            if (o is char)
            {
                int num = (char)o;
                buffer[0] = 99;
                buffer[1] = (byte)(num >> 8);
                buffer[2] = (byte)((uint)num & 0xFFu);
                stream.Write(buffer, 0, 3);
                return;
            }

            if (o is float)
            {
                UIntToFloat uIntToFloat = default(UIntToFloat);
                uIntToFloat.FloatValue = (float)o;
                stream.WriteByte(102);
                WriteInt(stream, uIntToFloat.UIntValue, buffer);
                return;
            }

            if (o is double)
            {
                ulong num2 = (ulong)BitConverter.DoubleToInt64Bits((double)o);
                stream.WriteByte(100);
                WriteInt(stream, (uint)(num2 >> 32), buffer);
                WriteInt(stream, (uint)(num2 & 0xFFFFFFFFu), buffer);
                return;
            }

            if (o is sbyte)
            {
                byte b = (byte)(sbyte)o;
                buffer[0] = 98;
                buffer[1] = b;
                stream.Write(buffer, 0, 2);
                return;
            }

            if (o is byte)
            {
                byte b2 = (byte)o;
                buffer[0] = 66;
                buffer[1] = b2;
                stream.Write(buffer, 0, 2);
                return;
            }

            if (o is short)
            {
                uint num3 = (uint)(short)o;
                buffer[0] = 115;
                buffer[1] = (byte)(num3 >> 8);
                buffer[2] = (byte)(num3 & 0xFFu);
                stream.Write(buffer, 0, 3);
                return;
            }

            if (o is ushort)
            {
                uint num4 = (ushort)o;
                buffer[0] = 83;
                buffer[1] = (byte)(num4 >> 8);
                buffer[2] = (byte)(num4 & 0xFFu);
                stream.Write(buffer, 0, 3);
                return;
            }

            if (o is int)
            {
                uint num5 = (uint)(int)o;
                buffer[0] = 105;
                buffer[1] = (byte)(num5 >> 24);
                buffer[2] = (byte)((num5 >> 16) & 0xFFu);
                buffer[3] = (byte)((num5 >> 8) & 0xFFu);
                buffer[4] = (byte)(num5 & 0xFFu);
                stream.Write(buffer, 0, 5);
                return;
            }

            if (o is uint)
            {
                uint num6 = (uint)o;
                buffer[0] = 73;
                buffer[1] = (byte)(num6 >> 24);
                buffer[2] = (byte)((num6 >> 16) & 0xFFu);
                buffer[3] = (byte)((num6 >> 8) & 0xFFu);
                buffer[4] = (byte)(num6 & 0xFFu);
                stream.Write(buffer, 0, 5);
                return;
            }

            if (o is long)
            {
                ulong num7 = (ulong)(long)o;
                buffer[0] = 108;
                buffer[1] = (byte)(num7 >> 56);
                buffer[2] = (byte)((num7 >> 48) & 0xFF);
                buffer[3] = (byte)((num7 >> 40) & 0xFF);
                buffer[4] = (byte)((num7 >> 32) & 0xFF);
                buffer[5] = (byte)((num7 >> 24) & 0xFF);
                buffer[6] = (byte)((num7 >> 16) & 0xFF);
                buffer[7] = (byte)((num7 >> 8) & 0xFF);
                buffer[8] = (byte)(num7 & 0xFF);
                stream.Write(buffer, 0, 9);
                return;
            }

            if (o is ulong)
            {
                ulong num8 = (ulong)o;
                buffer[0] = 76;
                buffer[1] = (byte)(num8 >> 56);
                buffer[2] = (byte)((num8 >> 48) & 0xFF);
                buffer[3] = (byte)((num8 >> 40) & 0xFF);
                buffer[4] = (byte)((num8 >> 32) & 0xFF);
                buffer[5] = (byte)((num8 >> 24) & 0xFF);
                buffer[6] = (byte)((num8 >> 16) & 0xFF);
                buffer[7] = (byte)((num8 >> 8) & 0xFF);
                buffer[8] = (byte)(num8 & 0xFF);
                stream.Write(buffer, 0, 9);
                return;
            }

            if (o is decimal)
            {
                decimal d = (decimal)o;
                stream.WriteByte(97);
                int[] bits = decimal.GetBits(d);
                for (int j = 0; j < 4; j++)
                {
                    WriteInt(stream, (uint)bits[j], buffer);
                }

                return;
            }

            throw new FormatException("Can't serialize object " + o.ToString() + " of type " +
                                      o.GetType().AssemblyQualifiedName + " because it is not a storable type.");
        }
        catch (CaughtException)
        {
            throw;
        }
        catch (Exception ex2)
        {
            string message = string.Format("SerializeObject exception of object of type {0}",
                (o != null) ? o.GetType().ToString() : "null");
            throw new CaughtException(message, ex2);
        }
    }

    private void WriteLength(Stream stream, uint length, byte[] buffer)
    {
        int count = 0;
        uint num;
        for (num = length; num >= 128; num >>= 7)
        {
            buffer[count++] = (byte)(0x80u | (num & 0x7Fu));
        }

        buffer[count++] = (byte)num;
        stream.Write(buffer, 0, count);
    }

    private uint ReadLength(Stream stream)
    {
        uint num = 0u;
        int num2 = 0;
        int num3;
        while ((num3 = stream.ReadByte()) >= 128)
        {
            if (num2 >= 4)
            {
                throw new FormatException("Invalid length.");
            }

            num |= (uint)((num3 & 0x7F) << num2 * 7);
            num2++;
        }

        if (num3 < 0)
        {
            throw new FormatException("Unexpected end of stream.");
        }

        return num | (uint)(num3 << num2 * 7);
    }

    private void WriteInt(Stream stream, uint i, byte[] buffer)
    {
        buffer[0] = (byte)(i >> 24);
        buffer[1] = (byte)((i >> 16) & 0xFFu);
        buffer[2] = (byte)((i >> 8) & 0xFFu);
        buffer[3] = (byte)(i & 0xFFu);
        stream.Write(buffer, 0, 4);
    }

    private uint ReadInt(Stream stream, byte[] buffer)
    {
        int num = stream.Read(buffer, 0, 4);
        if (num != 4)
        {
            throw new FormatException("Unexpected end of stream.");
        }

        return (uint)((buffer[0] << 24) | (buffer[1] << 16) | (buffer[2] << 8) | buffer[3]);
    }

    private string GetTypeFullName(string assemblyQualifiedName)
    {
        int num = assemblyQualifiedName.IndexOf(',');
        if (num >= 0)
        {
            return assemblyQualifiedName.Substring(0, num);
        }

        return assemblyQualifiedName;
    }

    private byte[] ReadFully(Stream stream)
    {
        byte[] array = new byte[32768];
        using (MemoryStream memoryStream = new MemoryStream())
        {
            while (true)
            {
                int num = stream.Read(array, 0, array.Length);
                if (num <= 0)
                {
                    break;
                }

                memoryStream.Write(array, 0, num);
            }

            return memoryStream.ToArray();
        }
    }

    //LOAD TỪ LOCAL LÊN 
    private void Load()
    {
        //NẾU PATH NULL THÌ ROOT LÀ DICTINARY TRỐNG:::VÀ RETURN
        if (_path == null)
        {
            _root = new Dictionary<string, object>();
            return;
        }

        _root = null;
        //ĐƯỢC FILE DẠNG STRING TÊN FILE ĐUỢC LOAD LÊN
        string[] array = ListSaveFiles();
        int num = array.Length - 1;
        //SAU ĐÓ LOAD DICTIONNAY TỪ TÊN FILE VÀO ROOT
        while (_root == null && num >= 0)
        {
            _root = LoadDictionary(array[num]);
            num--;
            if (_root == null)
            {
                Debug.LogWarningFormat("Failed to load file! Will try to load a backup!");
            }
        }

        if (_root == null)
        {
            _root = new Dictionary<string, object>();
        }
    }

    private void Delete()
    {
        if (_path == null)
        {
            return;
        }

        string[] array = ListSaveFiles();
        string[] array2 = array;
        foreach (string text in array2)
        {
            try
            {
                File.Delete(text);
            }
            catch (Exception ex)
            {
                Debug.LogWarning("Unable to delete dictionary at " + text + ": " + ex.Message);
            }
        }
    }

    //XÓA FILE VERSION CŨ ĐI XÓA HẾT ĐI
    private void DeleteOldVersions(int keepExtra)
    {
        int num = 14 + keepExtra;
        string[] array = ListSaveFiles();
        for (int i = 0; i < array.Length - num; i++)
        {
            try
            {
                File.Delete(array[i]);
            }
            catch (Exception ex)
            {
                Debug.LogWarning("Unable to delete dictionary at " + array[i] + ": " + ex.Message);
            }
        }
    }

    //tìm file cũ tìm file theo version version của game và trả ề là file mới khi //tương đương với 1 ngày 1 ngày mới hay chưa hay là vẫn trong ngày dó
    private string FindSaveFile(out bool isNew)
    {
        DateTime creationTimestamp = CreationTimestamp;
        DateTime utcNow = DateTime.UtcNow;
        long num = Version;
        if (Math.Abs(utcNow.Ticks - creationTimestamp.Ticks) >= 864000000000L)
        {
            num = (Version = num + 1);
            creationTimestamp = utcNow;
            CreationTimestamp = creationTimestamp;
            isNew = true;
        }
        else
        {
            isNew = false;
        }

        UpdateTimestamp = utcNow;
        return Path.Combine(_path,
            "Data" + ((num != 0) ? Convert.ToString(num, CultureInfo.InvariantCulture) : string.Empty));
    }

    private string[] ListSaveFiles()
    {
        return ListSaveFiles(_path);
    }
}