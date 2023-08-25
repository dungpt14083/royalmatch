#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>


template <typename R>
struct VirtualFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
struct InvokerActionInvoker0
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj)
	{
		method->invoker_method(methodPtr, method, obj, NULL, NULL);
	}
};
template <typename T1>
struct InvokerActionInvoker1;
template <typename T1>
struct InvokerActionInvoker1<T1*>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1)
	{
		void* params[1] = { p1 };
		method->invoker_method(methodPtr, method, obj, params, NULL);
	}
};

// System.Collections.Generic.List`1<UnityEngine.AnimatorClipInfo>
struct List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331;
// System.Collections.Generic.List`1<UnityEngine.Animations.ConstraintSource>
struct List_1_tF88FB42B55EA7DB2BFC546CB9573DFF2D6F0AECE;
// UnityEngine.AnimationClip[]
struct AnimationClipU5BU5D_t48CE1A495BA95608745A065C735F2D5BB8DE5A0F;
// UnityEngine.AnimationEvent[]
struct AnimationEventU5BU5D_t7618D98124AE2DE212E31279AD51EB4D9CEEAA9E;
// UnityEngine.AnimatorClipInfo[]
struct AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A;
// UnityEngine.AnimatorControllerParameter[]
struct AnimatorControllerParameterU5BU5D_tAB05125F5DC0D98F59351CD7D8C9880DFFA8EA21;
// System.Char[]
struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB;
// UnityEngine.Animations.ConstraintSource[]
struct ConstraintSourceU5BU5D_t8849C48A722B655E448FBDA392EE981AC3E0BCBC;
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
// UnityEngine.HumanBone[]
struct HumanBoneU5BU5D_t443B81D55400778CBB921DF04BE932ABF14BAA52;
// System.IntPtr[]
struct IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832;
// UnityEngine.Playables.PlayableBinding[]
struct PlayableBindingU5BU5D_tC50C3F27A8E4246488F7A5998CAABAC4811A92CD;
// UnityEngine.SkeletonBone[]
struct SkeletonBoneU5BU5D_t84722CE071EF9295326D5A84492716DBC7A15A85;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF;
// System.Type[]
struct TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB;
// UnityEngine.Animation
struct Animation_t6593B06C39E3B139808B19F2C719C860F3F61040;
// UnityEngine.AnimationClip
struct AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712;
// UnityEngine.AnimationEvent
struct AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174;
// UnityEngine.AnimationState
struct AnimationState_tC704F25A20169025B6CFDC2F00DC84152B5B73CE;
// UnityEngine.Animator
struct Animator_t8A52E42AE54F76681838FE9E632683EF3952E883;
// UnityEngine.AnimatorControllerParameter
struct AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02;
// UnityEngine.AnimatorOverrideController
struct AnimatorOverrideController_tF78BD58B30BB0D767E7A96F8428EA66F2DFD5493;
// System.ArgumentNullException
struct ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129;
// System.ArgumentOutOfRangeException
struct ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F;
// UnityEngine.Avatar
struct Avatar_t7861E57EEE2CF8CC61BD63C09737BA22F7ABCA0F;
// UnityEngine.AvatarMask
struct AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF;
// System.Reflection.Binder
struct Binder_t91BFCE95A7057FADF4D8A1A342AFE52872246235;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E;
// System.Enum
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2;
// UnityEngine.HumanBone
struct HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8;
// System.Collections.IDictionary
struct IDictionary_t6D03155AF1FA9083817AA5B6AD7DEEACC26AB220;
// System.Collections.IEnumerator
struct IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA;
// System.IndexOutOfRangeException
struct IndexOutOfRangeException_t7ECB35264FB6CA8FAA516BD958F4B2ADC78E8A82;
// System.InvalidCastException
struct InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E;
// System.InvalidOperationException
struct InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB;
// UnityEngine.Animations.LookAtConstraint
struct LookAtConstraint_t2B4569F15EA2736FAC97AD3DE35B093AE8B5D919;
// System.Reflection.MemberFilter
struct MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// UnityEngine.Motion
struct Motion_tBCD49FBF5608AD21FC03B63C8182FABCEF2707AC;
// System.NullReferenceException
struct NullReferenceException_tBDE63A6D24569B964908408389070C6A9F5005BB;
// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C;
// UnityEngine.RuntimeAnimatorController
struct RuntimeAnimatorController_t6F7C753402B42EC23C163099CF935C5E0D7A7254;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6;
// UnityEngine.ScriptableObject
struct ScriptableObject_tB3BFDB921A1B1795B38A5417D3B97A89A140436A;
// UnityEngine.SkeletonBone
struct SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126;
// UnityEngine.StateMachineBehaviour
struct StateMachineBehaviour_t59C5685227B06222F5AF7027E2DA530AB99AFDF7;
// System.String
struct String_t;
// UnityEngine.TrackedReference
struct TrackedReference_tF35FF4FB6E89ACD81C24469FAF0CA6FFF29262A2;
// UnityEngine.Transform
struct Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1;
// System.Type
struct Type_t;
// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// UnityEngine.Animation/Enumerator
struct Enumerator_t81434F7D5603121F3D7BD6DB916FE1C755307530;
// UnityEngine.AnimatorOverrideController/OnOverrideControllerDirtyCallback
struct OnOverrideControllerDirtyCallback_tDC67F7661A27502AD804BDE0B696955AFD4A44D5;
// UnityEngine.Playables.PlayableBinding/CreateOutputMethod
struct CreateOutputMethod_tD18AFE3B69E6DDD913D82D5FA1D5D909CEEC8509;

IL2CPP_EXTERN_C RuntimeClass* AnimationEventU5BU5D_t7618D98124AE2DE212E31279AD51EB4D9CEEAA9E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* CreateOutputMethod_tD18AFE3B69E6DDD913D82D5FA1D5D909CEEC8509_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Enumerator_t81434F7D5603121F3D7BD6DB916FE1C755307530_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* HumanBodyBones_tA2A904890A05ABCFFAB7E119244E97C5EA9807E6_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* HumanBoneU5BU5D_t443B81D55400778CBB921DF04BE932ABF14BAA52_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IndexOutOfRangeException_t7ECB35264FB6CA8FAA516BD958F4B2ADC78E8A82_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IntPtr_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NullReferenceException_tBDE63A6D24569B964908408389070C6A9F5005BB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* PlayableBinding_tB68B3BAC47F4F4C559640472174D5BEF93CB6AB4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SkeletonBoneU5BU5D_t84722CE071EF9295326D5A84492716DBC7A15A85_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Type_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UInt32_t1833D51FFA667B18A5AA4B8D34DE284F8495D29B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral00974C5D0A39E4A027B0EB44FE85C731384945B0;
IL2CPP_EXTERN_C String_t* _stringLiteral00F97321929E0D7989E72D633D157BD761DD173A;
IL2CPP_EXTERN_C String_t* _stringLiteral05ACCFE2F05290DF031B27B4C6B2AD1DC43CCDC6;
IL2CPP_EXTERN_C String_t* _stringLiteral10F6FECF95C1235E3B90F738314A338A55A4DF3B;
IL2CPP_EXTERN_C String_t* _stringLiteral1767A709DBA16BACAD77F5ED6AF9CBBD95D35D4E;
IL2CPP_EXTERN_C String_t* _stringLiteral2ED8CAF6321ED9631D3CB63C8A7096F3AB335255;
IL2CPP_EXTERN_C String_t* _stringLiteral35525FB236D9CB0ADE03D4D22EC8AB05BBCACEA3;
IL2CPP_EXTERN_C String_t* _stringLiteral4DEE968069F34C26613ADFCD69C41EFC29314286;
IL2CPP_EXTERN_C String_t* _stringLiteral51A170FF50F6F987DB39394B76A00962DAAC1D32;
IL2CPP_EXTERN_C String_t* _stringLiteral6A5239659C252C3C95FC09A31CA37CA6F6B07FAE;
IL2CPP_EXTERN_C String_t* _stringLiteral82132A808F0B9E6946BE41B8C7B1FDD0D99D773C;
IL2CPP_EXTERN_C String_t* _stringLiteral860B9EA7CDAB02A8A4B38336805EAE2FBA31F09C;
IL2CPP_EXTERN_C String_t* _stringLiteral8DC2252638D84FAF2C30B95D54EC83F52FA6C630;
IL2CPP_EXTERN_C String_t* _stringLiteral95FD319744C5A359A08D63293C9F417B4D0BAB9E;
IL2CPP_EXTERN_C String_t* _stringLiteral972CE48A8E26750559B1B00039204D0DE5B03904;
IL2CPP_EXTERN_C String_t* _stringLiteral98C704D69BD1A288ED31DEE4ED4E50097A2D7018;
IL2CPP_EXTERN_C String_t* _stringLiteral9A0B8F8C43A11ED8E1400C04557C40AC52384963;
IL2CPP_EXTERN_C String_t* _stringLiteral9FD6FF0BE087CD9281920D7CEAF428070CEF0D13;
IL2CPP_EXTERN_C String_t* _stringLiteralA3C8FF345EC45846B2EE6801F84DD49340F0A9E1;
IL2CPP_EXTERN_C String_t* _stringLiteralB2969BA8505A612F4D5D731D20ECF63F6A6793A6;
IL2CPP_EXTERN_C String_t* _stringLiteralB31E4AEFDFD2E76052D908F31AC56B3ABCFC7987;
IL2CPP_EXTERN_C String_t* _stringLiteralBD022D19E88CF1C2E702FF8813F493923F8AC574;
IL2CPP_EXTERN_C String_t* _stringLiteralBF563F6FCC25CE41FFE0BF7590AF9F4475916665;
IL2CPP_EXTERN_C String_t* _stringLiteralCE23A35A2628159F4561C7D26935D3658D22EA68;
IL2CPP_EXTERN_C String_t* _stringLiteralD05EE9FE9EFEEB35F354D97C2927EEB880DA9264;
IL2CPP_EXTERN_C String_t* _stringLiteralD1DCB778EB9DF1B12AD26B829002FF8E78A1AFCE;
IL2CPP_EXTERN_C String_t* _stringLiteralD2435BFAEB0372E848D9BE812E3B06AB862CC3D1;
IL2CPP_EXTERN_C String_t* _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
IL2CPP_EXTERN_C String_t* _stringLiteralE066D08B565F88D413FDACA14C42BFF008FF4EB9;
IL2CPP_EXTERN_C String_t* _stringLiteralF5510C45DDAD777CCB4893578D995C9739F990F2;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationClipPlayable__ctor_mF2EE31CC772B100F98CCAE26963059C6C722FA1A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationLayerMixerPlayable_IsLayerAdditive_m379268A18CFAD74371F6D4E0467072761BF84713_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationLayerMixerPlayable_SetLayerAdditive_m3B35E03C224B118E3F3D9E8A7B697AF570FBFB6E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationLayerMixerPlayable_SetLayerMaskFromAvatarMask_mC4BDE2B476AC13C31053100085FAF6BC86000280_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationLayerMixerPlayable__ctor_m28884B8B9F7E057DF947E3B43ED78EA107368BD6_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationMixerPlayable__ctor_mBF84CC064549C2C00B2AE1174018335958EB7EA7_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationMotionXToDeltaPlayable__ctor_mDE3C14B4B975AC693669D66B6E41BB6432AFA940_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationOffsetPlayable__ctor_mBF3AC6493556DAAEF608B359BEBE8FA6D9F8DBFD_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationPlayableBinding_CreateAnimationOutput_mAAF4FE67781A130389ADA1BD625D42215B4C55A2_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationPlayableOutput__ctor_mE4FB8AA6DFB2F3C18E04A9317F5CE53597A7D22A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationPosePlayable__ctor_mC6C096785918358CA7EC12BABCDF4BBD47F7BA3F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationRemoveScalePlayable__ctor_m4D6C7C4AB8E078050B0CC34C6732051CF043CFA2_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationScriptPlayable__ctor_m6DEFD72735E79009FC1484AA2A7A82E6CE601247_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationStream_CheckIsValid_m6C46800E1A5A4BE27FF761A93F72BC3CD751174C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimatorControllerPlayable_GetCurrentAnimatorClipInfo_mB103A1F9EC5E23947C8A1802D644FC4D22093F14_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimatorControllerPlayable_GetNextAnimatorClipInfo_mF00B978E844FF7E6DF0AF670C0CF2022A8DD2517_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimatorControllerPlayable_GetParameter_mB7ECCC4E41138CC7D9A28ABF499679B8792E9CC3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimatorControllerPlayable_SetHandle_mD86A3C0D03453FAF21903F7A52A743AB2DA6DED4_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Animator_GetBoneTransform_m02042CB47C468D576C6EE436F4AA71D8C47AAF56_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Animator_GetCurrentAnimatorClipInfo_m7C061EE420A67B7D751A2F34D38062FDFF064ED3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Animator_GetNextAnimatorClipInfo_m376D90AA469A7F7268B8D0E5B6930CE7095185D3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* LookAtConstraint_SetSources_m331DB216D4DD9A3D4506C302B3CF934559D75553_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PlayableHandle_IsPlayableOfType_TisAnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969_m9AA33A8596A6C41CAA768B0A6EF59B75658A1FB8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PlayableHandle_IsPlayableOfType_TisAnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_m23764EE36FE7A81A245C7146FF1E9DF6530DA321_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PlayableHandle_IsPlayableOfType_TisAnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0_m644E76378CB4DDC0CE669FE1DCE8A8917595D0ED_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PlayableHandle_IsPlayableOfType_TisAnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18_mE6DAD58415B04EE79FD34641B365283758722ABF_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PlayableHandle_IsPlayableOfType_TisAnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4_mB35755A4D179F4DA51A96FCB3C4A8DF105C2BB12_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PlayableHandle_IsPlayableOfType_TisAnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C_m61A79154B28DAE22A64165C871757F3E447822A6_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PlayableHandle_IsPlayableOfType_TisAnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD_m961964786905D9B20B750AC27CB64EA48C4C5971_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PlayableHandle_IsPlayableOfType_TisAnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127_m4F637AD893630043482383791FA7A0285EB16F6E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PlayableHandle_IsPlayableOfType_TisAnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_m83ED61FDEBC627830082467B83BF64724C68CD70_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PlayableOutputExtensions_SetSourcePlayable_TisAnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E_TisAnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969_m389C7055BB3E25FF8CC06AF5A9F6EE1BE821B43D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PlayableOutputExtensions_SetSourcePlayable_TisAnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E_TisPlayable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F_m015148BFEF9CA1BBC4DE5625B47A768D4B51A543_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PlayableOutputHandle_IsPlayableOutputOfType_TisAnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E_mDA87D18E66EB65AFF53F5AD517C7FBA69DD6D793_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PropertyStreamHandle_CheckIsValidAndResolve_mD4036D6F0444B68BC4C1AECDD7429FEBAF03203C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PropertyStreamHandle_GetBool_mBB5B008988E6CC47C526CF654E53804909C141E0_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PropertyStreamHandle_GetFloat_mAEC50079467900B74F7B485BBAF65A4DE1BBB8DF_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PropertyStreamHandle_GetInt_m58CECCE1A73DB1EA96E287B5B7BF51BF502D8D98_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TransformSceneHandle_CheckIsValid_m33214B5950C49A143A5548B7FB1672062204655A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TransformStreamHandle_CheckIsValidAndResolve_m7602706A5D46D99268DB6C698A6752C96A0525F6_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeType* Animator_t8A52E42AE54F76681838FE9E632683EF3952E883_0_0_0_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;
struct HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8;;
struct HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_com;
struct HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_com;;
struct HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_pinvoke;
struct HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_pinvoke;;
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C;;
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com;
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com;;
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke;
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke;;
struct SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126;;
struct SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_com;
struct SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_com;;
struct SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_pinvoke;
struct SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_pinvoke;;

struct AnimationClipU5BU5D_t48CE1A495BA95608745A065C735F2D5BB8DE5A0F;
struct AnimationEventU5BU5D_t7618D98124AE2DE212E31279AD51EB4D9CEEAA9E;
struct AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A;
struct AnimatorControllerParameterU5BU5D_tAB05125F5DC0D98F59351CD7D8C9880DFFA8EA21;
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
struct HumanBoneU5BU5D_t443B81D55400778CBB921DF04BE932ABF14BAA52;
struct SkeletonBoneU5BU5D_t84722CE071EF9295326D5A84492716DBC7A15A85;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_t8B36B9B16FF72CF5A0EBA03D2FA162E77C86534C 
{
};

// System.Collections.Generic.List`1<UnityEngine.AnimatorClipInfo>
struct List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

// System.Collections.Generic.List`1<UnityEngine.Animations.ConstraintSource>
struct List_1_tF88FB42B55EA7DB2BFC546CB9573DFF2D6F0AECE  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	ConstraintSourceU5BU5D_t8849C48A722B655E448FBDA392EE981AC3E0BCBC* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

// UnityEngine.Animations.AnimationPlayableBinding
struct AnimationPlayableBinding_t44AB912C26E38CBC1F5027F5C96A321C3B1C1612  : public RuntimeObject
{
};

// UnityEngine.Animations.AnimationPlayableExtensions
struct AnimationPlayableExtensions_t3F93F70729DACA99F423992CFC1B380C1942AD4D  : public RuntimeObject
{
};

// UnityEngine.Animations.AnimationPlayableGraphExtensions
struct AnimationPlayableGraphExtensions_tF833C072961F30409DB4D2A1B8B1B5BAE53221B3  : public RuntimeObject
{
};

// UnityEngine.Playables.AnimationPlayableUtilities
struct AnimationPlayableUtilities_t3B493B2DC8BB7533F266D433BC25C4E82EA27A4B  : public RuntimeObject
{
};

// UnityEngine.AnimatorControllerParameter
struct AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02  : public RuntimeObject
{
	// System.String UnityEngine.AnimatorControllerParameter::m_Name
	String_t* ___m_Name_0;
	// UnityEngine.AnimatorControllerParameterType UnityEngine.AnimatorControllerParameter::m_Type
	int32_t ___m_Type_1;
	// System.Single UnityEngine.AnimatorControllerParameter::m_DefaultFloat
	float ___m_DefaultFloat_2;
	// System.Int32 UnityEngine.AnimatorControllerParameter::m_DefaultInt
	int32_t ___m_DefaultInt_3;
	// System.Boolean UnityEngine.AnimatorControllerParameter::m_DefaultBool
	bool ___m_DefaultBool_4;
};
// Native definition for P/Invoke marshalling of UnityEngine.AnimatorControllerParameter
struct AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02_marshaled_pinvoke
{
	char* ___m_Name_0;
	int32_t ___m_Type_1;
	float ___m_DefaultFloat_2;
	int32_t ___m_DefaultInt_3;
	int32_t ___m_DefaultBool_4;
};
// Native definition for COM marshalling of UnityEngine.AnimatorControllerParameter
struct AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02_marshaled_com
{
	Il2CppChar* ___m_Name_0;
	int32_t ___m_Type_1;
	float ___m_DefaultFloat_2;
	int32_t ___m_DefaultInt_3;
	int32_t ___m_DefaultBool_4;
};

// UnityEngine.Animations.AnimatorJobExtensions
struct AnimatorJobExtensions_tF575992DDBF1EDEAF9D02E1BD755558D929D1E4A  : public RuntimeObject
{
};

// System.Attribute
struct Attribute_tFDA8EFEFB0711976D22474794576DAF28F7440AA  : public RuntimeObject
{
};

// UnityEngine.HumanTrait
struct HumanTrait_t4EF6FC8790C40BD5BC9D36765D43202A4FAF219C  : public RuntimeObject
{
};

// System.Reflection.MemberInfo
struct MemberInfo_t  : public RuntimeObject
{
};

// System.String
struct String_t  : public RuntimeObject
{
	// System.Int32 System.String::_stringLength
	int32_t ____stringLength_4;
	// System.Char System.String::_firstChar
	Il2CppChar ____firstChar_5;
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// UnityEngine.Animation/Enumerator
struct Enumerator_t81434F7D5603121F3D7BD6DB916FE1C755307530  : public RuntimeObject
{
	// UnityEngine.Animation UnityEngine.Animation/Enumerator::m_Outer
	Animation_t6593B06C39E3B139808B19F2C719C860F3F61040* ___m_Outer_0;
	// System.Int32 UnityEngine.Animation/Enumerator::m_CurrentIndex
	int32_t ___m_CurrentIndex_1;
};

// UnityEngine.AnimatorClipInfo
struct AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03 
{
	// System.Int32 UnityEngine.AnimatorClipInfo::m_ClipInstanceID
	int32_t ___m_ClipInstanceID_0;
	// System.Single UnityEngine.AnimatorClipInfo::m_Weight
	float ___m_Weight_1;
};

// UnityEngine.AnimatorStateInfo
struct AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 
{
	// System.Int32 UnityEngine.AnimatorStateInfo::m_Name
	int32_t ___m_Name_0;
	// System.Int32 UnityEngine.AnimatorStateInfo::m_Path
	int32_t ___m_Path_1;
	// System.Int32 UnityEngine.AnimatorStateInfo::m_FullPath
	int32_t ___m_FullPath_2;
	// System.Single UnityEngine.AnimatorStateInfo::m_NormalizedTime
	float ___m_NormalizedTime_3;
	// System.Single UnityEngine.AnimatorStateInfo::m_Length
	float ___m_Length_4;
	// System.Single UnityEngine.AnimatorStateInfo::m_Speed
	float ___m_Speed_5;
	// System.Single UnityEngine.AnimatorStateInfo::m_SpeedMultiplier
	float ___m_SpeedMultiplier_6;
	// System.Int32 UnityEngine.AnimatorStateInfo::m_Tag
	int32_t ___m_Tag_7;
	// System.Int32 UnityEngine.AnimatorStateInfo::m_Loop
	int32_t ___m_Loop_8;
};

// UnityEngine.AnimatorTransitionInfo
struct AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD 
{
	// System.Int32 UnityEngine.AnimatorTransitionInfo::m_FullPath
	int32_t ___m_FullPath_0;
	// System.Int32 UnityEngine.AnimatorTransitionInfo::m_UserName
	int32_t ___m_UserName_1;
	// System.Int32 UnityEngine.AnimatorTransitionInfo::m_Name
	int32_t ___m_Name_2;
	// System.Boolean UnityEngine.AnimatorTransitionInfo::m_HasFixedDuration
	bool ___m_HasFixedDuration_3;
	// System.Single UnityEngine.AnimatorTransitionInfo::m_Duration
	float ___m_Duration_4;
	// System.Single UnityEngine.AnimatorTransitionInfo::m_NormalizedTime
	float ___m_NormalizedTime_5;
	// System.Boolean UnityEngine.AnimatorTransitionInfo::m_AnyState
	bool ___m_AnyState_6;
	// System.Int32 UnityEngine.AnimatorTransitionInfo::m_TransitionType
	int32_t ___m_TransitionType_7;
};
// Native definition for P/Invoke marshalling of UnityEngine.AnimatorTransitionInfo
struct AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD_marshaled_pinvoke
{
	int32_t ___m_FullPath_0;
	int32_t ___m_UserName_1;
	int32_t ___m_Name_2;
	int32_t ___m_HasFixedDuration_3;
	float ___m_Duration_4;
	float ___m_NormalizedTime_5;
	int32_t ___m_AnyState_6;
	int32_t ___m_TransitionType_7;
};
// Native definition for COM marshalling of UnityEngine.AnimatorTransitionInfo
struct AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD_marshaled_com
{
	int32_t ___m_FullPath_0;
	int32_t ___m_UserName_1;
	int32_t ___m_Name_2;
	int32_t ___m_HasFixedDuration_3;
	float ___m_Duration_4;
	float ___m_NormalizedTime_5;
	int32_t ___m_AnyState_6;
	int32_t ___m_TransitionType_7;
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

// UnityEngine.Animations.ConstraintSource
struct ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F 
{
	// UnityEngine.Transform UnityEngine.Animations.ConstraintSource::m_SourceTransform
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___m_SourceTransform_0;
	// System.Single UnityEngine.Animations.ConstraintSource::m_Weight
	float ___m_Weight_1;
};
// Native definition for P/Invoke marshalling of UnityEngine.Animations.ConstraintSource
struct ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F_marshaled_pinvoke
{
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___m_SourceTransform_0;
	float ___m_Weight_1;
};
// Native definition for COM marshalling of UnityEngine.Animations.ConstraintSource
struct ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F_marshaled_com
{
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___m_SourceTransform_0;
	float ___m_Weight_1;
};

// UnityEngine.Animations.DiscreteEvaluationAttribute
struct DiscreteEvaluationAttribute_tF23FCB5AB01B394BF5BD84623364A965C90F8BB9  : public Attribute_tFDA8EFEFB0711976D22474794576DAF28F7440AA
{
};

// System.Enum
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2  : public ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F
{
};
// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2_marshaled_com
{
};

// UnityEngine.HumanDescription
struct HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44 
{
	// UnityEngine.HumanBone[] UnityEngine.HumanDescription::human
	HumanBoneU5BU5D_t443B81D55400778CBB921DF04BE932ABF14BAA52* ___human_0;
	// UnityEngine.SkeletonBone[] UnityEngine.HumanDescription::skeleton
	SkeletonBoneU5BU5D_t84722CE071EF9295326D5A84492716DBC7A15A85* ___skeleton_1;
	// System.Single UnityEngine.HumanDescription::m_ArmTwist
	float ___m_ArmTwist_2;
	// System.Single UnityEngine.HumanDescription::m_ForeArmTwist
	float ___m_ForeArmTwist_3;
	// System.Single UnityEngine.HumanDescription::m_UpperLegTwist
	float ___m_UpperLegTwist_4;
	// System.Single UnityEngine.HumanDescription::m_LegTwist
	float ___m_LegTwist_5;
	// System.Single UnityEngine.HumanDescription::m_ArmStretch
	float ___m_ArmStretch_6;
	// System.Single UnityEngine.HumanDescription::m_LegStretch
	float ___m_LegStretch_7;
	// System.Single UnityEngine.HumanDescription::m_FeetSpacing
	float ___m_FeetSpacing_8;
	// System.Single UnityEngine.HumanDescription::m_GlobalScale
	float ___m_GlobalScale_9;
	// System.String UnityEngine.HumanDescription::m_RootMotionBoneName
	String_t* ___m_RootMotionBoneName_10;
	// System.Boolean UnityEngine.HumanDescription::m_HasTranslationDoF
	bool ___m_HasTranslationDoF_11;
	// System.Boolean UnityEngine.HumanDescription::m_HasExtraRoot
	bool ___m_HasExtraRoot_12;
	// System.Boolean UnityEngine.HumanDescription::m_SkeletonHasParents
	bool ___m_SkeletonHasParents_13;
};
// Native definition for P/Invoke marshalling of UnityEngine.HumanDescription
struct HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44_marshaled_pinvoke
{
	HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_pinvoke* ___human_0;
	SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_pinvoke* ___skeleton_1;
	float ___m_ArmTwist_2;
	float ___m_ForeArmTwist_3;
	float ___m_UpperLegTwist_4;
	float ___m_LegTwist_5;
	float ___m_ArmStretch_6;
	float ___m_LegStretch_7;
	float ___m_FeetSpacing_8;
	float ___m_GlobalScale_9;
	char* ___m_RootMotionBoneName_10;
	int32_t ___m_HasTranslationDoF_11;
	int32_t ___m_HasExtraRoot_12;
	int32_t ___m_SkeletonHasParents_13;
};
// Native definition for COM marshalling of UnityEngine.HumanDescription
struct HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44_marshaled_com
{
	HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_com* ___human_0;
	SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_com* ___skeleton_1;
	float ___m_ArmTwist_2;
	float ___m_ForeArmTwist_3;
	float ___m_UpperLegTwist_4;
	float ___m_LegTwist_5;
	float ___m_ArmStretch_6;
	float ___m_LegStretch_7;
	float ___m_FeetSpacing_8;
	float ___m_GlobalScale_9;
	Il2CppChar* ___m_RootMotionBoneName_10;
	int32_t ___m_HasTranslationDoF_11;
	int32_t ___m_HasExtraRoot_12;
	int32_t ___m_SkeletonHasParents_13;
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

// UnityEngine.Animations.NotKeyableAttribute
struct NotKeyableAttribute_tDDB6B25B26F649E3CED893EE1E63B6DE66844483  : public Attribute_tFDA8EFEFB0711976D22474794576DAF28F7440AA
{
};

// UnityEngine.Animations.PropertyStreamHandle
struct PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3 
{
	// System.UInt32 UnityEngine.Animations.PropertyStreamHandle::m_AnimatorBindingsVersion
	uint32_t ___m_AnimatorBindingsVersion_0;
	// System.Int32 UnityEngine.Animations.PropertyStreamHandle::handleIndex
	int32_t ___handleIndex_1;
	// System.Int32 UnityEngine.Animations.PropertyStreamHandle::valueArrayIndex
	int32_t ___valueArrayIndex_2;
	// System.Int32 UnityEngine.Animations.PropertyStreamHandle::bindType
	int32_t ___bindType_3;
};

// UnityEngine.Quaternion
struct Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 
{
	// System.Single UnityEngine.Quaternion::x
	float ___x_0;
	// System.Single UnityEngine.Quaternion::y
	float ___y_1;
	// System.Single UnityEngine.Quaternion::z
	float ___z_2;
	// System.Single UnityEngine.Quaternion::w
	float ___w_3;
};

// UnityEngine.SharedBetweenAnimatorsAttribute
struct SharedBetweenAnimatorsAttribute_t44FFD5D3B5AEBB394182D66E2198FA398087449C  : public Attribute_tFDA8EFEFB0711976D22474794576DAF28F7440AA
{
};

// System.Single
struct Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C 
{
	// System.Single System.Single::m_value
	float ___m_value_0;
};

// UnityEngine.Animations.TransformSceneHandle
struct TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB 
{
	// System.UInt32 UnityEngine.Animations.TransformSceneHandle::valid
	uint32_t ___valid_0;
	// System.Int32 UnityEngine.Animations.TransformSceneHandle::transformSceneHandleDefinitionIndex
	int32_t ___transformSceneHandleDefinitionIndex_1;
};

// UnityEngine.Animations.TransformStreamHandle
struct TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E 
{
	// System.UInt32 UnityEngine.Animations.TransformStreamHandle::m_AnimatorBindingsVersion
	uint32_t ___m_AnimatorBindingsVersion_0;
	// System.Int32 UnityEngine.Animations.TransformStreamHandle::handleIndex
	int32_t ___handleIndex_1;
	// System.Int32 UnityEngine.Animations.TransformStreamHandle::skeletonIndex
	int32_t ___skeletonIndex_2;
};

// System.UInt32
struct UInt32_t1833D51FFA667B18A5AA4B8D34DE284F8495D29B 
{
	// System.UInt32 System.UInt32::m_value
	uint32_t ___m_value_0;
};

// UnityEngine.Vector3
struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 
{
	// System.Single UnityEngine.Vector3::x
	float ___x_2;
	// System.Single UnityEngine.Vector3::y
	float ___y_3;
	// System.Single UnityEngine.Vector3::z
	float ___z_4;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// UnityEngine.Animations.AnimationHumanStream
struct AnimationHumanStream_t31E8EAD3F7C2C29CAE7B4EFB87AA84ECC6DCC6EC 
{
	// System.IntPtr UnityEngine.Animations.AnimationHumanStream::stream
	intptr_t ___stream_0;
};

// UnityEngine.Animations.AnimationStream
struct AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A 
{
	// System.UInt32 UnityEngine.Animations.AnimationStream::m_AnimatorBindingsVersion
	uint32_t ___m_AnimatorBindingsVersion_0;
	// System.IntPtr UnityEngine.Animations.AnimationStream::constant
	intptr_t ___constant_1;
	// System.IntPtr UnityEngine.Animations.AnimationStream::input
	intptr_t ___input_2;
	// System.IntPtr UnityEngine.Animations.AnimationStream::output
	intptr_t ___output_3;
	// System.IntPtr UnityEngine.Animations.AnimationStream::workspace
	intptr_t ___workspace_4;
	// System.IntPtr UnityEngine.Animations.AnimationStream::inputStreamAccessor
	intptr_t ___inputStreamAccessor_5;
	// System.IntPtr UnityEngine.Animations.AnimationStream::animationHandleBinder
	intptr_t ___animationHandleBinder_6;
};

// System.Delegate
struct Delegate_t  : public RuntimeObject
{
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject* ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.IntPtr System.Delegate::interp_method
	intptr_t ___interp_method_7;
	// System.IntPtr System.Delegate::interp_invoke_impl
	intptr_t ___interp_invoke_impl_8;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t* ___method_info_9;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t* ___original_method_info_10;
	// System.DelegateData System.Delegate::data
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_12;
};
// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};

// System.Exception
struct Exception_t  : public RuntimeObject
{
	// System.String System.Exception::_className
	String_t* ____className_1;
	// System.String System.Exception::_message
	String_t* ____message_2;
	// System.Collections.IDictionary System.Exception::_data
	RuntimeObject* ____data_3;
	// System.Exception System.Exception::_innerException
	Exception_t* ____innerException_4;
	// System.String System.Exception::_helpURL
	String_t* ____helpURL_5;
	// System.Object System.Exception::_stackTrace
	RuntimeObject* ____stackTrace_6;
	// System.String System.Exception::_stackTraceString
	String_t* ____stackTraceString_7;
	// System.String System.Exception::_remoteStackTraceString
	String_t* ____remoteStackTraceString_8;
	// System.Int32 System.Exception::_remoteStackIndex
	int32_t ____remoteStackIndex_9;
	// System.Object System.Exception::_dynamicMethods
	RuntimeObject* ____dynamicMethods_10;
	// System.Int32 System.Exception::_HResult
	int32_t ____HResult_11;
	// System.String System.Exception::_source
	String_t* ____source_12;
	// System.Runtime.Serialization.SafeSerializationManager System.Exception::_safeSerializationManager
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	// System.Diagnostics.StackTrace[] System.Exception::captured_traces
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	// System.IntPtr[] System.Exception::native_trace_ips
	IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832* ___native_trace_ips_15;
	// System.Int32 System.Exception::caught_in_unmanaged
	int32_t ___caught_in_unmanaged_16;
};
// Native definition for P/Invoke marshalling of System.Exception
struct Exception_t_marshaled_pinvoke
{
	char* ____className_1;
	char* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_pinvoke* ____innerException_4;
	char* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	char* ____stackTraceString_7;
	char* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	char* ____source_12;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
	int32_t ___caught_in_unmanaged_16;
};
// Native definition for COM marshalling of System.Exception
struct Exception_t_marshaled_com
{
	Il2CppChar* ____className_1;
	Il2CppChar* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_com* ____innerException_4;
	Il2CppChar* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	Il2CppChar* ____stackTraceString_7;
	Il2CppChar* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	Il2CppChar* ____source_12;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
	int32_t ___caught_in_unmanaged_16;
};

// UnityEngine.HumanLimit
struct HumanLimit_tE825F951DEE60E2641DD91F3C92C6B56A139A36E 
{
	// UnityEngine.Vector3 UnityEngine.HumanLimit::m_Min
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___m_Min_0;
	// UnityEngine.Vector3 UnityEngine.HumanLimit::m_Max
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___m_Max_1;
	// UnityEngine.Vector3 UnityEngine.HumanLimit::m_Center
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___m_Center_2;
	// System.Single UnityEngine.HumanLimit::m_AxisLength
	float ___m_AxisLength_3;
	// System.Int32 UnityEngine.HumanLimit::m_UseDefaultValues
	int32_t ___m_UseDefaultValues_4;
};

// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C  : public RuntimeObject
{
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;
};
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// UnityEngine.Playables.PlayableGraph
struct PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E 
{
	// System.IntPtr UnityEngine.Playables.PlayableGraph::m_Handle
	intptr_t ___m_Handle_0;
	// System.UInt32 UnityEngine.Playables.PlayableGraph::m_Version
	uint32_t ___m_Version_1;
};

// UnityEngine.Playables.PlayableHandle
struct PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 
{
	// System.IntPtr UnityEngine.Playables.PlayableHandle::m_Handle
	intptr_t ___m_Handle_0;
	// System.UInt32 UnityEngine.Playables.PlayableHandle::m_Version
	uint32_t ___m_Version_1;
};

// UnityEngine.Playables.PlayableOutputHandle
struct PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 
{
	// System.IntPtr UnityEngine.Playables.PlayableOutputHandle::m_Handle
	intptr_t ___m_Handle_0;
	// System.UInt32 UnityEngine.Playables.PlayableOutputHandle::m_Version
	uint32_t ___m_Version_1;
};

// System.RuntimeTypeHandle
struct RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B 
{
	// System.IntPtr System.RuntimeTypeHandle::value
	intptr_t ___value_0;
};

// UnityEngine.SkeletonBone
struct SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126 
{
	// System.String UnityEngine.SkeletonBone::name
	String_t* ___name_0;
	// System.String UnityEngine.SkeletonBone::parentName
	String_t* ___parentName_1;
	// UnityEngine.Vector3 UnityEngine.SkeletonBone::position
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___position_2;
	// UnityEngine.Quaternion UnityEngine.SkeletonBone::rotation
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___rotation_3;
	// UnityEngine.Vector3 UnityEngine.SkeletonBone::scale
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___scale_4;
};
// Native definition for P/Invoke marshalling of UnityEngine.SkeletonBone
struct SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_pinvoke
{
	char* ___name_0;
	char* ___parentName_1;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___position_2;
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___rotation_3;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___scale_4;
};
// Native definition for COM marshalling of UnityEngine.SkeletonBone
struct SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_com
{
	Il2CppChar* ___name_0;
	Il2CppChar* ___parentName_1;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___position_2;
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___rotation_3;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___scale_4;
};

// UnityEngine.TrackedReference
struct TrackedReference_tF35FF4FB6E89ACD81C24469FAF0CA6FFF29262A2  : public RuntimeObject
{
	// System.IntPtr UnityEngine.TrackedReference::m_Ptr
	intptr_t ___m_Ptr_0;
};
// Native definition for P/Invoke marshalling of UnityEngine.TrackedReference
struct TrackedReference_tF35FF4FB6E89ACD81C24469FAF0CA6FFF29262A2_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
};
// Native definition for COM marshalling of UnityEngine.TrackedReference
struct TrackedReference_tF35FF4FB6E89ACD81C24469FAF0CA6FFF29262A2_marshaled_com
{
	intptr_t ___m_Ptr_0;
};

// UnityEngine.Animations.AnimationClipPlayable
struct AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 
{
	// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationClipPlayable::m_Handle
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___m_Handle_0;
};

// UnityEngine.AnimationEvent
struct AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174  : public RuntimeObject
{
	// System.Single UnityEngine.AnimationEvent::m_Time
	float ___m_Time_0;
	// System.String UnityEngine.AnimationEvent::m_FunctionName
	String_t* ___m_FunctionName_1;
	// System.String UnityEngine.AnimationEvent::m_StringParameter
	String_t* ___m_StringParameter_2;
	// UnityEngine.Object UnityEngine.AnimationEvent::m_ObjectReferenceParameter
	Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___m_ObjectReferenceParameter_3;
	// System.Single UnityEngine.AnimationEvent::m_FloatParameter
	float ___m_FloatParameter_4;
	// System.Int32 UnityEngine.AnimationEvent::m_IntParameter
	int32_t ___m_IntParameter_5;
	// System.Int32 UnityEngine.AnimationEvent::m_MessageOptions
	int32_t ___m_MessageOptions_6;
	// UnityEngine.AnimationEventSource UnityEngine.AnimationEvent::m_Source
	int32_t ___m_Source_7;
	// UnityEngine.AnimationState UnityEngine.AnimationEvent::m_StateSender
	AnimationState_tC704F25A20169025B6CFDC2F00DC84152B5B73CE* ___m_StateSender_8;
	// UnityEngine.AnimatorStateInfo UnityEngine.AnimationEvent::m_AnimatorStateInfo
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 ___m_AnimatorStateInfo_9;
	// UnityEngine.AnimatorClipInfo UnityEngine.AnimationEvent::m_AnimatorClipInfo
	AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03 ___m_AnimatorClipInfo_10;
};
// Native definition for P/Invoke marshalling of UnityEngine.AnimationEvent
struct AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174_marshaled_pinvoke
{
	float ___m_Time_0;
	char* ___m_FunctionName_1;
	char* ___m_StringParameter_2;
	Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke ___m_ObjectReferenceParameter_3;
	float ___m_FloatParameter_4;
	int32_t ___m_IntParameter_5;
	int32_t ___m_MessageOptions_6;
	int32_t ___m_Source_7;
	AnimationState_tC704F25A20169025B6CFDC2F00DC84152B5B73CE* ___m_StateSender_8;
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 ___m_AnimatorStateInfo_9;
	AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03 ___m_AnimatorClipInfo_10;
};
// Native definition for COM marshalling of UnityEngine.AnimationEvent
struct AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174_marshaled_com
{
	float ___m_Time_0;
	Il2CppChar* ___m_FunctionName_1;
	Il2CppChar* ___m_StringParameter_2;
	Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com* ___m_ObjectReferenceParameter_3;
	float ___m_FloatParameter_4;
	int32_t ___m_IntParameter_5;
	int32_t ___m_MessageOptions_6;
	int32_t ___m_Source_7;
	AnimationState_tC704F25A20169025B6CFDC2F00DC84152B5B73CE* ___m_StateSender_8;
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 ___m_AnimatorStateInfo_9;
	AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03 ___m_AnimatorClipInfo_10;
};

// UnityEngine.Animations.AnimationLayerMixerPlayable
struct AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D 
{
	// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationLayerMixerPlayable::m_Handle
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___m_Handle_0;
};

// UnityEngine.Animations.AnimationMixerPlayable
struct AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0 
{
	// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationMixerPlayable::m_Handle
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___m_Handle_0;
};

// UnityEngine.Animations.AnimationMotionXToDeltaPlayable
struct AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18 
{
	// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationMotionXToDeltaPlayable::m_Handle
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___m_Handle_0;
};

// UnityEngine.Animations.AnimationOffsetPlayable
struct AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4 
{
	// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationOffsetPlayable::m_Handle
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___m_Handle_0;
};

// UnityEngine.Animations.AnimationPlayableOutput
struct AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E 
{
	// UnityEngine.Playables.PlayableOutputHandle UnityEngine.Animations.AnimationPlayableOutput::m_Handle
	PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 ___m_Handle_0;
};

// UnityEngine.Animations.AnimationPosePlayable
struct AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C 
{
	// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationPosePlayable::m_Handle
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___m_Handle_0;
};

// UnityEngine.Animations.AnimationRemoveScalePlayable
struct AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD 
{
	// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationRemoveScalePlayable::m_Handle
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___m_Handle_0;
};

// UnityEngine.Animations.AnimationScriptPlayable
struct AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127 
{
	// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationScriptPlayable::m_Handle
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___m_Handle_0;
};

// UnityEngine.AnimationState
struct AnimationState_tC704F25A20169025B6CFDC2F00DC84152B5B73CE  : public TrackedReference_tF35FF4FB6E89ACD81C24469FAF0CA6FFF29262A2
{
};

// UnityEngine.Animations.AnimatorControllerPlayable
struct AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A 
{
	// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimatorControllerPlayable::m_Handle
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___m_Handle_0;
};

// UnityEngine.Avatar
struct Avatar_t7861E57EEE2CF8CC61BD63C09737BA22F7ABCA0F  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.AvatarMask
struct AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.Component
struct Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.HumanBone
struct HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8 
{
	// System.String UnityEngine.HumanBone::m_BoneName
	String_t* ___m_BoneName_0;
	// System.String UnityEngine.HumanBone::m_HumanName
	String_t* ___m_HumanName_1;
	// UnityEngine.HumanLimit UnityEngine.HumanBone::limit
	HumanLimit_tE825F951DEE60E2641DD91F3C92C6B56A139A36E ___limit_2;
};
// Native definition for P/Invoke marshalling of UnityEngine.HumanBone
struct HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_pinvoke
{
	char* ___m_BoneName_0;
	char* ___m_HumanName_1;
	HumanLimit_tE825F951DEE60E2641DD91F3C92C6B56A139A36E ___limit_2;
};
// Native definition for COM marshalling of UnityEngine.HumanBone
struct HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_com
{
	Il2CppChar* ___m_BoneName_0;
	Il2CppChar* ___m_HumanName_1;
	HumanLimit_tE825F951DEE60E2641DD91F3C92C6B56A139A36E ___limit_2;
};

// UnityEngine.Motion
struct Motion_tBCD49FBF5608AD21FC03B63C8182FABCEF2707AC  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
	// System.Boolean UnityEngine.Motion::<isAnimatorMotion>k__BackingField
	bool ___U3CisAnimatorMotionU3Ek__BackingField_4;
};

// System.MulticastDelegate
struct MulticastDelegate_t  : public Delegate_t
{
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771* ___delegates_13;
};
// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_13;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_13;
};

// UnityEngine.Playables.Playable
struct Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F 
{
	// UnityEngine.Playables.PlayableHandle UnityEngine.Playables.Playable::m_Handle
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___m_Handle_0;
};

// UnityEngine.Playables.PlayableBinding
struct PlayableBinding_tB68B3BAC47F4F4C559640472174D5BEF93CB6AB4 
{
	// System.String UnityEngine.Playables.PlayableBinding::m_StreamName
	String_t* ___m_StreamName_0;
	// UnityEngine.Object UnityEngine.Playables.PlayableBinding::m_SourceObject
	Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___m_SourceObject_1;
	// System.Type UnityEngine.Playables.PlayableBinding::m_SourceBindingType
	Type_t* ___m_SourceBindingType_2;
	// UnityEngine.Playables.PlayableBinding/CreateOutputMethod UnityEngine.Playables.PlayableBinding::m_CreateOutputMethod
	CreateOutputMethod_tD18AFE3B69E6DDD913D82D5FA1D5D909CEEC8509* ___m_CreateOutputMethod_3;
};
// Native definition for P/Invoke marshalling of UnityEngine.Playables.PlayableBinding
struct PlayableBinding_tB68B3BAC47F4F4C559640472174D5BEF93CB6AB4_marshaled_pinvoke
{
	char* ___m_StreamName_0;
	Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke ___m_SourceObject_1;
	Type_t* ___m_SourceBindingType_2;
	Il2CppMethodPointer ___m_CreateOutputMethod_3;
};
// Native definition for COM marshalling of UnityEngine.Playables.PlayableBinding
struct PlayableBinding_tB68B3BAC47F4F4C559640472174D5BEF93CB6AB4_marshaled_com
{
	Il2CppChar* ___m_StreamName_0;
	Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com* ___m_SourceObject_1;
	Type_t* ___m_SourceBindingType_2;
	Il2CppMethodPointer ___m_CreateOutputMethod_3;
};

// UnityEngine.Playables.PlayableOutput
struct PlayableOutput_t2F7C45A58DA3E788EEDDB439549E21CF3FCF3680 
{
	// UnityEngine.Playables.PlayableOutputHandle UnityEngine.Playables.PlayableOutput::m_Handle
	PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 ___m_Handle_0;
};

// UnityEngine.RuntimeAnimatorController
struct RuntimeAnimatorController_t6F7C753402B42EC23C163099CF935C5E0D7A7254  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.ScriptableObject
struct ScriptableObject_tB3BFDB921A1B1795B38A5417D3B97A89A140436A  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};
// Native definition for P/Invoke marshalling of UnityEngine.ScriptableObject
struct ScriptableObject_tB3BFDB921A1B1795B38A5417D3B97A89A140436A_marshaled_pinvoke : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke
{
};
// Native definition for COM marshalling of UnityEngine.ScriptableObject
struct ScriptableObject_tB3BFDB921A1B1795B38A5417D3B97A89A140436A_marshaled_com : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com
{
};

// System.SystemException
struct SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295  : public Exception_t
{
};

// System.Type
struct Type_t  : public MemberInfo_t
{
	// System.RuntimeTypeHandle System.Type::_impl
	RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B ____impl_8;
};

// UnityEngine.AnimationClip
struct AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712  : public Motion_tBCD49FBF5608AD21FC03B63C8182FABCEF2707AC
{
};

// UnityEngine.AnimatorOverrideController
struct AnimatorOverrideController_tF78BD58B30BB0D767E7A96F8428EA66F2DFD5493  : public RuntimeAnimatorController_t6F7C753402B42EC23C163099CF935C5E0D7A7254
{
	// UnityEngine.AnimatorOverrideController/OnOverrideControllerDirtyCallback UnityEngine.AnimatorOverrideController::OnOverrideControllerDirty
	OnOverrideControllerDirtyCallback_tDC67F7661A27502AD804BDE0B696955AFD4A44D5* ___OnOverrideControllerDirty_4;
};

// System.ArgumentException
struct ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263  : public SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295
{
	// System.String System.ArgumentException::_paramName
	String_t* ____paramName_18;
};

// UnityEngine.Behaviour
struct Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// System.IndexOutOfRangeException
struct IndexOutOfRangeException_t7ECB35264FB6CA8FAA516BD958F4B2ADC78E8A82  : public SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295
{
};

// System.InvalidCastException
struct InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E  : public SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295
{
};

// System.InvalidOperationException
struct InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB  : public SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295
{
};

// System.NullReferenceException
struct NullReferenceException_tBDE63A6D24569B964908408389070C6A9F5005BB  : public SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295
{
};

// UnityEngine.StateMachineBehaviour
struct StateMachineBehaviour_t59C5685227B06222F5AF7027E2DA530AB99AFDF7  : public ScriptableObject_tB3BFDB921A1B1795B38A5417D3B97A89A140436A
{
};

// UnityEngine.Transform
struct Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// UnityEngine.AnimatorOverrideController/OnOverrideControllerDirtyCallback
struct OnOverrideControllerDirtyCallback_tDC67F7661A27502AD804BDE0B696955AFD4A44D5  : public MulticastDelegate_t
{
};

// UnityEngine.Playables.PlayableBinding/CreateOutputMethod
struct CreateOutputMethod_tD18AFE3B69E6DDD913D82D5FA1D5D909CEEC8509  : public MulticastDelegate_t
{
};

// UnityEngine.Animation
struct Animation_t6593B06C39E3B139808B19F2C719C860F3F61040  : public Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA
{
};

// UnityEngine.Animator
struct Animator_t8A52E42AE54F76681838FE9E632683EF3952E883  : public Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA
{
};

// System.ArgumentNullException
struct ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129  : public ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263
{
};

// System.ArgumentOutOfRangeException
struct ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F  : public ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263
{
	// System.Object System.ArgumentOutOfRangeException::_actualValue
	RuntimeObject* ____actualValue_19;
};

// UnityEngine.Animations.LookAtConstraint
struct LookAtConstraint_t2B4569F15EA2736FAC97AD3DE35B093AE8B5D919  : public Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA
{
};

// <Module>

// <Module>

// System.Collections.Generic.List`1<UnityEngine.AnimatorClipInfo>
struct List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<UnityEngine.AnimatorClipInfo>

// System.Collections.Generic.List`1<UnityEngine.Animations.ConstraintSource>
struct List_1_tF88FB42B55EA7DB2BFC546CB9573DFF2D6F0AECE_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	ConstraintSourceU5BU5D_t8849C48A722B655E448FBDA392EE981AC3E0BCBC* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<UnityEngine.Animations.ConstraintSource>

// UnityEngine.Animations.AnimationPlayableBinding

// UnityEngine.Animations.AnimationPlayableBinding

// UnityEngine.Animations.AnimationPlayableExtensions

// UnityEngine.Animations.AnimationPlayableExtensions

// UnityEngine.Animations.AnimationPlayableGraphExtensions

// UnityEngine.Animations.AnimationPlayableGraphExtensions

// UnityEngine.Playables.AnimationPlayableUtilities

// UnityEngine.Playables.AnimationPlayableUtilities

// UnityEngine.AnimatorControllerParameter

// UnityEngine.AnimatorControllerParameter

// UnityEngine.Animations.AnimatorJobExtensions

// UnityEngine.Animations.AnimatorJobExtensions

// UnityEngine.HumanTrait

// UnityEngine.HumanTrait

// System.String
struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// System.String

// System.ValueType

// System.ValueType

// UnityEngine.Animation/Enumerator

// UnityEngine.Animation/Enumerator

// UnityEngine.AnimatorClipInfo

// UnityEngine.AnimatorClipInfo

// UnityEngine.AnimatorStateInfo

// UnityEngine.AnimatorStateInfo

// UnityEngine.AnimatorTransitionInfo

// UnityEngine.AnimatorTransitionInfo

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// System.Boolean

// UnityEngine.Animations.ConstraintSource

// UnityEngine.Animations.ConstraintSource

// UnityEngine.Animations.DiscreteEvaluationAttribute

// UnityEngine.Animations.DiscreteEvaluationAttribute

// System.Enum
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2_StaticFields
{
	// System.Char[] System.Enum::enumSeperatorCharArray
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___enumSeperatorCharArray_0;
};

// System.Enum

// UnityEngine.HumanDescription

// UnityEngine.HumanDescription

// System.Int32

// System.Int32

// System.IntPtr
struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
};

// System.IntPtr

// UnityEngine.Animations.NotKeyableAttribute

// UnityEngine.Animations.NotKeyableAttribute

// UnityEngine.Animations.PropertyStreamHandle

// UnityEngine.Animations.PropertyStreamHandle

// UnityEngine.Quaternion
struct Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974_StaticFields
{
	// UnityEngine.Quaternion UnityEngine.Quaternion::identityQuaternion
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___identityQuaternion_4;
};

// UnityEngine.Quaternion

// UnityEngine.SharedBetweenAnimatorsAttribute

// UnityEngine.SharedBetweenAnimatorsAttribute

// System.Single

// System.Single

// UnityEngine.Animations.TransformSceneHandle

// UnityEngine.Animations.TransformSceneHandle

// UnityEngine.Animations.TransformStreamHandle

// UnityEngine.Animations.TransformStreamHandle

// System.UInt32

// System.UInt32

// UnityEngine.Vector3
struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields
{
	// UnityEngine.Vector3 UnityEngine.Vector3::zeroVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___zeroVector_5;
	// UnityEngine.Vector3 UnityEngine.Vector3::oneVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___oneVector_6;
	// UnityEngine.Vector3 UnityEngine.Vector3::upVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___upVector_7;
	// UnityEngine.Vector3 UnityEngine.Vector3::downVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___downVector_8;
	// UnityEngine.Vector3 UnityEngine.Vector3::leftVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___leftVector_9;
	// UnityEngine.Vector3 UnityEngine.Vector3::rightVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___rightVector_10;
	// UnityEngine.Vector3 UnityEngine.Vector3::forwardVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___forwardVector_11;
	// UnityEngine.Vector3 UnityEngine.Vector3::backVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___backVector_12;
	// UnityEngine.Vector3 UnityEngine.Vector3::positiveInfinityVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___positiveInfinityVector_13;
	// UnityEngine.Vector3 UnityEngine.Vector3::negativeInfinityVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___negativeInfinityVector_14;
};

// UnityEngine.Vector3

// System.Void

// System.Void

// UnityEngine.Animations.AnimationHumanStream

// UnityEngine.Animations.AnimationHumanStream

// UnityEngine.Animations.AnimationStream

// UnityEngine.Animations.AnimationStream

// System.Delegate

// System.Delegate

// UnityEngine.HumanLimit

// UnityEngine.HumanLimit

// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_StaticFields
{
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;
};

// UnityEngine.Object

// UnityEngine.Playables.PlayableGraph

// UnityEngine.Playables.PlayableGraph

// UnityEngine.Playables.PlayableHandle
struct PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_StaticFields
{
	// UnityEngine.Playables.PlayableHandle UnityEngine.Playables.PlayableHandle::m_Null
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___m_Null_2;
};

// UnityEngine.Playables.PlayableHandle

// UnityEngine.Playables.PlayableOutputHandle
struct PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883_StaticFields
{
	// UnityEngine.Playables.PlayableOutputHandle UnityEngine.Playables.PlayableOutputHandle::m_Null
	PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 ___m_Null_2;
};

// UnityEngine.Playables.PlayableOutputHandle

// System.RuntimeTypeHandle

// System.RuntimeTypeHandle

// UnityEngine.SkeletonBone

// UnityEngine.SkeletonBone

// UnityEngine.TrackedReference

// UnityEngine.TrackedReference

// UnityEngine.Animations.AnimationClipPlayable

// UnityEngine.Animations.AnimationClipPlayable

// UnityEngine.AnimationEvent

// UnityEngine.AnimationEvent

// UnityEngine.Animations.AnimationLayerMixerPlayable
struct AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_StaticFields
{
	// UnityEngine.Animations.AnimationLayerMixerPlayable UnityEngine.Animations.AnimationLayerMixerPlayable::m_NullPlayable
	AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D ___m_NullPlayable_1;
};

// UnityEngine.Animations.AnimationLayerMixerPlayable

// UnityEngine.Animations.AnimationMixerPlayable
struct AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0_StaticFields
{
	// UnityEngine.Animations.AnimationMixerPlayable UnityEngine.Animations.AnimationMixerPlayable::m_NullPlayable
	AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0 ___m_NullPlayable_1;
};

// UnityEngine.Animations.AnimationMixerPlayable

// UnityEngine.Animations.AnimationMotionXToDeltaPlayable
struct AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18_StaticFields
{
	// UnityEngine.Animations.AnimationMotionXToDeltaPlayable UnityEngine.Animations.AnimationMotionXToDeltaPlayable::m_NullPlayable
	AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18 ___m_NullPlayable_1;
};

// UnityEngine.Animations.AnimationMotionXToDeltaPlayable

// UnityEngine.Animations.AnimationOffsetPlayable
struct AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4_StaticFields
{
	// UnityEngine.Animations.AnimationOffsetPlayable UnityEngine.Animations.AnimationOffsetPlayable::m_NullPlayable
	AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4 ___m_NullPlayable_1;
};

// UnityEngine.Animations.AnimationOffsetPlayable

// UnityEngine.Animations.AnimationPlayableOutput

// UnityEngine.Animations.AnimationPlayableOutput

// UnityEngine.Animations.AnimationPosePlayable
struct AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C_StaticFields
{
	// UnityEngine.Animations.AnimationPosePlayable UnityEngine.Animations.AnimationPosePlayable::m_NullPlayable
	AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C ___m_NullPlayable_1;
};

// UnityEngine.Animations.AnimationPosePlayable

// UnityEngine.Animations.AnimationRemoveScalePlayable
struct AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD_StaticFields
{
	// UnityEngine.Animations.AnimationRemoveScalePlayable UnityEngine.Animations.AnimationRemoveScalePlayable::m_NullPlayable
	AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD ___m_NullPlayable_1;
};

// UnityEngine.Animations.AnimationRemoveScalePlayable

// UnityEngine.Animations.AnimationScriptPlayable
struct AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127_StaticFields
{
	// UnityEngine.Animations.AnimationScriptPlayable UnityEngine.Animations.AnimationScriptPlayable::m_NullPlayable
	AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127 ___m_NullPlayable_1;
};

// UnityEngine.Animations.AnimationScriptPlayable

// UnityEngine.AnimationState

// UnityEngine.AnimationState

// UnityEngine.Animations.AnimatorControllerPlayable
struct AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_StaticFields
{
	// UnityEngine.Animations.AnimatorControllerPlayable UnityEngine.Animations.AnimatorControllerPlayable::m_NullPlayable
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A ___m_NullPlayable_1;
};

// UnityEngine.Animations.AnimatorControllerPlayable

// UnityEngine.Avatar

// UnityEngine.Avatar

// UnityEngine.AvatarMask

// UnityEngine.AvatarMask

// UnityEngine.HumanBone

// UnityEngine.HumanBone

// UnityEngine.Motion

// UnityEngine.Motion

// UnityEngine.Playables.Playable
struct Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F_StaticFields
{
	// UnityEngine.Playables.Playable UnityEngine.Playables.Playable::m_NullPlayable
	Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F ___m_NullPlayable_1;
};

// UnityEngine.Playables.Playable

// UnityEngine.Playables.PlayableBinding
struct PlayableBinding_tB68B3BAC47F4F4C559640472174D5BEF93CB6AB4_StaticFields
{
	// UnityEngine.Playables.PlayableBinding[] UnityEngine.Playables.PlayableBinding::None
	PlayableBindingU5BU5D_tC50C3F27A8E4246488F7A5998CAABAC4811A92CD* ___None_4;
	// System.Double UnityEngine.Playables.PlayableBinding::DefaultDuration
	double ___DefaultDuration_5;
};

// UnityEngine.Playables.PlayableBinding

// UnityEngine.Playables.PlayableOutput
struct PlayableOutput_t2F7C45A58DA3E788EEDDB439549E21CF3FCF3680_StaticFields
{
	// UnityEngine.Playables.PlayableOutput UnityEngine.Playables.PlayableOutput::m_NullPlayableOutput
	PlayableOutput_t2F7C45A58DA3E788EEDDB439549E21CF3FCF3680 ___m_NullPlayableOutput_1;
};

// UnityEngine.Playables.PlayableOutput

// UnityEngine.RuntimeAnimatorController

// UnityEngine.RuntimeAnimatorController

// UnityEngine.ScriptableObject

// UnityEngine.ScriptableObject

// System.Type
struct Type_t_StaticFields
{
	// System.Reflection.Binder modreq(System.Runtime.CompilerServices.IsVolatile) System.Type::s_defaultBinder
	Binder_t91BFCE95A7057FADF4D8A1A342AFE52872246235* ___s_defaultBinder_0;
	// System.Char System.Type::Delimiter
	Il2CppChar ___Delimiter_1;
	// System.Type[] System.Type::EmptyTypes
	TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB* ___EmptyTypes_2;
	// System.Object System.Type::Missing
	RuntimeObject* ___Missing_3;
	// System.Reflection.MemberFilter System.Type::FilterAttribute
	MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553* ___FilterAttribute_4;
	// System.Reflection.MemberFilter System.Type::FilterName
	MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553* ___FilterName_5;
	// System.Reflection.MemberFilter System.Type::FilterNameIgnoreCase
	MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553* ___FilterNameIgnoreCase_6;
};

// System.Type

// UnityEngine.AnimationClip

// UnityEngine.AnimationClip

// UnityEngine.AnimatorOverrideController

// UnityEngine.AnimatorOverrideController

// System.IndexOutOfRangeException

// System.IndexOutOfRangeException

// System.InvalidCastException

// System.InvalidCastException

// System.InvalidOperationException

// System.InvalidOperationException

// System.NullReferenceException

// System.NullReferenceException

// UnityEngine.StateMachineBehaviour

// UnityEngine.StateMachineBehaviour

// UnityEngine.Transform

// UnityEngine.Transform

// UnityEngine.AnimatorOverrideController/OnOverrideControllerDirtyCallback

// UnityEngine.AnimatorOverrideController/OnOverrideControllerDirtyCallback

// UnityEngine.Playables.PlayableBinding/CreateOutputMethod

// UnityEngine.Playables.PlayableBinding/CreateOutputMethod

// UnityEngine.Animation

// UnityEngine.Animation

// UnityEngine.Animator

// UnityEngine.Animator

// System.ArgumentNullException

// System.ArgumentNullException

// System.ArgumentOutOfRangeException

// System.ArgumentOutOfRangeException

// UnityEngine.Animations.LookAtConstraint

// UnityEngine.Animations.LookAtConstraint
#ifdef __clang__
#pragma clang diagnostic pop
#endif
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771  : public RuntimeArray
{
	ALIGN_FIELD (8) Delegate_t* m_Items[1];

	inline Delegate_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Delegate_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Delegate_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Delegate_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// UnityEngine.HumanBone[]
struct HumanBoneU5BU5D_t443B81D55400778CBB921DF04BE932ABF14BAA52  : public RuntimeArray
{
	ALIGN_FIELD (8) HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8 m_Items[1];

	inline HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8 GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8 value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___m_BoneName_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___m_HumanName_1), (void*)NULL);
		#endif
	}
	inline HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8 GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8 value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___m_BoneName_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___m_HumanName_1), (void*)NULL);
		#endif
	}
};
// UnityEngine.SkeletonBone[]
struct SkeletonBoneU5BU5D_t84722CE071EF9295326D5A84492716DBC7A15A85  : public RuntimeArray
{
	ALIGN_FIELD (8) SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126 m_Items[1];

	inline SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126 GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126 value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___name_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___parentName_1), (void*)NULL);
		#endif
	}
	inline SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126 GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126 value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___name_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___parentName_1), (void*)NULL);
		#endif
	}
};
// UnityEngine.AnimationClip[]
struct AnimationClipU5BU5D_t48CE1A495BA95608745A065C735F2D5BB8DE5A0F  : public RuntimeArray
{
	ALIGN_FIELD (8) AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* m_Items[1];

	inline AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// UnityEngine.AnimationEvent[]
struct AnimationEventU5BU5D_t7618D98124AE2DE212E31279AD51EB4D9CEEAA9E  : public RuntimeArray
{
	ALIGN_FIELD (8) AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174* m_Items[1];

	inline AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// UnityEngine.AnimatorClipInfo[]
struct AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A  : public RuntimeArray
{
	ALIGN_FIELD (8) AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03 m_Items[1];

	inline AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03 GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03 value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03 GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03 value)
	{
		m_Items[index] = value;
	}
};
// UnityEngine.AnimatorControllerParameter[]
struct AnimatorControllerParameterU5BU5D_tAB05125F5DC0D98F59351CD7D8C9880DFFA8EA21  : public RuntimeArray
{
	ALIGN_FIELD (8) AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* m_Items[1];

	inline AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};

IL2CPP_EXTERN_C void HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshal_pinvoke(const HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8& unmarshaled, HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_pinvoke& marshaled);
IL2CPP_EXTERN_C void HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshal_pinvoke_back(const HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_pinvoke& marshaled, HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8& unmarshaled);
IL2CPP_EXTERN_C void HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshal_pinvoke_cleanup(HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_pinvoke& marshaled);
IL2CPP_EXTERN_C void SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshal_pinvoke(const SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126& unmarshaled, SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_pinvoke& marshaled);
IL2CPP_EXTERN_C void SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshal_pinvoke_back(const SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_pinvoke& marshaled, SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126& unmarshaled);
IL2CPP_EXTERN_C void SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshal_pinvoke_cleanup(SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_pinvoke& marshaled);
IL2CPP_EXTERN_C void HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshal_com(const HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8& unmarshaled, HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_com& marshaled);
IL2CPP_EXTERN_C void HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshal_com_back(const HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_com& marshaled, HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8& unmarshaled);
IL2CPP_EXTERN_C void HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshal_com_cleanup(HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_com& marshaled);
IL2CPP_EXTERN_C void SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshal_com(const SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126& unmarshaled, SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_com& marshaled);
IL2CPP_EXTERN_C void SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshal_com_back(const SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_com& marshaled, SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126& unmarshaled);
IL2CPP_EXTERN_C void SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshal_com_cleanup(SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_com& marshaled);
IL2CPP_EXTERN_C void Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshal_pinvoke(const Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C& unmarshaled, Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke& marshaled);
IL2CPP_EXTERN_C void Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshal_pinvoke_back(const Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke& marshaled, Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C& unmarshaled);
IL2CPP_EXTERN_C void Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshal_pinvoke_cleanup(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke& marshaled);
IL2CPP_EXTERN_C void Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshal_com(const Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C& unmarshaled, Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com& marshaled);
IL2CPP_EXTERN_C void Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshal_com_back(const Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com& marshaled, Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C& unmarshaled);
IL2CPP_EXTERN_C void Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshal_com_cleanup(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com& marshaled);

// System.Void UnityEngine.Playables.PlayableOutputExtensions::SetSourcePlayable<UnityEngine.Animations.AnimationPlayableOutput,UnityEngine.Playables.Playable>(U,V,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PlayableOutputExtensions_SetSourcePlayable_TisAnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E_TisPlayable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F_m015148BFEF9CA1BBC4DE5625B47A768D4B51A543_gshared (AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E ___0_output, Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F ___1_value, int32_t ___2_port, const RuntimeMethod* method) ;
// System.Void UnityEngine.Playables.PlayableOutputExtensions::SetSourcePlayable<UnityEngine.Animations.AnimationPlayableOutput,UnityEngine.Animations.AnimationClipPlayable>(U,V)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PlayableOutputExtensions_SetSourcePlayable_TisAnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E_TisAnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969_m389C7055BB3E25FF8CC06AF5A9F6EE1BE821B43D_gshared (AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E ___0_output, AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 ___1_value, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationRemoveScalePlayable>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_IsPlayableOfType_TisAnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD_m961964786905D9B20B750AC27CB64EA48C4C5971_gshared (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimatorControllerPlayable>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_IsPlayableOfType_TisAnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_m83ED61FDEBC627830082467B83BF64724C68CD70_gshared (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationOffsetPlayable>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_IsPlayableOfType_TisAnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4_mB35755A4D179F4DA51A96FCB3C4A8DF105C2BB12_gshared (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationScriptPlayable>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_IsPlayableOfType_TisAnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127_m4F637AD893630043482383791FA7A0285EB16F6E_gshared (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationLayerMixerPlayable>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_IsPlayableOfType_TisAnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_m23764EE36FE7A81A245C7146FF1E9DF6530DA321_gshared (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationClipPlayable>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_IsPlayableOfType_TisAnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969_m9AA33A8596A6C41CAA768B0A6EF59B75658A1FB8_gshared (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationPosePlayable>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_IsPlayableOfType_TisAnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C_m61A79154B28DAE22A64165C871757F3E447822A6_gshared (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationMotionXToDeltaPlayable>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_IsPlayableOfType_TisAnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18_mE6DAD58415B04EE79FD34641B365283758722ABF_gshared (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationMixerPlayable>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_IsPlayableOfType_TisAnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0_m644E76378CB4DDC0CE669FE1DCE8A8917595D0ED_gshared (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableOutputHandle::IsPlayableOutputOfType<UnityEngine.Animations.AnimationPlayableOutput>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableOutputHandle_IsPlayableOutputOfType_TisAnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E_mDA87D18E66EB65AFF53F5AD517C7FBA69DD6D793_gshared (PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883* __this, const RuntimeMethod* method) ;

// System.Void UnityEngine.AnimatorOverrideController/OnOverrideControllerDirtyCallback::Invoke()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void OnOverrideControllerDirtyCallback_Invoke_m538DCB0FFFE75495DC3977DBBF55A07C570F8B5A_inline (OnOverrideControllerDirtyCallback_tDC67F7661A27502AD804BDE0B696955AFD4A44D5* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_m2149FA40CEC8D82AC20D3508AB40C0D8EFEF68E6 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Avatar::get_humanDescription_Injected(UnityEngine.HumanDescription&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Avatar_get_humanDescription_Injected_mB2DC483AC2212729E7C92641B6FFDDB4056BF3D0 (Avatar_t7861E57EEE2CF8CC61BD63C09737BA22F7ABCA0F* __this, HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44* ___0_ret, const RuntimeMethod* method) ;
// System.Void UnityEngine.AvatarMask::Internal_Create(UnityEngine.AvatarMask)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AvatarMask_Internal_Create_mDC9923A288EDD1F883662D1A5C562BFCDA8F6FFA (AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF* ___0_self, const RuntimeMethod* method) ;
// System.Single UnityEngine.AvatarMask::GetTransformWeight(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AvatarMask_GetTransformWeight_mB0574B9F42737B0115832C96BB8F01C5AEDB7BD2 (AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF* __this, int32_t ___0_index, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Animator::StringToHash(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_StringToHash_mD67B872C411BE37641F49D7AA1DBD45B67F63E3A (String_t* ___0_name, const RuntimeMethod* method) ;
// System.Boolean System.String::op_Equality(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1 (String_t* ___0_a, String_t* ___1_b, const RuntimeMethod* method) ;
// System.String UnityEngine.AnimatorControllerParameter::get_name()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AnimatorControllerParameter_get_name_mEB3938ADDF296A0FB37283C987AEE6EC0F4F629E (AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* __this, const RuntimeMethod* method) ;
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animation/Enumerator::.ctor(UnityEngine.Animation)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Enumerator__ctor_mF3FB66377864673B8DAF14A36DB6D069B98A92F4 (Enumerator_t81434F7D5603121F3D7BD6DB916FE1C755307530* __this, Animation_t6593B06C39E3B139808B19F2C719C860F3F61040* ___0_outer, const RuntimeMethod* method) ;
// UnityEngine.AnimationState UnityEngine.Animation::GetStateAtIndex(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationState_tC704F25A20169025B6CFDC2F00DC84152B5B73CE* Animation_GetStateAtIndex_mA06564CBB11021A3ADA69EA0BCDCD820183E240F (Animation_t6593B06C39E3B139808B19F2C719C860F3F61040* __this, int32_t ___0_index, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Animation::GetStateCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animation_GetStateCount_mB779E6750180C77CE5F2E81B78C9AFEE93FCB1FE (Animation_t6593B06C39E3B139808B19F2C719C860F3F61040* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.TrackedReference::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TrackedReference__ctor_m0E498FD0AD5807B7B91CB0005170E522DAE3616A (TrackedReference_tF35FF4FB6E89ACD81C24469FAF0CA6FFF29262A2* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.AnimationEvent::get_isFiredByAnimator()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationEvent_get_isFiredByAnimator_m933B34D40A0B7781D943D77731D93A6D6A334AD3 (AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Debug::LogError(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2 (RuntimeObject* ___0_message, const RuntimeMethod* method) ;
// System.Void UnityEngine.Motion::get_averageSpeed_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Motion_get_averageSpeed_Injected_m11BC2AAEBABFC331969F355305A413277D8C1533 (Motion_tBCD49FBF5608AD21FC03B63C8182FABCEF2707AC* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_ret, const RuntimeMethod* method) ;
// UnityEngine.AnimationClip UnityEngine.AnimatorClipInfo::InstanceIDToAnimationClipPPtr(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* AnimatorClipInfo_InstanceIDToAnimationClipPPtr_mF656EAD29AB800127963F8A663F260E89EBF2CEC (int32_t ___0_instanceID, const RuntimeMethod* method) ;
// UnityEngine.AnimationClip UnityEngine.AnimatorClipInfo::get_clip()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* AnimatorClipInfo_get_clip_m6205DB403EBEAEAC14DB8928FFC7EBC50142E1AC (AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03* __this, const RuntimeMethod* method) ;
// System.Single UnityEngine.AnimatorClipInfo::get_weight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorClipInfo_get_weight_m1CC29E2C37B30993EFFD12161059E4AD86EE287D (AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03* __this, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.AnimatorStateInfo::get_fullPathHash()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorStateInfo_get_fullPathHash_m583FA8FAAC28BF65A65166D100949833E515210F (AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* __this, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.AnimatorStateInfo::get_shortNameHash()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorStateInfo_get_shortNameHash_mEE816B999C282A3BA95AFC64278B994E899B7004 (AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* __this, const RuntimeMethod* method) ;
// System.Single UnityEngine.AnimatorStateInfo::get_normalizedTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorStateInfo_get_normalizedTime_m087C7E5A72122ADF18EBB4AC8391103B9119CCC6 (AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* __this, const RuntimeMethod* method) ;
// System.Single UnityEngine.AnimatorStateInfo::get_length()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorStateInfo_get_length_m2FAE317264F7C796427207F8F28E550DB49F9541 (AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* __this, const RuntimeMethod* method) ;
// System.Single UnityEngine.AnimatorStateInfo::get_speed()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorStateInfo_get_speed_m473826E53D827AEE36A7FF0662AC4817C2EF3495 (AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* __this, const RuntimeMethod* method) ;
// System.Single UnityEngine.AnimatorStateInfo::get_speedMultiplier()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorStateInfo_get_speedMultiplier_mA078AADECC98C266C82E2756A351235DDC63A107 (AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.AnimatorStateInfo::get_loop()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorStateInfo_get_loop_m3DC728FC9AF0D4B27B3C28157395BB2F57CC3DA7 (AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* __this, const RuntimeMethod* method) ;
// System.Single UnityEngine.Animator::GetFloatID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetFloatID_m0300DB1901B65F007EA9E0E98ACB91E105FDD366 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::SetFloatString(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetFloatString_m1AA50083AAAE1DFFA7FB64502EA106795D3756B4 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, String_t* ___0_name, float ___1_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::SetFloatID(System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetFloatID_m348942A23D4C734DDF4D04C7609E5CD9EBAB66AA (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, float ___1_value, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animator::GetBoolID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_GetBoolID_mD88CBA007AB7C968BF526B518E90F90E0935A9DD (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::SetBoolString(System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetBoolString_m08A0BC6717BF5FD3E43D3EFB2509E359C1196C00 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, String_t* ___0_name, bool ___1_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::SetBoolID(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetBoolID_mCDA31E47A1AA78E830D0B76394BE2FA7296E03BE (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, bool ___1_value, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Animator::GetIntegerID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_GetIntegerID_mCAC9F61639DAF52DD2DE8891DB8A2F7FE5C3DF4A (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::SetIntegerString(System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetIntegerString_m3080217346B85D69FA5A99B2ABC64BF5E4580455 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, String_t* ___0_name, int32_t ___1_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::SetIntegerID(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetIntegerID_m08431A06E5905C62BA397B9BAB30F87E3C30569F (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, int32_t ___1_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::SetTriggerString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetTriggerString_m177C75DFBE070DE66FC08A3232444CCEA409C25E (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, String_t* ___0_name, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::SetTriggerID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetTriggerID_mCC0A74BF79A56BC1EA634641C64B8E527B0B49E7 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::ResetTriggerString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_ResetTriggerString_m78259348CED35F156148A64B95EBD73CE3951868 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, String_t* ___0_name, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::ResetTriggerID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_ResetTriggerID_mD3E0C24AC862F049622D09933E7A3A2CDE256C13 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::get_deltaPosition_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_deltaPosition_Injected_mF37497B00055319EE54006C19AAEE221A99791F4 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_ret, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::get_deltaRotation_Injected(UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_deltaRotation_Injected_mFEC802815227FE4B11491F80B281425A10E19ABD (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974* ___0_ret, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::CheckIfInIKPass()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CheckIfInIKPass_mE7815990AFAD02738D0D5B4DA8DDB3E649D30CCF (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::set_bodyPositionInternal(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_bodyPositionInternal_m6042D23A6CC550D438B4522C4755BD08692D2F1A (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::set_bodyPositionInternal_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_bodyPositionInternal_Injected_m434A0C848EF277237CBAA68C4A94A1DD4A05DC75 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::set_bodyRotationInternal(UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_bodyRotationInternal_mA381F771D03290AF383D3203071D9B04746BD2E6 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::set_bodyRotationInternal_Injected(UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_bodyRotationInternal_Injected_m0BDC67195DA58582AEFC3567906106BD96C1D173 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974* ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::SetGoalPosition(UnityEngine.AvatarIKGoal,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalPosition_m0811DE827A66638ECA79A2BAA6A59D9D21D7D5A2 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_goal, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_goalPosition, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::SetGoalPosition_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalPosition_Injected_mE03B76DB578A3B15ED91437071BEF70F61985707 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_goal, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___1_goalPosition, const RuntimeMethod* method) ;
// UnityEngine.Quaternion UnityEngine.Animator::GetGoalRotation(UnityEngine.AvatarIKGoal)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 Animator_GetGoalRotation_mB7B67DE4EBA3C26D713754D1D76D4F529E783DB2 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_goal, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::GetGoalRotation_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetGoalRotation_Injected_m76092248C853479A1E6178DA4AF19F69FF8C8F75 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_goal, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974* ___1_ret, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::SetGoalRotation(UnityEngine.AvatarIKGoal,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalRotation_m1BFE2425DE75954B1233ABD96D6AB3682D42E5BA (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_goal, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___1_goalRotation, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::SetGoalRotation_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalRotation_Injected_m93587602A0C43AC9B184D30B03F751C02E6BF045 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_goal, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974* ___1_goalRotation, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::SetGoalWeightPosition(UnityEngine.AvatarIKGoal,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalWeightPosition_mBCC0ED516684541F6AD9B784ECCCA2D7C14DC75E (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_goal, float ___1_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::SetGoalWeightRotation(UnityEngine.AvatarIKGoal,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalWeightRotation_mA8A5BE4C22583CFB7C66EF59A1997E241A3001EF (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_goal, float ___1_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::SetLookAtPositionInternal(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLookAtPositionInternal_m6A20F2667C36D8363BA0F38A961BAB941E2DDC1B (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_lookAtPosition, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::SetLookAtPositionInternal_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLookAtPositionInternal_Injected_mE50AFECADA7DC76D0E73C6B7131EBBD1CED5D59D (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_lookAtPosition, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::SetLookAtWeightInternal(System.Single,System.Single,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLookAtWeightInternal_m41D66B6DA78B1ACB7EE3E3B51A29904DEB05778F (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, float ___0_weight, float ___1_bodyWeight, float ___2_headWeight, float ___3_eyesWeight, float ___4_clampWeight, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::GetAnimatorStateInfo(System.Int32,UnityEngine.StateInfoIndex,UnityEngine.AnimatorStateInfo&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetAnimatorStateInfo_mC6C046A539DE6E8D481E830D3DA1FBF96DFC367D (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_layerIndex, int32_t ___1_stateInfoIndex, AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* ___2_info, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Animator::GetAnimatorClipInfoCount(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_GetAnimatorClipInfoCount_m83C02F470FEC1DAF548AB88C578B64B6B3BB8E9B (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_layerIndex, bool ___1_current, const RuntimeMethod* method) ;
// System.Void System.ArgumentNullException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ArgumentNullException__ctor_m444AE141157E333844FC1A9500224C2F9FD24F4B (ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129* __this, String_t* ___0_paramName, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::GetAnimatorClipInfoInternal(System.Int32,System.Boolean,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetAnimatorClipInfoInternal_m98028420AD065F1B6F3DC2EB4C6C2A42B8567600 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_layerIndex, bool ___1_isCurrent, RuntimeObject* ___2_clips, const RuntimeMethod* method) ;
// System.String System.Enum::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Enum_ToString_m946B0B83C4470457D0FF555D862022C72BB55741 (RuntimeObject* __this, const RuntimeMethod* method) ;
// System.String System.String::Concat(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m9E3155FB84015C823606188F53B47CB44C444991 (String_t* ___0_str0, String_t* ___1_str1, const RuntimeMethod* method) ;
// System.Void System.IndexOutOfRangeException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void IndexOutOfRangeException__ctor_mFD06819F05B815BE2D6E826D4E04F4C449D0A425 (IndexOutOfRangeException_t7ECB35264FB6CA8FAA516BD958F4B2ADC78E8A82* __this, String_t* ___0_message, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.HumanTrait::GetBoneIndexFromMono(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t HumanTrait_GetBoneIndexFromMono_mDE16E21275A55D263014CFD3307BEB7353AE6925 (int32_t ___0_humanId, const RuntimeMethod* method) ;
// UnityEngine.Transform UnityEngine.Animator::GetBoneTransformInternal(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* Animator_GetBoneTransformInternal_m875DC36979BC9FB162D83E799421243AD3842857 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_humanBoneId, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::GetCurrentGraph(UnityEngine.Playables.PlayableGraph&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetCurrentGraph_mDDDDABBEA3E4BBD025401F92FFFE5B71DAC9486F (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animator::get_logWarnings()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_logWarnings_m39949DA4A177E2D107023FB0BD89DC3D6F303652 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animator::IsInIKPass()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_IsInIKPass_m35BF844B06D845BD0C6778F3B6E87B9C0B26BA5F (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Debug::LogWarning(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogWarning_m33EF1B897E0C7C6FF538989610BFAFFEF4628CA9 (RuntimeObject* ___0_message, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::Rebind(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_Rebind_mA8163C9B7150958C0FB3F071B7ED41850BE3A130 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, bool ___0_writeDefaultValues, const RuntimeMethod* method) ;
// System.Void UnityEngine.Motion::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Motion__ctor_mB6190858E566BFA1B80D2E94B65CD27920A49443 (Motion_tBCD49FBF5608AD21FC03B63C8182FABCEF2707AC* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.AnimationClip::Internal_CreateAnimationClip(UnityEngine.AnimationClip)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_Internal_CreateAnimationClip_m1410C35D6386CEA1F068C9314751D0F6A7D34789 (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* ___0_self, const RuntimeMethod* method) ;
// System.Array UnityEngine.AnimationClip::GetEventsInternal()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeArray* AnimationClip_GetEventsInternal_mF2E21B70DC3E96105B7F696767FEA06400EF805F (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.ScriptableObject::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ScriptableObject__ctor_mD037FDB0B487295EA47F79A4DB1BF1846C9087FF (ScriptableObject_tB3BFDB921A1B1795B38A5417D3B97A89A140436A* __this, const RuntimeMethod* method) ;
// UnityEngine.Animations.AnimationPlayableOutput UnityEngine.Animations.AnimationPlayableOutput::Create(UnityEngine.Playables.PlayableGraph,System.String,UnityEngine.Animator)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E AnimationPlayableOutput_Create_m65847A70F6C74854387814C5B1D4C281B6CCCDC4 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, String_t* ___1_name, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___2_target, const RuntimeMethod* method) ;
// System.Void UnityEngine.Playables.PlayableOutputExtensions::SetSourcePlayable<UnityEngine.Animations.AnimationPlayableOutput,UnityEngine.Playables.Playable>(U,V,System.Int32)
inline void PlayableOutputExtensions_SetSourcePlayable_TisAnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E_TisPlayable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F_m015148BFEF9CA1BBC4DE5625B47A768D4B51A543 (AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E ___0_output, Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F ___1_value, int32_t ___2_port, const RuntimeMethod* method)
{
	((  void (*) (AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E, Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F, int32_t, const RuntimeMethod*))PlayableOutputExtensions_SetSourcePlayable_TisAnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E_TisPlayable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F_m015148BFEF9CA1BBC4DE5625B47A768D4B51A543_gshared)(___0_output, ___1_value, ___2_port, method);
}
// System.Void UnityEngine.Animations.AnimationPlayableGraphExtensions::SyncUpdateAndTimeMode(UnityEngine.Playables.PlayableGraph,UnityEngine.Animator)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationPlayableGraphExtensions_SyncUpdateAndTimeMode_mBF6173908DA7C04947C405230A1D66F108E7F493 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___1_animator, const RuntimeMethod* method) ;
// System.Void UnityEngine.Playables.PlayableGraph::Play()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PlayableGraph_Play_mE2A27205C369339BB8B39B9CCBF5F5EE9B26F9A6 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* __this, const RuntimeMethod* method) ;
// UnityEngine.Playables.PlayableGraph UnityEngine.Playables.PlayableGraph::Create()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E PlayableGraph_Create_mCAFF6F9DA9B2E26ABA61692903EF3F454608A4A7 (const RuntimeMethod* method) ;
// UnityEngine.Animations.AnimationClipPlayable UnityEngine.Animations.AnimationClipPlayable::Create(UnityEngine.Playables.PlayableGraph,UnityEngine.AnimationClip)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 AnimationClipPlayable_Create_m034A4A30AC2642E675B95A0A7C3C384F533F5C1A (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* ___1_clip, const RuntimeMethod* method) ;
// System.Void UnityEngine.Playables.PlayableOutputExtensions::SetSourcePlayable<UnityEngine.Animations.AnimationPlayableOutput,UnityEngine.Animations.AnimationClipPlayable>(U,V)
inline void PlayableOutputExtensions_SetSourcePlayable_TisAnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E_TisAnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969_m389C7055BB3E25FF8CC06AF5A9F6EE1BE821B43D (AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E ___0_output, AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 ___1_value, const RuntimeMethod* method)
{
	((  void (*) (AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E, AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969, const RuntimeMethod*))PlayableOutputExtensions_SetSourcePlayable_TisAnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E_TisAnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969_m389C7055BB3E25FF8CC06AF5A9F6EE1BE821B43D_gshared)(___0_output, ___1_value, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationRemoveScalePlayable::CreateHandle(UnityEngine.Playables.PlayableGraph,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationRemoveScalePlayable_CreateHandle_mE15186AF821904AC09E8F0DC30096BF63A812D66 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, int32_t ___1_inputCount, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationRemoveScalePlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationRemoveScalePlayable__ctor_m4D6C7C4AB8E078050B0CC34C6732051CF043CFA2 (AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method) ;
// UnityEngine.Playables.PlayableHandle UnityEngine.Playables.PlayableHandle::get_Null()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975 (const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationRemoveScalePlayable::CreateHandleInternal(UnityEngine.Playables.PlayableGraph,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationRemoveScalePlayable_CreateHandleInternal_mDB6C3A766BA756328A459D4EBB356A8F8E289FD1 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___1_handle, const RuntimeMethod* method) ;
// System.Void UnityEngine.Playables.PlayableHandle::SetInputCount(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PlayableHandle_SetInputCount_m6067CD3616C428F777903FCBFD789060A2185DEE (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* __this, int32_t ___0_value, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableHandle::IsValid()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_IsValid_m07631D12846BAAF2CC302E69A28A44BFE9EB5098 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationRemoveScalePlayable>()
inline bool PlayableHandle_IsPlayableOfType_TisAnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD_m961964786905D9B20B750AC27CB64EA48C4C5971 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, const RuntimeMethod*))PlayableHandle_IsPlayableOfType_TisAnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD_m961964786905D9B20B750AC27CB64EA48C4C5971_gshared)(__this, method);
}
// System.Void System.InvalidCastException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InvalidCastException__ctor_mED3F9781E6CA47A92C602C896EDDF2F40ECB8644 (InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E* __this, String_t* ___0_message, const RuntimeMethod* method) ;
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationRemoveScalePlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationRemoveScalePlayable_GetHandle_mFFA58B879F31327187A20ED30E1C814B7BEAA9C6 (AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Playables.Playable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Playable__ctor_mD2EB35E024816AEED68795D0124EAB30E05BF6C4 (Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method) ;
// System.Boolean System.ValueType::Equals(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ValueType_Equals_mCA5344597A8055EC544855AD60A983B10E0EE67D (RuntimeObject* __this, RuntimeObject* ___0_obj, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationRemoveScalePlayable::Equals(UnityEngine.Animations.AnimationRemoveScalePlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationRemoveScalePlayable_Equals_m0ACDD59B80103591DA8E84CB387FB10778D8C327 (AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD* __this, AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD ___0_other, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationRemoveScalePlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationRemoveScalePlayable_CreateHandleInternal_Injected_m0ED3A968526682B946A2D157855A91B93CDE9A13 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___1_handle, const RuntimeMethod* method) ;
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimatorControllerPlayable::CreateHandle(UnityEngine.Playables.PlayableGraph,UnityEngine.RuntimeAnimatorController)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimatorControllerPlayable_CreateHandle_mEC5A01894B274C6EC5AD8FBD84688C29AFBCF698 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, RuntimeAnimatorController_t6F7C753402B42EC23C163099CF935C5E0D7A7254* ___1_controller, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable__ctor_mBCB9475E2740BE1AEB94C08BAD14D51333258BFE (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::CreateHandleInternal(UnityEngine.Playables.PlayableGraph,UnityEngine.RuntimeAnimatorController,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_CreateHandleInternal_mF52B5F176A31C938DF5909127B27B1E78E3863D4 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, RuntimeAnimatorController_t6F7C753402B42EC23C163099CF935C5E0D7A7254* ___1_controller, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___2_handle, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetHandle(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetHandle_mD86A3C0D03453FAF21903F7A52A743AB2DA6DED4 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method) ;
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimatorControllerPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimatorControllerPlayable_GetHandle_m718D9A4E0DB7AC62947B1D09E47DBCD25C27AF6C (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, const RuntimeMethod* method) ;
// System.Void System.InvalidOperationException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InvalidOperationException__ctor_mE4CB6F4712AB6D99A2358FBAE2E052B3EE976162 (InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB* __this, String_t* ___0_message, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimatorControllerPlayable>()
inline bool PlayableHandle_IsPlayableOfType_TisAnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_m83ED61FDEBC627830082467B83BF64724C68CD70 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, const RuntimeMethod*))PlayableHandle_IsPlayableOfType_TisAnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_m83ED61FDEBC627830082467B83BF64724C68CD70_gshared)(__this, method);
}
// System.Boolean UnityEngine.Playables.PlayableHandle::op_Equality(UnityEngine.Playables.PlayableHandle,UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_op_Equality_m0E6C48A28F75A870AC22ADE3BD42F7F70A43C99C (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_x, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___1_y, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::Equals(UnityEngine.Animations.AnimatorControllerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_Equals_m14125BB4CCFCDFFD098223AF20E38501BA264180 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A ___0_other, const RuntimeMethod* method) ;
// System.Single UnityEngine.Animations.AnimatorControllerPlayable::GetFloatString(UnityEngine.Playables.PlayableHandle&,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorControllerPlayable_GetFloatString_m1DADE177E526468221C892871355B7E0371DC7B5 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, String_t* ___1_name, const RuntimeMethod* method) ;
// System.Single UnityEngine.Animations.AnimatorControllerPlayable::GetFloat(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorControllerPlayable_GetFloat_m787538C1B2ED9C4E52E8A3EEF43405913E82E895 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_name, const RuntimeMethod* method) ;
// System.Single UnityEngine.Animations.AnimatorControllerPlayable::GetFloatID(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorControllerPlayable_GetFloatID_m4EDF8B5F43B2F67DDCF3A566C520E99AF92316E0 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_id, const RuntimeMethod* method) ;
// System.Single UnityEngine.Animations.AnimatorControllerPlayable::GetFloat(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorControllerPlayable_GetFloat_mDBD6169B671FCD0AA3551368A3EE37334E7D7B49 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_id, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetFloatString(UnityEngine.Playables.PlayableHandle&,System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetFloatString_m0F0870A5299A2CF4AFC6C65832D189A5D04D4FD5 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, String_t* ___1_name, float ___2_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetFloat(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetFloat_m95BF662BF3AA8A4F4B5F868801DED66D397E2407 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_name, float ___1_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetFloatID(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetFloatID_m3BA4ADD5B318BFF0294EB9ACA58480A66168297A (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_id, float ___2_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetFloat(System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetFloat_mEDD694D72DDBEDF381973F41D83037F330224EDC (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_id, float ___1_value, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::GetBoolString(UnityEngine.Playables.PlayableHandle&,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_GetBoolString_mECF14FDF6E8B96688869FD00C1CC5F91C54EAB16 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, String_t* ___1_name, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::GetBool(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_GetBool_m30C0C093BA04B2C680E5B8510A189A66A4D5333D (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_name, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::GetBoolID(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_GetBoolID_m7061D395F3200F2128DC6320515789ECB1350D4F (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_id, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::GetBool(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_GetBool_m72BB4B2A95A2C229ADE9B51F7232B8FF4E5DF26E (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_id, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetBoolString(UnityEngine.Playables.PlayableHandle&,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetBoolString_m25BA69DB53D2B741C3A3816F52F2D8B8DB94A563 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, String_t* ___1_name, bool ___2_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetBool(System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetBool_mDBBE0C1A970D71F600234B15D0E6B9C51E7A70DC (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_name, bool ___1_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetBoolID(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetBoolID_m9D7D23783C516EBA887139E4F3C2089D4F6630C9 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_id, bool ___2_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetBool(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetBool_mEBE969EAB2935C3A15848521B06ABB45B1188BAD (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_id, bool ___1_value, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetIntegerString(UnityEngine.Playables.PlayableHandle&,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetIntegerString_mD0C70C8553191AD4B4367CA0C1C7892097157713 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, String_t* ___1_name, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetInteger(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetInteger_mFE3ADA2A4AD9A7A62B60D7E5F2FCBCF9A5F58AA0 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_name, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetIntegerID(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetIntegerID_m364BCCFECB516503043592BCE6093B6E71573901 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_id, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetInteger(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetInteger_m50B3042FDC1F87A4E0423FCCFEED611996A3860D (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_id, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetIntegerString(UnityEngine.Playables.PlayableHandle&,System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetIntegerString_mDC746DB1E487E0A5FB8258FB1FB697D3FEB14579 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, String_t* ___1_name, int32_t ___2_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetInteger(System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetInteger_m4C8B5F237C20CFABF0CAD460F55782D834444A91 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_name, int32_t ___1_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetIntegerID(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetIntegerID_m683204581C2F1791D94A53D8E9E81C8C4AA25860 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_id, int32_t ___2_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetInteger(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetInteger_m6FA135B1C91BED0F97C9E623FB8C37411C6F15B4 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_id, int32_t ___1_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetTriggerString(UnityEngine.Playables.PlayableHandle&,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetTriggerString_m0EC136890F3D7FC3CCE31D7D97406AEC14BA96A2 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, String_t* ___1_name, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetTrigger(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetTrigger_m06D7662315ED85A8472E62C2F369B1167BAF51A7 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_name, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetTriggerID(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetTriggerID_mB0D1B0D7CFAEA440E8582C322215E5F8843BBFF3 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_id, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetTrigger(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetTrigger_mA2F8F838D48244468DACBF503E120FF3B06E95B2 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_id, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::ResetTriggerString(UnityEngine.Playables.PlayableHandle&,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_ResetTriggerString_mC531FDD220C61491E53D609F021DE45AB0A517E8 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, String_t* ___1_name, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::ResetTrigger(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_ResetTrigger_mD671335B03DF16D311287002303191D50B802D14 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_name, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::ResetTriggerID(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_ResetTriggerID_m4FB3CD3245F90046AEBEB7DAC46F4ED8A17C2E70 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_id, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::ResetTrigger(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_ResetTrigger_mABE88FFA8781EB19F5B06F7BF483F13C61107D6C (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_id, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::IsParameterControlledByCurveString(UnityEngine.Playables.PlayableHandle&,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_IsParameterControlledByCurveString_m9E408D31C0E277E3B81355622EA263D0A889FFBB (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, String_t* ___1_name, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::IsParameterControlledByCurve(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_IsParameterControlledByCurve_m34F8D191A09BC28CCDF1A044FD02B33A1D64D0B1 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_name, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::IsParameterControlledByCurveID(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_IsParameterControlledByCurveID_m485E73DF5945A41CBD21A8F9ABDFBE9CDD0C07E6 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_id, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::IsParameterControlledByCurve(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_IsParameterControlledByCurve_m8ADD7EE7A489424B4B99253C96647E67B04E2D1B (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_id, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetLayerCountInternal(UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetLayerCountInternal_m1E9E07012C508DF0D452D350F658AB897B2C7C76 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetLayerCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetLayerCount_m3941A7DA375B26988A59DA13A22C08476D59D34F (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, const RuntimeMethod* method) ;
// System.String UnityEngine.Animations.AnimatorControllerPlayable::GetLayerNameInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AnimatorControllerPlayable_GetLayerNameInternal_m29B1F15DB851564CA5D4D505F71636FBCAD787B9 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, const RuntimeMethod* method) ;
// System.String UnityEngine.Animations.AnimatorControllerPlayable::GetLayerName(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AnimatorControllerPlayable_GetLayerName_m33BDF74B10C6BFDB82FF404E288F52F1EBABC809 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetLayerIndexInternal(UnityEngine.Playables.PlayableHandle&,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetLayerIndexInternal_mF8B5003325DC63AA1E35959BBC77F54BA5FB69B6 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, String_t* ___1_layerName, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetLayerIndex(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetLayerIndex_m48AB42D7F82BE03576D4AC480F048EEDF01B0A0D (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_layerName, const RuntimeMethod* method) ;
// System.Single UnityEngine.Animations.AnimatorControllerPlayable::GetLayerWeightInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorControllerPlayable_GetLayerWeightInternal_m35F8593E7F54FF389010F2C2C202662F78A4D076 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, const RuntimeMethod* method) ;
// System.Single UnityEngine.Animations.AnimatorControllerPlayable::GetLayerWeight(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorControllerPlayable_GetLayerWeight_m09D5E7AB77824DE2DE20E4E4491BF2A90E3B28BB (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetLayerWeightInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetLayerWeightInternal_m35738E7223F0B22A86DAA2BF2066132E25FD1B8B (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, float ___2_weight, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetLayerWeight(System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetLayerWeight_mE432DA7CC2FC4425D0DA064B71B5ACCEB83F8EE3 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, float ___1_weight, const RuntimeMethod* method) ;
// UnityEngine.AnimatorStateInfo UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorStateInfoInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 AnimatorControllerPlayable_GetCurrentAnimatorStateInfoInternal_m9EBFBAF82969F46703B6F9C15F42C29CB963063E (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, const RuntimeMethod* method) ;
// UnityEngine.AnimatorStateInfo UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorStateInfo(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 AnimatorControllerPlayable_GetCurrentAnimatorStateInfo_mBA937DD74A4964C743880FFE7CFFE67B18D8264B (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) ;
// UnityEngine.AnimatorStateInfo UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorStateInfoInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 AnimatorControllerPlayable_GetNextAnimatorStateInfoInternal_m6573FAB9FB964669D28460771FACBADFC300FC3E (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, const RuntimeMethod* method) ;
// UnityEngine.AnimatorStateInfo UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorStateInfo(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 AnimatorControllerPlayable_GetNextAnimatorStateInfo_m1BD26B635F70840C13BC34D0632D82B5EA48CDE0 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) ;
// UnityEngine.AnimatorTransitionInfo UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorTransitionInfoInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD AnimatorControllerPlayable_GetAnimatorTransitionInfoInternal_m02EDD789D0AF671B56CC16D7172FDE8193A1C469 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, const RuntimeMethod* method) ;
// UnityEngine.AnimatorTransitionInfo UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorTransitionInfo(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD AnimatorControllerPlayable_GetAnimatorTransitionInfo_m5157FED95B567D4441228BC0F3AF31563FD5BF1C (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) ;
// UnityEngine.AnimatorClipInfo[] UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorClipInfoInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* AnimatorControllerPlayable_GetCurrentAnimatorClipInfoInternal_mACAEC7A2BCB3EE6DCE40A1608DA3F466E4A9BEEF (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, const RuntimeMethod* method) ;
// UnityEngine.AnimatorClipInfo[] UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorClipInfo(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* AnimatorControllerPlayable_GetCurrentAnimatorClipInfo_mF89B409BFDD2B021BB6862B93A68879BCAB60076 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorClipInfoInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Boolean,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_GetAnimatorClipInfoInternal_m18301A84A3ACAE2F7A34B0966564CD4F65D2BB2F (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, bool ___2_isCurrent, RuntimeObject* ___3_clips, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorClipInfo(System.Int32,System.Collections.Generic.List`1<UnityEngine.AnimatorClipInfo>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_GetCurrentAnimatorClipInfo_mB103A1F9EC5E23947C8A1802D644FC4D22093F14 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331* ___1_clips, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorClipInfo(System.Int32,System.Collections.Generic.List`1<UnityEngine.AnimatorClipInfo>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_GetNextAnimatorClipInfo_mF00B978E844FF7E6DF0AF670C0CF2022A8DD2517 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331* ___1_clips, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorClipInfoCountInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetAnimatorClipInfoCountInternal_m30ACC99D56EF6C81325F21B16538A70689A4F712 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, bool ___2_current, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorClipInfoCount(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetCurrentAnimatorClipInfoCount_mB80BDB04DF276D53D45EAA549CAD88DA9A7E8BE8 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorClipInfoCount(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetNextAnimatorClipInfoCount_m19CD5C12E89C22E3521175CD6C1E2F033C53D070 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) ;
// UnityEngine.AnimatorClipInfo[] UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorClipInfoInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* AnimatorControllerPlayable_GetNextAnimatorClipInfoInternal_m9FE0E9288A890CDF52C9F825C619188BBFEB7F6C (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, const RuntimeMethod* method) ;
// UnityEngine.AnimatorClipInfo[] UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorClipInfo(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* AnimatorControllerPlayable_GetNextAnimatorClipInfo_mD247136758432A4036FC338D4C8E67ECAF5EDD26 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::IsInTransitionInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_IsInTransitionInternal_m0DA12D5A39272162175FC51E47458871BB8B4E42 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::IsInTransition(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_IsInTransition_m041E31E9DAD976867BCCBDDD27CB556F590D61D9 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetParameterCountInternal(UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetParameterCountInternal_m382C6BFCEE151B9DF3DFE232B287D6C6D522DD8D (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetParameterCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetParameterCount_m899EE6DAD7209174D7568E632DA986D39E435A70 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, const RuntimeMethod* method) ;
// UnityEngine.AnimatorControllerParameter[] UnityEngine.Animations.AnimatorControllerPlayable::GetParametersArrayInternal(UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorControllerParameterU5BU5D_tAB05125F5DC0D98F59351CD7D8C9880DFFA8EA21* AnimatorControllerPlayable_GetParametersArrayInternal_mFB9F6ACE0FD4B8FBA8C5641195B71EEC242F99E5 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, const RuntimeMethod* method) ;
// UnityEngine.AnimatorControllerParameter UnityEngine.Animations.AnimatorControllerPlayable::GetParameter(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* AnimatorControllerPlayable_GetParameter_mB7ECCC4E41138CC7D9A28ABF499679B8792E9CC3 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_index, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::StringToHash(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_StringToHash_m75E3FCE65BF77734C4781FADFFC9568B0EE483E2 (String_t* ___0_name, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::CrossFadeInFixedTimeInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Single,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_CrossFadeInFixedTimeInternal_m2F3C0BAE59468B079106B730F8F0EE9874928561 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_stateNameHash, float ___2_transitionDuration, int32_t ___3_layer, float ___4_fixedTime, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::CrossFadeInFixedTime(System.String,System.Single,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_CrossFadeInFixedTime_m43166ED8F80B94469DFA25374911A64637438674 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_stateName, float ___1_transitionDuration, int32_t ___2_layer, float ___3_fixedTime, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::CrossFadeInFixedTime(System.Int32,System.Single,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_CrossFadeInFixedTime_m93EC21F858FE76184FA91D2B6EA3B361A2929503 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_stateNameHash, float ___1_transitionDuration, int32_t ___2_layer, float ___3_fixedTime, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::CrossFadeInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Single,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_CrossFadeInternal_m4861EAD661B4EA490CDAF4413F8D6E1F1EF6F6D2 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_stateNameHash, float ___2_transitionDuration, int32_t ___3_layer, float ___4_normalizedTime, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::CrossFade(System.String,System.Single,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_CrossFade_m8AD5C075E4B4B645796A36980AE15378167019AA (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_stateName, float ___1_transitionDuration, int32_t ___2_layer, float ___3_normalizedTime, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::CrossFade(System.Int32,System.Single,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_CrossFade_m0C777C0385BE3E8AA8D86C99897D490ED553F9DD (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_stateNameHash, float ___1_transitionDuration, int32_t ___2_layer, float ___3_normalizedTime, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::PlayInFixedTimeInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_PlayInFixedTimeInternal_mC0683AD548C14DA24F82388F68150F174275E376 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_stateNameHash, int32_t ___2_layer, float ___3_fixedTime, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::PlayInFixedTime(System.String,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_PlayInFixedTime_mE4DAC931BFEDBCAABE0D410BE3DF85C5C4FF1425 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_stateName, int32_t ___1_layer, float ___2_fixedTime, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::PlayInFixedTime(System.Int32,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_PlayInFixedTime_m513E1A9D864FCC8DF9E16A9DE05465A5694ACE2B (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_stateNameHash, int32_t ___1_layer, float ___2_fixedTime, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::PlayInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_PlayInternal_mD5A3AAC8CFE034C5D8FA9CC26AC9CAA364145524 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_stateNameHash, int32_t ___2_layer, float ___3_normalizedTime, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::Play(System.String,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_Play_m703A612D5040F4F99C17D300E5BD57ABB992E976 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_stateName, int32_t ___1_layer, float ___2_normalizedTime, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::Play(System.Int32,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_Play_mB14FF22BE5BF41EB807BD3F14C111A3D60E59394 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_stateNameHash, int32_t ___1_layer, float ___2_normalizedTime, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::HasStateInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_HasStateInternal_m1D49854E9E6AFAC2DFE979DFF6911B6946B5555A (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, int32_t ___2_stateID, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::HasState(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_HasState_mE537ED9F84D34939019463D4A2F6171B053759C2 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, int32_t ___1_stateID, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.RuntimeAnimatorController,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_CreateHandleInternal_Injected_mCBD001EF18F0143DD0568A9D5FBAF157206ED21D (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, RuntimeAnimatorController_t6F7C753402B42EC23C163099CF935C5E0D7A7254* ___1_controller, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___2_handle, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorStateInfoInternal_Injected(UnityEngine.Playables.PlayableHandle&,System.Int32,UnityEngine.AnimatorStateInfo&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_GetCurrentAnimatorStateInfoInternal_Injected_m7B608D6B42D37184F7C778E9DEBCD77B350923AD (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* ___2_ret, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorStateInfoInternal_Injected(UnityEngine.Playables.PlayableHandle&,System.Int32,UnityEngine.AnimatorStateInfo&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_GetNextAnimatorStateInfoInternal_Injected_m6939850E0366960A04B5B3009220B1AAC6F77D0F (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* ___2_ret, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorTransitionInfoInternal_Injected(UnityEngine.Playables.PlayableHandle&,System.Int32,UnityEngine.AnimatorTransitionInfo&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_GetAnimatorTransitionInfoInternal_Injected_m6CFF884FDBEF401BA13CAA1F9FA68EFC56B62870 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD* ___2_ret, const RuntimeMethod* method) ;
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationOffsetPlayable::CreateHandle(UnityEngine.Playables.PlayableGraph,UnityEngine.Vector3,UnityEngine.Quaternion,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationOffsetPlayable_CreateHandle_m27C7AEF0B9D954591B9FB7A9EF4C92CE96037518 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_position, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___2_rotation, int32_t ___3_inputCount, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationOffsetPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationOffsetPlayable__ctor_mBF3AC6493556DAAEF608B359BEBE8FA6D9F8DBFD (AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationOffsetPlayable::CreateHandleInternal(UnityEngine.Playables.PlayableGraph,UnityEngine.Vector3,UnityEngine.Quaternion,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationOffsetPlayable_CreateHandleInternal_m877AC3B2ED395B0C0A7FC1E2C9E44BC7A776BABF (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_position, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___2_rotation, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___3_handle, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationOffsetPlayable>()
inline bool PlayableHandle_IsPlayableOfType_TisAnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4_mB35755A4D179F4DA51A96FCB3C4A8DF105C2BB12 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, const RuntimeMethod*))PlayableHandle_IsPlayableOfType_TisAnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4_mB35755A4D179F4DA51A96FCB3C4A8DF105C2BB12_gshared)(__this, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationOffsetPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationOffsetPlayable_GetHandle_m769BEFF90379AEAB0C579F7800953458CE3EBA78 (AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationOffsetPlayable::Equals(UnityEngine.Animations.AnimationOffsetPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationOffsetPlayable_Equals_mEC28392ADD4E9639EB9228D106D93E21B3587270 (AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4* __this, AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4 ___0_other, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationOffsetPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationOffsetPlayable_CreateHandleInternal_Injected_m39A68EF379AFC09A9E070474CA3E19859FB41F85 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___1_position, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974* ___2_rotation, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___3_handle, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalSyncUpdateAndTimeMode(UnityEngine.Playables.PlayableGraph&,UnityEngine.Animator)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationPlayableGraphExtensions_InternalSyncUpdateAndTimeMode_m7C6C30F3FC2930979C825953394E8C9F6D35E3F3 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___1_animator, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.LookAtConstraint::SetSourcesInternal(UnityEngine.Animations.LookAtConstraint,System.Collections.Generic.List`1<UnityEngine.Animations.ConstraintSource>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LookAtConstraint_SetSourcesInternal_mDDF9B75472D8E0EAD24D3AD670A8A585D304D29A (LookAtConstraint_t2B4569F15EA2736FAC97AD3DE35B093AE8B5D919* ___0_self, List_1_tF88FB42B55EA7DB2BFC546CB9573DFF2D6F0AECE* ___1_sources, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationScriptPlayable>()
inline bool PlayableHandle_IsPlayableOfType_TisAnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127_m4F637AD893630043482383791FA7A0285EB16F6E (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, const RuntimeMethod*))PlayableHandle_IsPlayableOfType_TisAnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127_m4F637AD893630043482383791FA7A0285EB16F6E_gshared)(__this, method);
}
// System.Void UnityEngine.Animations.AnimationScriptPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationScriptPlayable__ctor_m6DEFD72735E79009FC1484AA2A7A82E6CE601247 (AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method) ;
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationScriptPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationScriptPlayable_GetHandle_m30355B6EE1AA3BA36D628251FB4291386D223646 (AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127* __this, const RuntimeMethod* method) ;
// UnityEngine.Playables.PlayableHandle UnityEngine.Playables.Playable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 Playable_GetHandle_m39356D23E849DC5428B262092657662C064E04F8 (Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationScriptPlayable::Equals(UnityEngine.Animations.AnimationScriptPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationScriptPlayable_Equals_mAD02E40704CBE4AB188DE0569052F8EA9864F4E4 (AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127* __this, AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127 ___0_other, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationScriptPlayable::SetProcessInputsInternal(UnityEngine.Playables.PlayableHandle,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationScriptPlayable_SetProcessInputsInternal_m2ACAC5C02655BBBF15A32B06F5CF1BAFC0775D9A (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, bool ___1_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationScriptPlayable::SetProcessInputs(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationScriptPlayable_SetProcessInputs_mF7DE3561731A6513E8FE0F0A85B0C38959621839 (AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127* __this, bool ___0_value, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationScriptPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Playables.PlayableHandle&,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationScriptPlayable_CreateHandleInternal_Injected_m6DD2A68DB5A0F7A25529B1899FB308F248C557E3 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___1_handle, intptr_t ___2_jobReflectionData, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationScriptPlayable::SetProcessInputsInternal_Injected(UnityEngine.Playables.PlayableHandle&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationScriptPlayable_SetProcessInputsInternal_Injected_mD82651E462942B43F51D5C4456ABD600F159FD15 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, bool ___1_value, const RuntimeMethod* method) ;
// UnityEngine.Animations.AnimationLayerMixerPlayable UnityEngine.Animations.AnimationLayerMixerPlayable::Create(UnityEngine.Playables.PlayableGraph,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D AnimationLayerMixerPlayable_Create_mB080375BE13D2A1159D6AD4AB45FB10C36E389FF (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, int32_t ___1_inputCount, bool ___2_singleLayerOptimization, const RuntimeMethod* method) ;
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationLayerMixerPlayable::CreateHandle(UnityEngine.Playables.PlayableGraph,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationLayerMixerPlayable_CreateHandle_m74B2930D89DABE9160B08D8C92D6EA6622D88A1D (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, int32_t ___1_inputCount, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationLayerMixerPlayable::.ctor(UnityEngine.Playables.PlayableHandle,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationLayerMixerPlayable__ctor_m28884B8B9F7E057DF947E3B43ED78EA107368BD6 (AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, bool ___1_singleLayerOptimization, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationLayerMixerPlayable::CreateHandleInternal(UnityEngine.Playables.PlayableGraph,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationLayerMixerPlayable_CreateHandleInternal_mEEEEBA10E6AD409C8CAF16BDF7F0E89E47A91FC8 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___1_handle, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationLayerMixerPlayable>()
inline bool PlayableHandle_IsPlayableOfType_TisAnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_m23764EE36FE7A81A245C7146FF1E9DF6530DA321 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, const RuntimeMethod*))PlayableHandle_IsPlayableOfType_TisAnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_m23764EE36FE7A81A245C7146FF1E9DF6530DA321_gshared)(__this, method);
}
// System.Void UnityEngine.Animations.AnimationLayerMixerPlayable::SetSingleLayerOptimizationInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationLayerMixerPlayable_SetSingleLayerOptimizationInternal_mF1EC1B461F2CCB8D7E01799875DDB5FC8FE4BBDB (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, bool ___1_value, const RuntimeMethod* method) ;
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationLayerMixerPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationLayerMixerPlayable_GetHandle_m324A98D0B0BFC0441377D65CAE93C914F828721F (AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationLayerMixerPlayable::Equals(UnityEngine.Animations.AnimationLayerMixerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationLayerMixerPlayable_Equals_mA5D24E61E2DE1140B409F3B569DBA3C185751970 (AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D* __this, AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D ___0_other, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Playables.PlayableHandle::GetInputCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t PlayableHandle_GetInputCount_m7FE60883E4B7C9AF7D39F28A044924ADBD5E5121 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* __this, const RuntimeMethod* method) ;
// System.String System.String::Format(System.String,System.Object,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987 (String_t* ___0_format, RuntimeObject* ___1_arg0, RuntimeObject* ___2_arg1, const RuntimeMethod* method) ;
// System.Void System.ArgumentOutOfRangeException::.ctor(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ArgumentOutOfRangeException__ctor_mE5B2755F0BEA043CACF915D5CE140859EE58FA66 (ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F* __this, String_t* ___0_paramName, String_t* ___1_message, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationLayerMixerPlayable::IsLayerAdditiveInternal(UnityEngine.Playables.PlayableHandle&,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationLayerMixerPlayable_IsLayerAdditiveInternal_m576416565697C3E26266D7577C4AB03041B975AE (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, uint32_t ___1_layerIndex, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationLayerMixerPlayable::IsLayerAdditive(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationLayerMixerPlayable_IsLayerAdditive_m379268A18CFAD74371F6D4E0467072761BF84713 (AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D* __this, uint32_t ___0_layerIndex, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationLayerMixerPlayable::SetLayerAdditiveInternal(UnityEngine.Playables.PlayableHandle&,System.UInt32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationLayerMixerPlayable_SetLayerAdditiveInternal_m0B39FA66BEF309D1E1FDBAA4CF1E20DA7338ADCF (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, uint32_t ___1_layerIndex, bool ___2_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationLayerMixerPlayable::SetLayerAdditive(System.UInt32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationLayerMixerPlayable_SetLayerAdditive_m3B35E03C224B118E3F3D9E8A7B697AF570FBFB6E (AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D* __this, uint32_t ___0_layerIndex, bool ___1_value, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Object::op_Equality(UnityEngine.Object,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___0_x, Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___1_y, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationLayerMixerPlayable::SetLayerMaskFromAvatarMaskInternal(UnityEngine.Playables.PlayableHandle&,System.UInt32,UnityEngine.AvatarMask)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationLayerMixerPlayable_SetLayerMaskFromAvatarMaskInternal_mDA82665D20D53C1638037283DDCFE7BB2B2DD035 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, uint32_t ___1_layerIndex, AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF* ___2_mask, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationLayerMixerPlayable::SetLayerMaskFromAvatarMask(System.UInt32,UnityEngine.AvatarMask)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationLayerMixerPlayable_SetLayerMaskFromAvatarMask_mC4BDE2B476AC13C31053100085FAF6BC86000280 (AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D* __this, uint32_t ___0_layerIndex, AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF* ___1_mask, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationLayerMixerPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationLayerMixerPlayable_CreateHandleInternal_Injected_m052C3DAAC09B1BADE847FB348E0FFFB228B17C26 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___1_handle, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationStream::get_isValid()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationStream_get_isValid_mE1F032BDA653D5A903DCD427F4677A6C9C4C227A (AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.TransformStreamHandle::get_createdByNative()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransformStreamHandle_get_createdByNative_mCC27504004588C367456D55E8295B745BE2431AC (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.TransformStreamHandle::get_hasHandleIndex()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransformStreamHandle_get_hasHandleIndex_m164F6D37B1A6B74214B09E1E6798C275C71716D1 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.TransformStreamHandle::IsValidInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransformStreamHandle_IsValidInternal_mBF1602E33ABCA25121C7CF70173D29C5291354CC (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) ;
// System.UInt32 UnityEngine.Animations.TransformStreamHandle::get_animatorBindingsVersion()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t TransformStreamHandle_get_animatorBindingsVersion_mD044F88843A162A554BA7EF191E52B58F9F0AFF8 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, const RuntimeMethod* method) ;
// System.UInt32 UnityEngine.Animations.AnimationStream::get_animatorBindingsVersion()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t AnimationStream_get_animatorBindingsVersion_mD7D19DCE96F93CE4DC36457F974C5B8562A3B5E4 (AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.TransformStreamHandle::IsSameVersionAsStream(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransformStreamHandle_IsSameVersionAsStream_m31E41B516413440AC8F4D5F9F233623A6DE71365 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.TransformStreamHandle::get_hasSkeletonIndex()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransformStreamHandle_get_hasSkeletonIndex_m8B9589FACB6810B0EFD84033D30057ADFBC4B75F (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.TransformStreamHandle::IsResolvedInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransformStreamHandle_IsResolvedInternal_m83781A03679DF4C678FE963CF21F5A2203471585 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationStream::CheckIsValid()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationStream_CheckIsValid_m6C46800E1A5A4BE27FF761A93F72BC3CD751174C (AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.TransformStreamHandle::ResolveInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_ResolveInternal_m0008C8228981E9247DA8B0C7739DD1BF1C70EAEA (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.TransformStreamHandle::CheckIsValidAndResolve(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_CheckIsValidAndResolve_m7602706A5D46D99268DB6C698A6752C96A0525F6 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Animations.TransformStreamHandle::GetPositionInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 TransformStreamHandle_GetPositionInternal_m4D0EA1C47F1AAB4723411247DBA15135BA6A9D4C (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Animations.TransformStreamHandle::GetPosition(UnityEngine.Animations.AnimationStream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 TransformStreamHandle_GetPosition_m8980B6C6185653E9B962625D030C3BB1994C8B89 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, const RuntimeMethod* method) ;
// UnityEngine.Quaternion UnityEngine.Animations.TransformStreamHandle::GetRotationInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 TransformStreamHandle_GetRotationInternal_m53A7E32CE6B63F588F44CAE8FCBF23C32E8393C7 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) ;
// UnityEngine.Quaternion UnityEngine.Animations.TransformStreamHandle::GetRotation(UnityEngine.Animations.AnimationStream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 TransformStreamHandle_GetRotation_m02E0CE9B403FB4138605190A48A19767D6B0C42A (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.TransformStreamHandle::SetRotationInternal(UnityEngine.Animations.AnimationStream&,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_SetRotationInternal_mE7AB735A2303DC923A69B19537FDE60B5F39CE5A (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___1_rotation, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.TransformStreamHandle::SetRotation(UnityEngine.Animations.AnimationStream,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_SetRotation_mA159153895AFFB08B30B8287304A720215C364D1 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___1_rotation, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.TransformStreamHandle::SetLocalRotationInternal(UnityEngine.Animations.AnimationStream&,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_SetLocalRotationInternal_mDE8F5BF1C73A90573EF3918F1C88ABB73BC10778 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___1_rotation, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.TransformStreamHandle::SetLocalRotation(UnityEngine.Animations.AnimationStream,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_SetLocalRotation_m68B0586FA34978971ECDC909A44E1E0C13443C6A (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___1_rotation, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.TransformStreamHandle::ResolveInternal_Injected(UnityEngine.Animations.TransformStreamHandle&,UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_ResolveInternal_Injected_m3C2F5E0470031F9C0D33DD5C7C392F8B671B9CED (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.TransformStreamHandle::GetPositionInternal_Injected(UnityEngine.Animations.TransformStreamHandle&,UnityEngine.Animations.AnimationStream&,UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_GetPositionInternal_Injected_m3C3917F08A68CD4E24653CB78AEEA3577E043462 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___2_ret, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.TransformStreamHandle::GetRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle&,UnityEngine.Animations.AnimationStream&,UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_GetRotationInternal_Injected_m4863F14E289B9627C1ACADB750B56CD81ED6F857 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974* ___2_ret, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.TransformStreamHandle::SetRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle&,UnityEngine.Animations.AnimationStream&,UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_SetRotationInternal_Injected_m181A24DB2A658E488E3F0BC684A424547A6A7683 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974* ___2_rotation, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.TransformStreamHandle::SetLocalRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle&,UnityEngine.Animations.AnimationStream&,UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_SetLocalRotationInternal_Injected_m58D671FC665AF45BE7B6753A65C3F27BDCD89EA3 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974* ___2_rotation, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.PropertyStreamHandle::get_createdByNative()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PropertyStreamHandle_get_createdByNative_m2610F75D942E639F8D9919D9A8A8E2210503292A (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.PropertyStreamHandle::get_hasHandleIndex()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PropertyStreamHandle_get_hasHandleIndex_m296B641953CA1478332DE8D4E3616EDDE67F4415 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.PropertyStreamHandle::get_hasBindType()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PropertyStreamHandle_get_hasBindType_mF482FD67DC2BBB8AF20A959C846430577FCC51B3 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.PropertyStreamHandle::IsValidInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PropertyStreamHandle_IsValidInternal_mFE619567B465984FC8E00F07CC24D489802BB51B (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) ;
// System.UInt32 UnityEngine.Animations.PropertyStreamHandle::get_animatorBindingsVersion()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t PropertyStreamHandle_get_animatorBindingsVersion_mAF352761E16C2BC5658A2B37C77EFC88173EA4C0 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.PropertyStreamHandle::IsSameVersionAsStream(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PropertyStreamHandle_IsSameVersionAsStream_m105BA0425054D86214E70C3D0746517A0BBD5305 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.PropertyStreamHandle::get_hasValueArrayIndex()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PropertyStreamHandle_get_hasValueArrayIndex_m6BFF272278DB968E4732EE7BAA990F18258DC610 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.PropertyStreamHandle::IsResolvedInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PropertyStreamHandle_IsResolvedInternal_m7B96232330AB117B2050D16FE135103D6ED97DFA (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.PropertyStreamHandle::ResolveInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PropertyStreamHandle_ResolveInternal_mFB0A48675D8D847197CB392325CDCA837B82E64C (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.PropertyStreamHandle::CheckIsValidAndResolve(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PropertyStreamHandle_CheckIsValidAndResolve_mD4036D6F0444B68BC4C1AECDD7429FEBAF03203C (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) ;
// System.Single UnityEngine.Animations.PropertyStreamHandle::GetFloatInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float PropertyStreamHandle_GetFloatInternal_m11E03DE3C420D8F9BFA7926D1F452766BD34B783 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) ;
// System.Single UnityEngine.Animations.PropertyStreamHandle::GetFloat(UnityEngine.Animations.AnimationStream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float PropertyStreamHandle_GetFloat_mAEC50079467900B74F7B485BBAF65A4DE1BBB8DF (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Animations.PropertyStreamHandle::GetIntInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t PropertyStreamHandle_GetIntInternal_m598EC48F1700FB43EF1A5880178BB841A781D4C9 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Animations.PropertyStreamHandle::GetInt(UnityEngine.Animations.AnimationStream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t PropertyStreamHandle_GetInt_m58CECCE1A73DB1EA96E287B5B7BF51BF502D8D98 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.PropertyStreamHandle::GetBoolInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PropertyStreamHandle_GetBoolInternal_m25D06AA6F53B3265E80243E589F39EF4C30E7DAD (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.PropertyStreamHandle::GetBool(UnityEngine.Animations.AnimationStream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PropertyStreamHandle_GetBool_mBB5B008988E6CC47C526CF654E53804909C141E0 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.PropertyStreamHandle::ResolveInternal_Injected(UnityEngine.Animations.PropertyStreamHandle&,UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PropertyStreamHandle_ResolveInternal_Injected_m2F38D58EFF0643C85F7ABA035DAC718D5A885B0F (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, const RuntimeMethod* method) ;
// System.Single UnityEngine.Animations.PropertyStreamHandle::GetFloatInternal_Injected(UnityEngine.Animations.PropertyStreamHandle&,UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float PropertyStreamHandle_GetFloatInternal_Injected_m6604EAC314F4B69CAC8601BE540A723ADCC8734E (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Animations.PropertyStreamHandle::GetIntInternal_Injected(UnityEngine.Animations.PropertyStreamHandle&,UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t PropertyStreamHandle_GetIntInternal_Injected_mDFDACC53C8FAA687E154D78C9A86B58EA836AF14 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.PropertyStreamHandle::GetBoolInternal_Injected(UnityEngine.Animations.PropertyStreamHandle&,UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PropertyStreamHandle_GetBoolInternal_Injected_mDE6D207C4962AC0FC356962421418A632D7120D6 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.TransformSceneHandle::get_createdByNative()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransformSceneHandle_get_createdByNative_m40C489AAD66DEDFEB69F6BB25B1177FC51922D3D (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.TransformSceneHandle::get_hasTransformSceneHandleDefinitionIndex()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransformSceneHandle_get_hasTransformSceneHandleDefinitionIndex_mBD4B49152989D4379E6D726B0F7E834EA484383B (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.TransformSceneHandle::HasValidTransform(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransformSceneHandle_HasValidTransform_m19ABA61E5902DA7F1207798BBB4DCFBE515B9537 (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) ;
// System.Void System.NullReferenceException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NullReferenceException__ctor_mA41317A57F5C1C0E3F59C7EB25ABD484564B23D4 (NullReferenceException_tBDE63A6D24569B964908408389070C6A9F5005BB* __this, String_t* ___0_message, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.TransformSceneHandle::CheckIsValid(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformSceneHandle_CheckIsValid_m33214B5950C49A143A5548B7FB1672062204655A (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Animations.TransformSceneHandle::GetPositionInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 TransformSceneHandle_GetPositionInternal_mAC29651E3EB5FC3BD4CB49B2B09EB9897375FC29 (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Animations.TransformSceneHandle::GetPosition(UnityEngine.Animations.AnimationStream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 TransformSceneHandle_GetPosition_mDB8261C4AF79828292D555DBF91A6559DE41B3B8 (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, const RuntimeMethod* method) ;
// UnityEngine.Quaternion UnityEngine.Animations.TransformSceneHandle::GetRotationInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 TransformSceneHandle_GetRotationInternal_m53DDDEE9D5824A6E5BFEE5C5681A33E468E0FC5E (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) ;
// UnityEngine.Quaternion UnityEngine.Animations.TransformSceneHandle::GetRotation(UnityEngine.Animations.AnimationStream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 TransformSceneHandle_GetRotation_m8F6CA3E2302A43103A808120AEE1C527EB2A2F05 (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.TransformSceneHandle::HasValidTransform_Injected(UnityEngine.Animations.TransformSceneHandle&,UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransformSceneHandle_HasValidTransform_Injected_m1F0CEB3799D44896F7F501AE0E99BF49938ADA4B (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.TransformSceneHandle::GetPositionInternal_Injected(UnityEngine.Animations.TransformSceneHandle&,UnityEngine.Animations.AnimationStream&,UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformSceneHandle_GetPositionInternal_Injected_m5CB0EBF73345BD9F90E504DCEFE1C2D4B349FAB0 (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___2_ret, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.TransformSceneHandle::GetRotationInternal_Injected(UnityEngine.Animations.TransformSceneHandle&,UnityEngine.Animations.AnimationStream&,UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformSceneHandle_GetRotationInternal_Injected_m50FA487714327D6B98868DB6322D1F72260B8BBE (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974* ___2_ret, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorJobExtensions::InternalBindStreamTransform(UnityEngine.Animator,UnityEngine.Transform,UnityEngine.Animations.TransformStreamHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorJobExtensions_InternalBindStreamTransform_m83A49A8A13E2FA7AD67FAECA1B24F11D15550C2F (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___1_transform, TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* ___2_transformStreamHandle, const RuntimeMethod* method) ;
// UnityEngine.Animations.PropertyStreamHandle UnityEngine.Animations.AnimatorJobExtensions::BindStreamProperty(UnityEngine.Animator,UnityEngine.Transform,System.Type,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3 AnimatorJobExtensions_BindStreamProperty_m02E8A9116C4DB619A2B4E28AEADC593ECDE78994 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___1_transform, Type_t* ___2_type, String_t* ___3_property, bool ___4_isObjectReference, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorJobExtensions::InternalBindStreamProperty(UnityEngine.Animator,UnityEngine.Transform,System.Type,System.String,System.Boolean,UnityEngine.Animations.PropertyStreamHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorJobExtensions_InternalBindStreamProperty_mE09521CB89443739B6428A0FD6B012D8C0601415 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___1_transform, Type_t* ___2_type, String_t* ___3_property, bool ___4_isObjectReference, PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* ___5_propertyStreamHandle, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimatorJobExtensions::InternalBindSceneTransform(UnityEngine.Animator,UnityEngine.Transform,UnityEngine.Animations.TransformSceneHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorJobExtensions_InternalBindSceneTransform_m5C33CC9DC1C95933DA91E42411080A4DA49216C6 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___1_transform, TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* ___2_transformSceneHandle, const RuntimeMethod* method) ;
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationClipPlayable::CreateHandle(UnityEngine.Playables.PlayableGraph,UnityEngine.AnimationClip)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationClipPlayable_CreateHandle_m9804DF3694EC65E8531F6839194AB189401AE564 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* ___1_clip, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationClipPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable__ctor_mF2EE31CC772B100F98CCAE26963059C6C722FA1A (AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationClipPlayable::CreateHandleInternal(UnityEngine.Playables.PlayableGraph,UnityEngine.AnimationClip,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClipPlayable_CreateHandleInternal_mB8466F44A261B040DBCE8BA442DA8CF7153D2212 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* ___1_clip, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___2_handle, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationClipPlayable>()
inline bool PlayableHandle_IsPlayableOfType_TisAnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969_m9AA33A8596A6C41CAA768B0A6EF59B75658A1FB8 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, const RuntimeMethod*))PlayableHandle_IsPlayableOfType_TisAnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969_m9AA33A8596A6C41CAA768B0A6EF59B75658A1FB8_gshared)(__this, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationClipPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationClipPlayable_GetHandle_mE775F2247901BA293DB01A8D384D3F9D02A25627 (AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationClipPlayable::Equals(UnityEngine.Animations.AnimationClipPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClipPlayable_Equals_mC5263BEA86C02CEDF93C5B14EAA168883E1DB5F4 (AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* __this, AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 ___0_other, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationClipPlayable::GetApplyFootIKInternal(UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClipPlayable_GetApplyFootIKInternal_m7695131A7D19C888FB75F2CE2227EC24361AA20A (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationClipPlayable::GetApplyFootIK()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClipPlayable_GetApplyFootIK_m3E599D05D6A40BEFD651618CE5DDA03F15A3610F (AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationClipPlayable::SetApplyFootIKInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable_SetApplyFootIKInternal_m57C77DC9937F7BA02885EEBF5D7CDC1CF9412DFC (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, bool ___1_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationClipPlayable::SetApplyFootIK(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable_SetApplyFootIK_m7CBA77F56815AD21784AC53D9EBDAE18AFA48507 (AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* __this, bool ___0_value, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationClipPlayable::GetApplyPlayableIKInternal(UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClipPlayable_GetApplyPlayableIKInternal_m4531AC8A44F8BE94292B95E03E33B5C7E9DAF474 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationClipPlayable::GetApplyPlayableIK()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClipPlayable_GetApplyPlayableIK_m04EE9E4136AC350F27814DF3B006238260CF3EE9 (AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationClipPlayable::SetApplyPlayableIKInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable_SetApplyPlayableIKInternal_mBCA5B580834435175256C8319275DD443281DD82 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, bool ___1_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationClipPlayable::SetApplyPlayableIK(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable_SetApplyPlayableIK_m69A6F6E28EB250956E27C1720A0A842848F54DAB (AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* __this, bool ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationClipPlayable::SetRemoveStartOffsetInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable_SetRemoveStartOffsetInternal_m5C095AAB7C17821144A2CD4D7DDFE562358CC5A4 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, bool ___1_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationClipPlayable::SetRemoveStartOffset(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable_SetRemoveStartOffset_mBAC88E40F6A759FACA4105EF683181D43381C8E5 (AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* __this, bool ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationClipPlayable::SetOverrideLoopTimeInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable_SetOverrideLoopTimeInternal_m44BAF0A6EE093D0E30EC8FF99423BF6E4B832CC5 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, bool ___1_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationClipPlayable::SetOverrideLoopTime(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable_SetOverrideLoopTime_mF1F57940D8DDBCC6EBCB75A27C2372BB39DED177 (AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* __this, bool ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationClipPlayable::SetLoopTimeInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable_SetLoopTimeInternal_mC308D81D4A82EFACED882515D17935E43298E386 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, bool ___1_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationClipPlayable::SetLoopTime(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable_SetLoopTime_m3AAA1134C4D339C84EF57FE289D33100D4971ED8 (AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* __this, bool ___0_value, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationClipPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.AnimationClip,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClipPlayable_CreateHandleInternal_Injected_m4FD6B80E5194144660D7974F13F44BA0355C6E3B (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* ___1_clip, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___2_handle, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationPosePlayable>()
inline bool PlayableHandle_IsPlayableOfType_TisAnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C_m61A79154B28DAE22A64165C871757F3E447822A6 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, const RuntimeMethod*))PlayableHandle_IsPlayableOfType_TisAnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C_m61A79154B28DAE22A64165C871757F3E447822A6_gshared)(__this, method);
}
// System.Void UnityEngine.Animations.AnimationPosePlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationPosePlayable__ctor_mC6C096785918358CA7EC12BABCDF4BBD47F7BA3F (AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method) ;
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationPosePlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationPosePlayable_GetHandle_m5DC7CA4CAF3CD525D454D99EBC3D12C3571B527B (AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationPosePlayable::Equals(UnityEngine.Animations.AnimationPosePlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationPosePlayable_Equals_m10F1E7DD7037B2AB3F7DAE3E01A1DC843EABD0A3 (AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C* __this, AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C ___0_other, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.ConstraintSource::set_sourceTransform(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConstraintSource_set_sourceTransform_mC905D9E04293D785BA40E1E0378457A77170A31B (ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F* __this, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.ConstraintSource::set_weight(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConstraintSource_set_weight_m40EADC470F7D906EEB89A515F75CC8B0648368D7 (ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F* __this, float ___0_value, const RuntimeMethod* method) ;
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationMotionXToDeltaPlayable::CreateHandle(UnityEngine.Playables.PlayableGraph)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationMotionXToDeltaPlayable_CreateHandle_m848549F4FA09509BCBD846D85E5E2E8DFB8CBE3B (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationMotionXToDeltaPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationMotionXToDeltaPlayable__ctor_mDE3C14B4B975AC693669D66B6E41BB6432AFA940 (AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationMotionXToDeltaPlayable::CreateHandleInternal(UnityEngine.Playables.PlayableGraph,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationMotionXToDeltaPlayable_CreateHandleInternal_m9556CCBB3F290E53A0BA8021F06C8E83232EF706 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___1_handle, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationMotionXToDeltaPlayable>()
inline bool PlayableHandle_IsPlayableOfType_TisAnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18_mE6DAD58415B04EE79FD34641B365283758722ABF (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, const RuntimeMethod*))PlayableHandle_IsPlayableOfType_TisAnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18_mE6DAD58415B04EE79FD34641B365283758722ABF_gshared)(__this, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationMotionXToDeltaPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationMotionXToDeltaPlayable_GetHandle_m09F605E78AD7F0135C7F57EB048031091A50E3A2 (AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationMotionXToDeltaPlayable::Equals(UnityEngine.Animations.AnimationMotionXToDeltaPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationMotionXToDeltaPlayable_Equals_m7CBF3B7618EDBA4ECC2F3C2F54011248BC45CDCC (AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18* __this, AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18 ___0_other, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationMotionXToDeltaPlayable::SetAbsoluteMotionInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationMotionXToDeltaPlayable_SetAbsoluteMotionInternal_m616455F80B4EAE4A0CD24A29630792C62872E929 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, bool ___1_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationMotionXToDeltaPlayable::SetAbsoluteMotion(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationMotionXToDeltaPlayable_SetAbsoluteMotion_m5D1B029F6E6BFFB521CC6CB72ACBE7EA27B28715 (AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18* __this, bool ___0_value, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationMotionXToDeltaPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationMotionXToDeltaPlayable_CreateHandleInternal_Injected_mAFF1C58B8D07A6A9E92042C038231D7CC873EF11 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___1_handle, const RuntimeMethod* method) ;
// UnityEngine.Animations.AnimationMixerPlayable UnityEngine.Animations.AnimationMixerPlayable::Create(UnityEngine.Playables.PlayableGraph,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0 AnimationMixerPlayable_Create_m4136E1F8A7BF26D3DE52C68111F8E1D789A7A8F3 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, int32_t ___1_inputCount, const RuntimeMethod* method) ;
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationMixerPlayable::CreateHandle(UnityEngine.Playables.PlayableGraph,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationMixerPlayable_CreateHandle_m98DCB979893A9C4F782B2E07EF12BD69CF838A9C (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, int32_t ___1_inputCount, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationMixerPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationMixerPlayable__ctor_mBF84CC064549C2C00B2AE1174018335958EB7EA7 (AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationMixerPlayable::CreateHandleInternal(UnityEngine.Playables.PlayableGraph,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationMixerPlayable_CreateHandleInternal_m0C404F86C8C0FDD248BED7E153F3BEFBEEA39D37 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___1_handle, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationMixerPlayable>()
inline bool PlayableHandle_IsPlayableOfType_TisAnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0_m644E76378CB4DDC0CE669FE1DCE8A8917595D0ED (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, const RuntimeMethod*))PlayableHandle_IsPlayableOfType_TisAnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0_m644E76378CB4DDC0CE669FE1DCE8A8917595D0ED_gshared)(__this, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationMixerPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationMixerPlayable_GetHandle_mBA6CEB1579A713A985D474E75BC282728318882F (AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationMixerPlayable::Equals(UnityEngine.Animations.AnimationMixerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationMixerPlayable_Equals_m6EBE215636EEEA3196A43F4D6C1FE6DD704AFA4E (AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0* __this, AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0 ___0_other, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationMixerPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationMixerPlayable_CreateHandleInternal_Injected_mD26E05A0F2676C90B7F06E718B7843167D33FE1E (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___1_handle, const RuntimeMethod* method) ;
// System.Boolean System.IntPtr::op_Inequality(System.IntPtr,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool IntPtr_op_Inequality_m90EFC9C4CAD9A33E309F2DDF98EE4E1DD253637B (intptr_t ___0_value1, intptr_t ___1_value2, const RuntimeMethod* method) ;
// System.Single UnityEngine.Animations.AnimationStream::GetDeltaTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimationStream_GetDeltaTime_m335ACEAEEAEE7E3FAE1CCBD81DA839C6C1CFF0A9 (AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* __this, const RuntimeMethod* method) ;
// System.Single UnityEngine.Animations.AnimationStream::get_deltaTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimationStream_get_deltaTime_mECEF75B188313080405BFB556AB4CFD972233861 (AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* __this, const RuntimeMethod* method) ;
// System.Single UnityEngine.Animations.AnimationStream::GetDeltaTime_Injected(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimationStream_GetDeltaTime_Injected_mF06679592F1FEFA1DD24E4553554913F59DAAE55 (AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0__unity_self, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalCreateAnimationOutput(UnityEngine.Playables.PlayableGraph&,System.String,UnityEngine.Playables.PlayableOutputHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationPlayableGraphExtensions_InternalCreateAnimationOutput_m2FBE35C9ADFA39052F34E49F46E39CEBD10F4B49 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, String_t* ___1_name, PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883* ___2_handle, const RuntimeMethod* method) ;
// UnityEngine.Animations.AnimationPlayableOutput UnityEngine.Animations.AnimationPlayableOutput::get_Null()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E AnimationPlayableOutput_get_Null_mDF5638798B49F3E7ACCF766C266D7F776E553900 (const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationPlayableOutput::.ctor(UnityEngine.Playables.PlayableOutputHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationPlayableOutput__ctor_mE4FB8AA6DFB2F3C18E04A9317F5CE53597A7D22A (AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E* __this, PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 ___0_handle, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationPlayableOutput::SetTarget(UnityEngine.Animator)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationPlayableOutput_SetTarget_m0F7745C4A721D76EB1E804AA48E70C9C798E0DCE (AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E* __this, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_value, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableOutputHandle::IsValid()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableOutputHandle_IsValid_mA94C343D72B72C3B1C7636C93A8DB5EA71691312 (PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Playables.PlayableOutputHandle::IsPlayableOutputOfType<UnityEngine.Animations.AnimationPlayableOutput>()
inline bool PlayableOutputHandle_IsPlayableOutputOfType_TisAnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E_mDA87D18E66EB65AFF53F5AD517C7FBA69DD6D793 (PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883*, const RuntimeMethod*))PlayableOutputHandle_IsPlayableOutputOfType_TisAnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E_mDA87D18E66EB65AFF53F5AD517C7FBA69DD6D793_gshared)(__this, method);
}
// UnityEngine.Playables.PlayableOutputHandle UnityEngine.Playables.PlayableOutputHandle::get_Null()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 PlayableOutputHandle_get_Null_m656E8D2549FA031DA8A2EA5B39CE3B33D75B69F8 (const RuntimeMethod* method) ;
// UnityEngine.Playables.PlayableOutputHandle UnityEngine.Animations.AnimationPlayableOutput::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 AnimationPlayableOutput_GetHandle_m2A8E2A9CBD12EDCF48FC946445AB42802083338D (AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Playables.PlayableOutput::.ctor(UnityEngine.Playables.PlayableOutputHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PlayableOutput__ctor_m55FBB20EC479F67641835EA48D84A1AB3DF39747 (PlayableOutput_t2F7C45A58DA3E788EEDDB439549E21CF3FCF3680* __this, PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 ___0_handle, const RuntimeMethod* method) ;
// UnityEngine.Playables.PlayableOutputHandle UnityEngine.Playables.PlayableOutput::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 PlayableOutput_GetHandle_m12FF2889D15884CBEB92A6CB376827EBA5A607BF (PlayableOutput_t2F7C45A58DA3E788EEDDB439549E21CF3FCF3680* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animations.AnimationPlayableOutput::InternalSetTarget(UnityEngine.Playables.PlayableOutputHandle&,UnityEngine.Animator)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationPlayableOutput_InternalSetTarget_m49002BC3713A0AF76F2447A0147493F234B8E616 (PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883* ___0_handle, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___1_target, const RuntimeMethod* method) ;
// System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Type_t* Type_GetTypeFromHandle_m6062B81682F79A4D6DF2640692EE6D9987858C57 (RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B ___0_handle, const RuntimeMethod* method) ;
// System.Void UnityEngine.Playables.PlayableBinding/CreateOutputMethod::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CreateOutputMethod__ctor_m5A339017CD8ECB0140EB936FD2A5B589B20166B4 (CreateOutputMethod_tD18AFE3B69E6DDD913D82D5FA1D5D909CEEC8509* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) ;
// UnityEngine.Playables.PlayableBinding UnityEngine.Playables.PlayableBinding::CreateInternal(System.String,UnityEngine.Object,System.Type,UnityEngine.Playables.PlayableBinding/CreateOutputMethod)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableBinding_tB68B3BAC47F4F4C559640472174D5BEF93CB6AB4 PlayableBinding_CreateInternal_m63C8C98E659B52725E0373019ECFCEC22167A47A (String_t* ___0_name, Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___1_sourceObject, Type_t* ___2_sourceType, CreateOutputMethod_tD18AFE3B69E6DDD913D82D5FA1D5D909CEEC8509* ___3_createFunction, const RuntimeMethod* method) ;
// UnityEngine.Playables.PlayableOutput UnityEngine.Animations.AnimationPlayableOutput::op_Implicit(UnityEngine.Animations.AnimationPlayableOutput)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableOutput_t2F7C45A58DA3E788EEDDB439549E21CF3FCF3680 AnimationPlayableOutput_op_Implicit_mB256AA7AA6BC0577B47399941D4B42BBC5C28DA7 (AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E ___0_output, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.AnimatorOverrideController::OnInvalidateOverrideController(UnityEngine.AnimatorOverrideController)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorOverrideController_OnInvalidateOverrideController_mA6B0AA977505FDEFDD6BCA2E941FD3A18AE1AD23 (AnimatorOverrideController_tF78BD58B30BB0D767E7A96F8428EA66F2DFD5493* ___0_controller, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		AnimatorOverrideController_tF78BD58B30BB0D767E7A96F8428EA66F2DFD5493* L_0 = ___0_controller;
		NullCheck(L_0);
		OnOverrideControllerDirtyCallback_tDC67F7661A27502AD804BDE0B696955AFD4A44D5* L_1 = L_0->___OnOverrideControllerDirty_4;
		V_0 = (bool)((!(((RuntimeObject*)(OnOverrideControllerDirtyCallback_tDC67F7661A27502AD804BDE0B696955AFD4A44D5*)L_1) <= ((RuntimeObject*)(RuntimeObject*)NULL)))? 1 : 0);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_001a;
		}
	}
	{
		AnimatorOverrideController_tF78BD58B30BB0D767E7A96F8428EA66F2DFD5493* L_3 = ___0_controller;
		NullCheck(L_3);
		OnOverrideControllerDirtyCallback_tDC67F7661A27502AD804BDE0B696955AFD4A44D5* L_4 = L_3->___OnOverrideControllerDirty_4;
		NullCheck(L_4);
		OnOverrideControllerDirtyCallback_Invoke_m538DCB0FFFE75495DC3977DBBF55A07C570F8B5A_inline(L_4, NULL);
	}

IL_001a:
	{
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void OnOverrideControllerDirtyCallback_Invoke_m538DCB0FFFE75495DC3977DBBF55A07C570F8B5A_Multicast(OnOverrideControllerDirtyCallback_tDC67F7661A27502AD804BDE0B696955AFD4A44D5* __this, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates_13->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates_13->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		OnOverrideControllerDirtyCallback_tDC67F7661A27502AD804BDE0B696955AFD4A44D5* currentDelegate = reinterpret_cast<OnOverrideControllerDirtyCallback_tDC67F7661A27502AD804BDE0B696955AFD4A44D5*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl_1)((Il2CppObject*)currentDelegate->___method_code_6, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method_3));
	}
}
void OnOverrideControllerDirtyCallback_Invoke_m538DCB0FFFE75495DC3977DBBF55A07C570F8B5A_OpenInst(OnOverrideControllerDirtyCallback_tDC67F7661A27502AD804BDE0B696955AFD4A44D5* __this, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(method);
}
void OnOverrideControllerDirtyCallback_Invoke_m538DCB0FFFE75495DC3977DBBF55A07C570F8B5A_OpenStatic(OnOverrideControllerDirtyCallback_tDC67F7661A27502AD804BDE0B696955AFD4A44D5* __this, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(method);
}
void OnOverrideControllerDirtyCallback_Invoke_m538DCB0FFFE75495DC3977DBBF55A07C570F8B5A_OpenStaticInvoker(OnOverrideControllerDirtyCallback_tDC67F7661A27502AD804BDE0B696955AFD4A44D5* __this, const RuntimeMethod* method)
{
	InvokerActionInvoker0::Invoke(__this->___method_ptr_0, method, NULL);
}
void OnOverrideControllerDirtyCallback_Invoke_m538DCB0FFFE75495DC3977DBBF55A07C570F8B5A_ClosedStaticInvoker(OnOverrideControllerDirtyCallback_tDC67F7661A27502AD804BDE0B696955AFD4A44D5* __this, const RuntimeMethod* method)
{
	InvokerActionInvoker1< RuntimeObject* >::Invoke(__this->___method_ptr_0, method, NULL, __this->___m_target_2);
}
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_OnOverrideControllerDirtyCallback_tDC67F7661A27502AD804BDE0B696955AFD4A44D5 (OnOverrideControllerDirtyCallback_tDC67F7661A27502AD804BDE0B696955AFD4A44D5* __this, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)();
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_reverse_pinvoke_function_ptr(__this));
	// Native function invocation
	il2cppPInvokeFunc();

}
// System.Void UnityEngine.AnimatorOverrideController/OnOverrideControllerDirtyCallback::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OnOverrideControllerDirtyCallback__ctor_mA49B11AF24CB49A9B764058DB73CE221AE54E106 (OnOverrideControllerDirtyCallback_tDC67F7661A27502AD804BDE0B696955AFD4A44D5* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr_0 = il2cpp_codegen_get_virtual_call_method_pointer((RuntimeMethod*)___1_method);
	__this->___method_3 = ___1_method;
	__this->___m_target_2 = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target_2), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code_6 = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 0;
		if (il2cpp_codegen_call_method_via_invoker((RuntimeMethod*)___1_method))
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&OnOverrideControllerDirtyCallback_Invoke_m538DCB0FFFE75495DC3977DBBF55A07C570F8B5A_OpenStaticInvoker;
			else
				__this->___invoke_impl_1 = (intptr_t)&OnOverrideControllerDirtyCallback_Invoke_m538DCB0FFFE75495DC3977DBBF55A07C570F8B5A_ClosedStaticInvoker;
		else
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&OnOverrideControllerDirtyCallback_Invoke_m538DCB0FFFE75495DC3977DBBF55A07C570F8B5A_OpenStatic;
			else
				{
					__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
					__this->___method_code_6 = (intptr_t)__this->___m_target_2;
				}
	}
	else
	{
		if (___0_object == NULL)
			il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
		__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
		__this->___method_code_6 = (intptr_t)__this->___m_target_2;
	}
	__this->___extra_arg_5 = (intptr_t)&OnOverrideControllerDirtyCallback_Invoke_m538DCB0FFFE75495DC3977DBBF55A07C570F8B5A_Multicast;
}
// System.Void UnityEngine.AnimatorOverrideController/OnOverrideControllerDirtyCallback::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OnOverrideControllerDirtyCallback_Invoke_m538DCB0FFFE75495DC3977DBBF55A07C570F8B5A (OnOverrideControllerDirtyCallback_tDC67F7661A27502AD804BDE0B696955AFD4A44D5* __this, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: UnityEngine.SkeletonBone
IL2CPP_EXTERN_C void SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshal_pinvoke(const SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126& unmarshaled, SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_pinvoke& marshaled)
{
	marshaled.___name_0 = il2cpp_codegen_marshal_string(unmarshaled.___name_0);
	marshaled.___parentName_1 = il2cpp_codegen_marshal_string(unmarshaled.___parentName_1);
	marshaled.___position_2 = unmarshaled.___position_2;
	marshaled.___rotation_3 = unmarshaled.___rotation_3;
	marshaled.___scale_4 = unmarshaled.___scale_4;
}
IL2CPP_EXTERN_C void SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshal_pinvoke_back(const SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_pinvoke& marshaled, SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126& unmarshaled)
{
	unmarshaled.___name_0 = il2cpp_codegen_marshal_string_result(marshaled.___name_0);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___name_0), (void*)il2cpp_codegen_marshal_string_result(marshaled.___name_0));
	unmarshaled.___parentName_1 = il2cpp_codegen_marshal_string_result(marshaled.___parentName_1);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___parentName_1), (void*)il2cpp_codegen_marshal_string_result(marshaled.___parentName_1));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 unmarshaledposition_temp_2;
	memset((&unmarshaledposition_temp_2), 0, sizeof(unmarshaledposition_temp_2));
	unmarshaledposition_temp_2 = marshaled.___position_2;
	unmarshaled.___position_2 = unmarshaledposition_temp_2;
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 unmarshaledrotation_temp_3;
	memset((&unmarshaledrotation_temp_3), 0, sizeof(unmarshaledrotation_temp_3));
	unmarshaledrotation_temp_3 = marshaled.___rotation_3;
	unmarshaled.___rotation_3 = unmarshaledrotation_temp_3;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 unmarshaledscale_temp_4;
	memset((&unmarshaledscale_temp_4), 0, sizeof(unmarshaledscale_temp_4));
	unmarshaledscale_temp_4 = marshaled.___scale_4;
	unmarshaled.___scale_4 = unmarshaledscale_temp_4;
}
// Conversion method for clean up from marshalling of: UnityEngine.SkeletonBone
IL2CPP_EXTERN_C void SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshal_pinvoke_cleanup(SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_pinvoke& marshaled)
{
	il2cpp_codegen_marshal_free(marshaled.___name_0);
	marshaled.___name_0 = NULL;
	il2cpp_codegen_marshal_free(marshaled.___parentName_1);
	marshaled.___parentName_1 = NULL;
}
// Conversion methods for marshalling of: UnityEngine.SkeletonBone
IL2CPP_EXTERN_C void SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshal_com(const SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126& unmarshaled, SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_com& marshaled)
{
	marshaled.___name_0 = il2cpp_codegen_marshal_bstring(unmarshaled.___name_0);
	marshaled.___parentName_1 = il2cpp_codegen_marshal_bstring(unmarshaled.___parentName_1);
	marshaled.___position_2 = unmarshaled.___position_2;
	marshaled.___rotation_3 = unmarshaled.___rotation_3;
	marshaled.___scale_4 = unmarshaled.___scale_4;
}
IL2CPP_EXTERN_C void SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshal_com_back(const SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_com& marshaled, SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126& unmarshaled)
{
	unmarshaled.___name_0 = il2cpp_codegen_marshal_bstring_result(marshaled.___name_0);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___name_0), (void*)il2cpp_codegen_marshal_bstring_result(marshaled.___name_0));
	unmarshaled.___parentName_1 = il2cpp_codegen_marshal_bstring_result(marshaled.___parentName_1);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___parentName_1), (void*)il2cpp_codegen_marshal_bstring_result(marshaled.___parentName_1));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 unmarshaledposition_temp_2;
	memset((&unmarshaledposition_temp_2), 0, sizeof(unmarshaledposition_temp_2));
	unmarshaledposition_temp_2 = marshaled.___position_2;
	unmarshaled.___position_2 = unmarshaledposition_temp_2;
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 unmarshaledrotation_temp_3;
	memset((&unmarshaledrotation_temp_3), 0, sizeof(unmarshaledrotation_temp_3));
	unmarshaledrotation_temp_3 = marshaled.___rotation_3;
	unmarshaled.___rotation_3 = unmarshaledrotation_temp_3;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 unmarshaledscale_temp_4;
	memset((&unmarshaledscale_temp_4), 0, sizeof(unmarshaledscale_temp_4));
	unmarshaledscale_temp_4 = marshaled.___scale_4;
	unmarshaled.___scale_4 = unmarshaledscale_temp_4;
}
// Conversion method for clean up from marshalling of: UnityEngine.SkeletonBone
IL2CPP_EXTERN_C void SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshal_com_cleanup(SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_com& marshaled)
{
	il2cpp_codegen_marshal_free_bstring(marshaled.___name_0);
	marshaled.___name_0 = NULL;
	il2cpp_codegen_marshal_free_bstring(marshaled.___parentName_1);
	marshaled.___parentName_1 = NULL;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: UnityEngine.HumanBone
IL2CPP_EXTERN_C void HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshal_pinvoke(const HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8& unmarshaled, HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_pinvoke& marshaled)
{
	marshaled.___m_BoneName_0 = il2cpp_codegen_marshal_string(unmarshaled.___m_BoneName_0);
	marshaled.___m_HumanName_1 = il2cpp_codegen_marshal_string(unmarshaled.___m_HumanName_1);
	marshaled.___limit_2 = unmarshaled.___limit_2;
}
IL2CPP_EXTERN_C void HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshal_pinvoke_back(const HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_pinvoke& marshaled, HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8& unmarshaled)
{
	unmarshaled.___m_BoneName_0 = il2cpp_codegen_marshal_string_result(marshaled.___m_BoneName_0);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___m_BoneName_0), (void*)il2cpp_codegen_marshal_string_result(marshaled.___m_BoneName_0));
	unmarshaled.___m_HumanName_1 = il2cpp_codegen_marshal_string_result(marshaled.___m_HumanName_1);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___m_HumanName_1), (void*)il2cpp_codegen_marshal_string_result(marshaled.___m_HumanName_1));
	HumanLimit_tE825F951DEE60E2641DD91F3C92C6B56A139A36E unmarshaledlimit_temp_2;
	memset((&unmarshaledlimit_temp_2), 0, sizeof(unmarshaledlimit_temp_2));
	unmarshaledlimit_temp_2 = marshaled.___limit_2;
	unmarshaled.___limit_2 = unmarshaledlimit_temp_2;
}
// Conversion method for clean up from marshalling of: UnityEngine.HumanBone
IL2CPP_EXTERN_C void HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshal_pinvoke_cleanup(HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_pinvoke& marshaled)
{
	il2cpp_codegen_marshal_free(marshaled.___m_BoneName_0);
	marshaled.___m_BoneName_0 = NULL;
	il2cpp_codegen_marshal_free(marshaled.___m_HumanName_1);
	marshaled.___m_HumanName_1 = NULL;
}
// Conversion methods for marshalling of: UnityEngine.HumanBone
IL2CPP_EXTERN_C void HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshal_com(const HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8& unmarshaled, HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_com& marshaled)
{
	marshaled.___m_BoneName_0 = il2cpp_codegen_marshal_bstring(unmarshaled.___m_BoneName_0);
	marshaled.___m_HumanName_1 = il2cpp_codegen_marshal_bstring(unmarshaled.___m_HumanName_1);
	marshaled.___limit_2 = unmarshaled.___limit_2;
}
IL2CPP_EXTERN_C void HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshal_com_back(const HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_com& marshaled, HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8& unmarshaled)
{
	unmarshaled.___m_BoneName_0 = il2cpp_codegen_marshal_bstring_result(marshaled.___m_BoneName_0);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___m_BoneName_0), (void*)il2cpp_codegen_marshal_bstring_result(marshaled.___m_BoneName_0));
	unmarshaled.___m_HumanName_1 = il2cpp_codegen_marshal_bstring_result(marshaled.___m_HumanName_1);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___m_HumanName_1), (void*)il2cpp_codegen_marshal_bstring_result(marshaled.___m_HumanName_1));
	HumanLimit_tE825F951DEE60E2641DD91F3C92C6B56A139A36E unmarshaledlimit_temp_2;
	memset((&unmarshaledlimit_temp_2), 0, sizeof(unmarshaledlimit_temp_2));
	unmarshaledlimit_temp_2 = marshaled.___limit_2;
	unmarshaled.___limit_2 = unmarshaledlimit_temp_2;
}
// Conversion method for clean up from marshalling of: UnityEngine.HumanBone
IL2CPP_EXTERN_C void HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshal_com_cleanup(HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_com& marshaled)
{
	il2cpp_codegen_marshal_free_bstring(marshaled.___m_BoneName_0);
	marshaled.___m_BoneName_0 = NULL;
	il2cpp_codegen_marshal_free_bstring(marshaled.___m_HumanName_1);
	marshaled.___m_HumanName_1 = NULL;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif




// Conversion methods for marshalling of: UnityEngine.HumanDescription
IL2CPP_EXTERN_C void HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44_marshal_pinvoke(const HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44& unmarshaled, HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44_marshaled_pinvoke& marshaled)
{
	if (unmarshaled.___human_0 != NULL)
	{
		il2cpp_array_size_t _unmarshaledhuman_Length = (unmarshaled.___human_0)->max_length;
		marshaled.___human_0 = il2cpp_codegen_marshal_allocate_array<HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_pinvoke>(_unmarshaledhuman_Length);
		for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(_unmarshaledhuman_Length); i++)
		{
			HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshal_pinvoke((unmarshaled.___human_0)->GetAtUnchecked(static_cast<il2cpp_array_size_t>(i)), (marshaled.___human_0)[i]);
		}
	}
	else
	{
		marshaled.___human_0 = NULL;
	}
	if (unmarshaled.___skeleton_1 != NULL)
	{
		il2cpp_array_size_t _unmarshaledskeleton_Length = (unmarshaled.___skeleton_1)->max_length;
		marshaled.___skeleton_1 = il2cpp_codegen_marshal_allocate_array<SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_pinvoke>(_unmarshaledskeleton_Length);
		for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(_unmarshaledskeleton_Length); i++)
		{
			SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshal_pinvoke((unmarshaled.___skeleton_1)->GetAtUnchecked(static_cast<il2cpp_array_size_t>(i)), (marshaled.___skeleton_1)[i]);
		}
	}
	else
	{
		marshaled.___skeleton_1 = NULL;
	}
	marshaled.___m_ArmTwist_2 = unmarshaled.___m_ArmTwist_2;
	marshaled.___m_ForeArmTwist_3 = unmarshaled.___m_ForeArmTwist_3;
	marshaled.___m_UpperLegTwist_4 = unmarshaled.___m_UpperLegTwist_4;
	marshaled.___m_LegTwist_5 = unmarshaled.___m_LegTwist_5;
	marshaled.___m_ArmStretch_6 = unmarshaled.___m_ArmStretch_6;
	marshaled.___m_LegStretch_7 = unmarshaled.___m_LegStretch_7;
	marshaled.___m_FeetSpacing_8 = unmarshaled.___m_FeetSpacing_8;
	marshaled.___m_GlobalScale_9 = unmarshaled.___m_GlobalScale_9;
	marshaled.___m_RootMotionBoneName_10 = il2cpp_codegen_marshal_string(unmarshaled.___m_RootMotionBoneName_10);
	marshaled.___m_HasTranslationDoF_11 = static_cast<int32_t>(unmarshaled.___m_HasTranslationDoF_11);
	marshaled.___m_HasExtraRoot_12 = static_cast<int32_t>(unmarshaled.___m_HasExtraRoot_12);
	marshaled.___m_SkeletonHasParents_13 = static_cast<int32_t>(unmarshaled.___m_SkeletonHasParents_13);
}
IL2CPP_EXTERN_C void HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44_marshal_pinvoke_back(const HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44_marshaled_pinvoke& marshaled, HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44& unmarshaled)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HumanBoneU5BU5D_t443B81D55400778CBB921DF04BE932ABF14BAA52_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SkeletonBoneU5BU5D_t84722CE071EF9295326D5A84492716DBC7A15A85_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	if (marshaled.___human_0 != NULL)
	{
		if (unmarshaled.___human_0 == NULL)
		{
			unmarshaled.___human_0 = reinterpret_cast<HumanBoneU5BU5D_t443B81D55400778CBB921DF04BE932ABF14BAA52*>((HumanBoneU5BU5D_t443B81D55400778CBB921DF04BE932ABF14BAA52*)SZArrayNew(HumanBoneU5BU5D_t443B81D55400778CBB921DF04BE932ABF14BAA52_il2cpp_TypeInfo_var, 1));
			Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___human_0), (void*)reinterpret_cast<HumanBoneU5BU5D_t443B81D55400778CBB921DF04BE932ABF14BAA52*>((HumanBoneU5BU5D_t443B81D55400778CBB921DF04BE932ABF14BAA52*)SZArrayNew(HumanBoneU5BU5D_t443B81D55400778CBB921DF04BE932ABF14BAA52_il2cpp_TypeInfo_var, 1)));
		}
		il2cpp_array_size_t _arrayLength = (unmarshaled.___human_0)->max_length;
		for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(_arrayLength); i++)
		{
			HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8 _marshaled____human_0_i__unmarshaled;
			memset((&_marshaled____human_0_i__unmarshaled), 0, sizeof(_marshaled____human_0_i__unmarshaled));
			HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshal_pinvoke_back((marshaled.___human_0)[i], _marshaled____human_0_i__unmarshaled);
			(unmarshaled.___human_0)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), _marshaled____human_0_i__unmarshaled);
		}
	}
	if (marshaled.___skeleton_1 != NULL)
	{
		if (unmarshaled.___skeleton_1 == NULL)
		{
			unmarshaled.___skeleton_1 = reinterpret_cast<SkeletonBoneU5BU5D_t84722CE071EF9295326D5A84492716DBC7A15A85*>((SkeletonBoneU5BU5D_t84722CE071EF9295326D5A84492716DBC7A15A85*)SZArrayNew(SkeletonBoneU5BU5D_t84722CE071EF9295326D5A84492716DBC7A15A85_il2cpp_TypeInfo_var, 1));
			Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___skeleton_1), (void*)reinterpret_cast<SkeletonBoneU5BU5D_t84722CE071EF9295326D5A84492716DBC7A15A85*>((SkeletonBoneU5BU5D_t84722CE071EF9295326D5A84492716DBC7A15A85*)SZArrayNew(SkeletonBoneU5BU5D_t84722CE071EF9295326D5A84492716DBC7A15A85_il2cpp_TypeInfo_var, 1)));
		}
		il2cpp_array_size_t _arrayLength = (unmarshaled.___skeleton_1)->max_length;
		for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(_arrayLength); i++)
		{
			SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126 _marshaled____skeleton_1_i__unmarshaled;
			memset((&_marshaled____skeleton_1_i__unmarshaled), 0, sizeof(_marshaled____skeleton_1_i__unmarshaled));
			SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshal_pinvoke_back((marshaled.___skeleton_1)[i], _marshaled____skeleton_1_i__unmarshaled);
			(unmarshaled.___skeleton_1)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), _marshaled____skeleton_1_i__unmarshaled);
		}
	}
	float unmarshaledm_ArmTwist_temp_2 = 0.0f;
	unmarshaledm_ArmTwist_temp_2 = marshaled.___m_ArmTwist_2;
	unmarshaled.___m_ArmTwist_2 = unmarshaledm_ArmTwist_temp_2;
	float unmarshaledm_ForeArmTwist_temp_3 = 0.0f;
	unmarshaledm_ForeArmTwist_temp_3 = marshaled.___m_ForeArmTwist_3;
	unmarshaled.___m_ForeArmTwist_3 = unmarshaledm_ForeArmTwist_temp_3;
	float unmarshaledm_UpperLegTwist_temp_4 = 0.0f;
	unmarshaledm_UpperLegTwist_temp_4 = marshaled.___m_UpperLegTwist_4;
	unmarshaled.___m_UpperLegTwist_4 = unmarshaledm_UpperLegTwist_temp_4;
	float unmarshaledm_LegTwist_temp_5 = 0.0f;
	unmarshaledm_LegTwist_temp_5 = marshaled.___m_LegTwist_5;
	unmarshaled.___m_LegTwist_5 = unmarshaledm_LegTwist_temp_5;
	float unmarshaledm_ArmStretch_temp_6 = 0.0f;
	unmarshaledm_ArmStretch_temp_6 = marshaled.___m_ArmStretch_6;
	unmarshaled.___m_ArmStretch_6 = unmarshaledm_ArmStretch_temp_6;
	float unmarshaledm_LegStretch_temp_7 = 0.0f;
	unmarshaledm_LegStretch_temp_7 = marshaled.___m_LegStretch_7;
	unmarshaled.___m_LegStretch_7 = unmarshaledm_LegStretch_temp_7;
	float unmarshaledm_FeetSpacing_temp_8 = 0.0f;
	unmarshaledm_FeetSpacing_temp_8 = marshaled.___m_FeetSpacing_8;
	unmarshaled.___m_FeetSpacing_8 = unmarshaledm_FeetSpacing_temp_8;
	float unmarshaledm_GlobalScale_temp_9 = 0.0f;
	unmarshaledm_GlobalScale_temp_9 = marshaled.___m_GlobalScale_9;
	unmarshaled.___m_GlobalScale_9 = unmarshaledm_GlobalScale_temp_9;
	unmarshaled.___m_RootMotionBoneName_10 = il2cpp_codegen_marshal_string_result(marshaled.___m_RootMotionBoneName_10);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___m_RootMotionBoneName_10), (void*)il2cpp_codegen_marshal_string_result(marshaled.___m_RootMotionBoneName_10));
	bool unmarshaledm_HasTranslationDoF_temp_11 = false;
	unmarshaledm_HasTranslationDoF_temp_11 = static_cast<bool>(marshaled.___m_HasTranslationDoF_11);
	unmarshaled.___m_HasTranslationDoF_11 = unmarshaledm_HasTranslationDoF_temp_11;
	bool unmarshaledm_HasExtraRoot_temp_12 = false;
	unmarshaledm_HasExtraRoot_temp_12 = static_cast<bool>(marshaled.___m_HasExtraRoot_12);
	unmarshaled.___m_HasExtraRoot_12 = unmarshaledm_HasExtraRoot_temp_12;
	bool unmarshaledm_SkeletonHasParents_temp_13 = false;
	unmarshaledm_SkeletonHasParents_temp_13 = static_cast<bool>(marshaled.___m_SkeletonHasParents_13);
	unmarshaled.___m_SkeletonHasParents_13 = unmarshaledm_SkeletonHasParents_temp_13;
}
// Conversion method for clean up from marshalling of: UnityEngine.HumanDescription
IL2CPP_EXTERN_C void HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44_marshal_pinvoke_cleanup(HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44_marshaled_pinvoke& marshaled)
{
	if (marshaled.___human_0 != NULL)
	{
		const il2cpp_array_size_t marshaled____human_0_CleanupLoopCount = 1;
		for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(marshaled____human_0_CleanupLoopCount); i++)
		{
			HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshal_pinvoke_cleanup((marshaled.___human_0)[i]);
		}
		il2cpp_codegen_marshal_free(marshaled.___human_0);
		marshaled.___human_0 = NULL;
	}
	if (marshaled.___skeleton_1 != NULL)
	{
		const il2cpp_array_size_t marshaled____skeleton_1_CleanupLoopCount = 1;
		for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(marshaled____skeleton_1_CleanupLoopCount); i++)
		{
			SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshal_pinvoke_cleanup((marshaled.___skeleton_1)[i]);
		}
		il2cpp_codegen_marshal_free(marshaled.___skeleton_1);
		marshaled.___skeleton_1 = NULL;
	}
	il2cpp_codegen_marshal_free(marshaled.___m_RootMotionBoneName_10);
	marshaled.___m_RootMotionBoneName_10 = NULL;
}




// Conversion methods for marshalling of: UnityEngine.HumanDescription
IL2CPP_EXTERN_C void HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44_marshal_com(const HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44& unmarshaled, HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44_marshaled_com& marshaled)
{
	if (unmarshaled.___human_0 != NULL)
	{
		il2cpp_array_size_t _unmarshaledhuman_Length = (unmarshaled.___human_0)->max_length;
		marshaled.___human_0 = il2cpp_codegen_marshal_allocate_array<HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshaled_com>(_unmarshaledhuman_Length);
		for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(_unmarshaledhuman_Length); i++)
		{
			HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshal_com((unmarshaled.___human_0)->GetAtUnchecked(static_cast<il2cpp_array_size_t>(i)), (marshaled.___human_0)[i]);
		}
	}
	else
	{
		marshaled.___human_0 = NULL;
	}
	if (unmarshaled.___skeleton_1 != NULL)
	{
		il2cpp_array_size_t _unmarshaledskeleton_Length = (unmarshaled.___skeleton_1)->max_length;
		marshaled.___skeleton_1 = il2cpp_codegen_marshal_allocate_array<SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshaled_com>(_unmarshaledskeleton_Length);
		for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(_unmarshaledskeleton_Length); i++)
		{
			SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshal_com((unmarshaled.___skeleton_1)->GetAtUnchecked(static_cast<il2cpp_array_size_t>(i)), (marshaled.___skeleton_1)[i]);
		}
	}
	else
	{
		marshaled.___skeleton_1 = NULL;
	}
	marshaled.___m_ArmTwist_2 = unmarshaled.___m_ArmTwist_2;
	marshaled.___m_ForeArmTwist_3 = unmarshaled.___m_ForeArmTwist_3;
	marshaled.___m_UpperLegTwist_4 = unmarshaled.___m_UpperLegTwist_4;
	marshaled.___m_LegTwist_5 = unmarshaled.___m_LegTwist_5;
	marshaled.___m_ArmStretch_6 = unmarshaled.___m_ArmStretch_6;
	marshaled.___m_LegStretch_7 = unmarshaled.___m_LegStretch_7;
	marshaled.___m_FeetSpacing_8 = unmarshaled.___m_FeetSpacing_8;
	marshaled.___m_GlobalScale_9 = unmarshaled.___m_GlobalScale_9;
	marshaled.___m_RootMotionBoneName_10 = il2cpp_codegen_marshal_bstring(unmarshaled.___m_RootMotionBoneName_10);
	marshaled.___m_HasTranslationDoF_11 = static_cast<int32_t>(unmarshaled.___m_HasTranslationDoF_11);
	marshaled.___m_HasExtraRoot_12 = static_cast<int32_t>(unmarshaled.___m_HasExtraRoot_12);
	marshaled.___m_SkeletonHasParents_13 = static_cast<int32_t>(unmarshaled.___m_SkeletonHasParents_13);
}
IL2CPP_EXTERN_C void HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44_marshal_com_back(const HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44_marshaled_com& marshaled, HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44& unmarshaled)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HumanBoneU5BU5D_t443B81D55400778CBB921DF04BE932ABF14BAA52_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SkeletonBoneU5BU5D_t84722CE071EF9295326D5A84492716DBC7A15A85_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	if (marshaled.___human_0 != NULL)
	{
		if (unmarshaled.___human_0 == NULL)
		{
			unmarshaled.___human_0 = reinterpret_cast<HumanBoneU5BU5D_t443B81D55400778CBB921DF04BE932ABF14BAA52*>((HumanBoneU5BU5D_t443B81D55400778CBB921DF04BE932ABF14BAA52*)SZArrayNew(HumanBoneU5BU5D_t443B81D55400778CBB921DF04BE932ABF14BAA52_il2cpp_TypeInfo_var, 1));
			Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___human_0), (void*)reinterpret_cast<HumanBoneU5BU5D_t443B81D55400778CBB921DF04BE932ABF14BAA52*>((HumanBoneU5BU5D_t443B81D55400778CBB921DF04BE932ABF14BAA52*)SZArrayNew(HumanBoneU5BU5D_t443B81D55400778CBB921DF04BE932ABF14BAA52_il2cpp_TypeInfo_var, 1)));
		}
		il2cpp_array_size_t _arrayLength = (unmarshaled.___human_0)->max_length;
		for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(_arrayLength); i++)
		{
			HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8 _marshaled____human_0_i__unmarshaled;
			memset((&_marshaled____human_0_i__unmarshaled), 0, sizeof(_marshaled____human_0_i__unmarshaled));
			HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshal_com_back((marshaled.___human_0)[i], _marshaled____human_0_i__unmarshaled);
			(unmarshaled.___human_0)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), _marshaled____human_0_i__unmarshaled);
		}
	}
	if (marshaled.___skeleton_1 != NULL)
	{
		if (unmarshaled.___skeleton_1 == NULL)
		{
			unmarshaled.___skeleton_1 = reinterpret_cast<SkeletonBoneU5BU5D_t84722CE071EF9295326D5A84492716DBC7A15A85*>((SkeletonBoneU5BU5D_t84722CE071EF9295326D5A84492716DBC7A15A85*)SZArrayNew(SkeletonBoneU5BU5D_t84722CE071EF9295326D5A84492716DBC7A15A85_il2cpp_TypeInfo_var, 1));
			Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___skeleton_1), (void*)reinterpret_cast<SkeletonBoneU5BU5D_t84722CE071EF9295326D5A84492716DBC7A15A85*>((SkeletonBoneU5BU5D_t84722CE071EF9295326D5A84492716DBC7A15A85*)SZArrayNew(SkeletonBoneU5BU5D_t84722CE071EF9295326D5A84492716DBC7A15A85_il2cpp_TypeInfo_var, 1)));
		}
		il2cpp_array_size_t _arrayLength = (unmarshaled.___skeleton_1)->max_length;
		for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(_arrayLength); i++)
		{
			SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126 _marshaled____skeleton_1_i__unmarshaled;
			memset((&_marshaled____skeleton_1_i__unmarshaled), 0, sizeof(_marshaled____skeleton_1_i__unmarshaled));
			SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshal_com_back((marshaled.___skeleton_1)[i], _marshaled____skeleton_1_i__unmarshaled);
			(unmarshaled.___skeleton_1)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), _marshaled____skeleton_1_i__unmarshaled);
		}
	}
	float unmarshaledm_ArmTwist_temp_2 = 0.0f;
	unmarshaledm_ArmTwist_temp_2 = marshaled.___m_ArmTwist_2;
	unmarshaled.___m_ArmTwist_2 = unmarshaledm_ArmTwist_temp_2;
	float unmarshaledm_ForeArmTwist_temp_3 = 0.0f;
	unmarshaledm_ForeArmTwist_temp_3 = marshaled.___m_ForeArmTwist_3;
	unmarshaled.___m_ForeArmTwist_3 = unmarshaledm_ForeArmTwist_temp_3;
	float unmarshaledm_UpperLegTwist_temp_4 = 0.0f;
	unmarshaledm_UpperLegTwist_temp_4 = marshaled.___m_UpperLegTwist_4;
	unmarshaled.___m_UpperLegTwist_4 = unmarshaledm_UpperLegTwist_temp_4;
	float unmarshaledm_LegTwist_temp_5 = 0.0f;
	unmarshaledm_LegTwist_temp_5 = marshaled.___m_LegTwist_5;
	unmarshaled.___m_LegTwist_5 = unmarshaledm_LegTwist_temp_5;
	float unmarshaledm_ArmStretch_temp_6 = 0.0f;
	unmarshaledm_ArmStretch_temp_6 = marshaled.___m_ArmStretch_6;
	unmarshaled.___m_ArmStretch_6 = unmarshaledm_ArmStretch_temp_6;
	float unmarshaledm_LegStretch_temp_7 = 0.0f;
	unmarshaledm_LegStretch_temp_7 = marshaled.___m_LegStretch_7;
	unmarshaled.___m_LegStretch_7 = unmarshaledm_LegStretch_temp_7;
	float unmarshaledm_FeetSpacing_temp_8 = 0.0f;
	unmarshaledm_FeetSpacing_temp_8 = marshaled.___m_FeetSpacing_8;
	unmarshaled.___m_FeetSpacing_8 = unmarshaledm_FeetSpacing_temp_8;
	float unmarshaledm_GlobalScale_temp_9 = 0.0f;
	unmarshaledm_GlobalScale_temp_9 = marshaled.___m_GlobalScale_9;
	unmarshaled.___m_GlobalScale_9 = unmarshaledm_GlobalScale_temp_9;
	unmarshaled.___m_RootMotionBoneName_10 = il2cpp_codegen_marshal_bstring_result(marshaled.___m_RootMotionBoneName_10);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___m_RootMotionBoneName_10), (void*)il2cpp_codegen_marshal_bstring_result(marshaled.___m_RootMotionBoneName_10));
	bool unmarshaledm_HasTranslationDoF_temp_11 = false;
	unmarshaledm_HasTranslationDoF_temp_11 = static_cast<bool>(marshaled.___m_HasTranslationDoF_11);
	unmarshaled.___m_HasTranslationDoF_11 = unmarshaledm_HasTranslationDoF_temp_11;
	bool unmarshaledm_HasExtraRoot_temp_12 = false;
	unmarshaledm_HasExtraRoot_temp_12 = static_cast<bool>(marshaled.___m_HasExtraRoot_12);
	unmarshaled.___m_HasExtraRoot_12 = unmarshaledm_HasExtraRoot_temp_12;
	bool unmarshaledm_SkeletonHasParents_temp_13 = false;
	unmarshaledm_SkeletonHasParents_temp_13 = static_cast<bool>(marshaled.___m_SkeletonHasParents_13);
	unmarshaled.___m_SkeletonHasParents_13 = unmarshaledm_SkeletonHasParents_temp_13;
}
// Conversion method for clean up from marshalling of: UnityEngine.HumanDescription
IL2CPP_EXTERN_C void HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44_marshal_com_cleanup(HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44_marshaled_com& marshaled)
{
	if (marshaled.___human_0 != NULL)
	{
		const il2cpp_array_size_t marshaled____human_0_CleanupLoopCount = 1;
		for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(marshaled____human_0_CleanupLoopCount); i++)
		{
			HumanBone_t9A978BB2457E935D0B6FA64ADDE60562ADAE5FD8_marshal_com_cleanup((marshaled.___human_0)[i]);
		}
		il2cpp_codegen_marshal_free(marshaled.___human_0);
		marshaled.___human_0 = NULL;
	}
	if (marshaled.___skeleton_1 != NULL)
	{
		const il2cpp_array_size_t marshaled____skeleton_1_CleanupLoopCount = 1;
		for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(marshaled____skeleton_1_CleanupLoopCount); i++)
		{
			SkeletonBone_tA999028EED923DB65E286BB99F81541872F5B126_marshal_com_cleanup((marshaled.___skeleton_1)[i]);
		}
		il2cpp_codegen_marshal_free(marshaled.___skeleton_1);
		marshaled.___skeleton_1 = NULL;
	}
	il2cpp_codegen_marshal_free_bstring(marshaled.___m_RootMotionBoneName_10);
	marshaled.___m_RootMotionBoneName_10 = NULL;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Avatar::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Avatar__ctor_mA58012D9A6FD2A7BB88D05E58703B5619536E118 (Avatar_t7861E57EEE2CF8CC61BD63C09737BA22F7ABCA0F* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		Object__ctor_m2149FA40CEC8D82AC20D3508AB40C0D8EFEF68E6(__this, NULL);
		return;
	}
}
// UnityEngine.HumanDescription UnityEngine.Avatar::get_humanDescription()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44 Avatar_get_humanDescription_m8E211B52B89B57AF6793D781C69E46F6E1217E1E (Avatar_t7861E57EEE2CF8CC61BD63C09737BA22F7ABCA0F* __this, const RuntimeMethod* method) 
{
	HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Avatar_get_humanDescription_Injected_mB2DC483AC2212729E7C92641B6FFDDB4056BF3D0(__this, (&V_0), NULL);
		HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44 L_0 = V_0;
		return L_0;
	}
}
// System.Void UnityEngine.Avatar::get_humanDescription_Injected(UnityEngine.HumanDescription&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Avatar_get_humanDescription_Injected_mB2DC483AC2212729E7C92641B6FFDDB4056BF3D0 (Avatar_t7861E57EEE2CF8CC61BD63C09737BA22F7ABCA0F* __this, HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44* ___0_ret, const RuntimeMethod* method) 
{
	typedef void (*Avatar_get_humanDescription_Injected_mB2DC483AC2212729E7C92641B6FFDDB4056BF3D0_ftn) (Avatar_t7861E57EEE2CF8CC61BD63C09737BA22F7ABCA0F*, HumanDescription_tAEFC8398C9AA70799C171BC0AEE07C0031B0CD44*);
	static Avatar_get_humanDescription_Injected_mB2DC483AC2212729E7C92641B6FFDDB4056BF3D0_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Avatar_get_humanDescription_Injected_mB2DC483AC2212729E7C92641B6FFDDB4056BF3D0_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Avatar::get_humanDescription_Injected(UnityEngine.HumanDescription&)");
	_il2cpp_icall_func(__this, ___0_ret);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.AvatarMask::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AvatarMask__ctor_mF37179333D681B0089379006E3FAA89A0AB0C232 (AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		Object__ctor_m2149FA40CEC8D82AC20D3508AB40C0D8EFEF68E6(__this, NULL);
		AvatarMask_Internal_Create_mDC9923A288EDD1F883662D1A5C562BFCDA8F6FFA(__this, NULL);
		return;
	}
}
// System.Void UnityEngine.AvatarMask::Internal_Create(UnityEngine.AvatarMask)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AvatarMask_Internal_Create_mDC9923A288EDD1F883662D1A5C562BFCDA8F6FFA (AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF* ___0_self, const RuntimeMethod* method) 
{
	typedef void (*AvatarMask_Internal_Create_mDC9923A288EDD1F883662D1A5C562BFCDA8F6FFA_ftn) (AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF*);
	static AvatarMask_Internal_Create_mDC9923A288EDD1F883662D1A5C562BFCDA8F6FFA_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AvatarMask_Internal_Create_mDC9923A288EDD1F883662D1A5C562BFCDA8F6FFA_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AvatarMask::Internal_Create(UnityEngine.AvatarMask)");
	_il2cpp_icall_func(___0_self);
}
// System.Boolean UnityEngine.AvatarMask::GetHumanoidBodyPartActive(UnityEngine.AvatarMaskBodyPart)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AvatarMask_GetHumanoidBodyPartActive_m9CB208B9F4A6E150B0C8335FF7F86F6DBD4C9C69 (AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF* __this, int32_t ___0_index, const RuntimeMethod* method) 
{
	typedef bool (*AvatarMask_GetHumanoidBodyPartActive_m9CB208B9F4A6E150B0C8335FF7F86F6DBD4C9C69_ftn) (AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF*, int32_t);
	static AvatarMask_GetHumanoidBodyPartActive_m9CB208B9F4A6E150B0C8335FF7F86F6DBD4C9C69_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AvatarMask_GetHumanoidBodyPartActive_m9CB208B9F4A6E150B0C8335FF7F86F6DBD4C9C69_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AvatarMask::GetHumanoidBodyPartActive(UnityEngine.AvatarMaskBodyPart)");
	bool icallRetVal = _il2cpp_icall_func(__this, ___0_index);
	return icallRetVal;
}
// System.Int32 UnityEngine.AvatarMask::get_transformCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AvatarMask_get_transformCount_m4217FC2AAAB139DD391FE7404096BE69EC4227F7 (AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF* __this, const RuntimeMethod* method) 
{
	typedef int32_t (*AvatarMask_get_transformCount_m4217FC2AAAB139DD391FE7404096BE69EC4227F7_ftn) (AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF*);
	static AvatarMask_get_transformCount_m4217FC2AAAB139DD391FE7404096BE69EC4227F7_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AvatarMask_get_transformCount_m4217FC2AAAB139DD391FE7404096BE69EC4227F7_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AvatarMask::get_transformCount()");
	int32_t icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.String UnityEngine.AvatarMask::GetTransformPath(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AvatarMask_GetTransformPath_m63FD27A96E20C77FCE6E164D994C8666C9900CA5 (AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF* __this, int32_t ___0_index, const RuntimeMethod* method) 
{
	typedef String_t* (*AvatarMask_GetTransformPath_m63FD27A96E20C77FCE6E164D994C8666C9900CA5_ftn) (AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF*, int32_t);
	static AvatarMask_GetTransformPath_m63FD27A96E20C77FCE6E164D994C8666C9900CA5_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AvatarMask_GetTransformPath_m63FD27A96E20C77FCE6E164D994C8666C9900CA5_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AvatarMask::GetTransformPath(System.Int32)");
	String_t* icallRetVal = _il2cpp_icall_func(__this, ___0_index);
	return icallRetVal;
}
// System.Single UnityEngine.AvatarMask::GetTransformWeight(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AvatarMask_GetTransformWeight_mB0574B9F42737B0115832C96BB8F01C5AEDB7BD2 (AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF* __this, int32_t ___0_index, const RuntimeMethod* method) 
{
	typedef float (*AvatarMask_GetTransformWeight_mB0574B9F42737B0115832C96BB8F01C5AEDB7BD2_ftn) (AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF*, int32_t);
	static AvatarMask_GetTransformWeight_mB0574B9F42737B0115832C96BB8F01C5AEDB7BD2_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AvatarMask_GetTransformWeight_mB0574B9F42737B0115832C96BB8F01C5AEDB7BD2_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AvatarMask::GetTransformWeight(System.Int32)");
	float icallRetVal = _il2cpp_icall_func(__this, ___0_index);
	return icallRetVal;
}
// System.Boolean UnityEngine.AvatarMask::GetTransformActive(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AvatarMask_GetTransformActive_m72AA5B6C5707F645496E610DA69D5736396F9AF8 (AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF* __this, int32_t ___0_index, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		int32_t L_0 = ___0_index;
		float L_1;
		L_1 = AvatarMask_GetTransformWeight_mB0574B9F42737B0115832C96BB8F01C5AEDB7BD2(__this, L_0, NULL);
		V_0 = (bool)((((float)L_1) > ((float)(0.5f)))? 1 : 0);
		goto IL_0012;
	}

IL_0012:
	{
		bool L_2 = V_0;
		return L_2;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: UnityEngine.AnimatorControllerParameter
IL2CPP_EXTERN_C void AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02_marshal_pinvoke(const AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02& unmarshaled, AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02_marshaled_pinvoke& marshaled)
{
	marshaled.___m_Name_0 = il2cpp_codegen_marshal_string(unmarshaled.___m_Name_0);
	marshaled.___m_Type_1 = unmarshaled.___m_Type_1;
	marshaled.___m_DefaultFloat_2 = unmarshaled.___m_DefaultFloat_2;
	marshaled.___m_DefaultInt_3 = unmarshaled.___m_DefaultInt_3;
	marshaled.___m_DefaultBool_4 = static_cast<int32_t>(unmarshaled.___m_DefaultBool_4);
}
IL2CPP_EXTERN_C void AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02_marshal_pinvoke_back(const AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02_marshaled_pinvoke& marshaled, AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02& unmarshaled)
{
	unmarshaled.___m_Name_0 = il2cpp_codegen_marshal_string_result(marshaled.___m_Name_0);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___m_Name_0), (void*)il2cpp_codegen_marshal_string_result(marshaled.___m_Name_0));
	int32_t unmarshaledm_Type_temp_1 = 0;
	unmarshaledm_Type_temp_1 = marshaled.___m_Type_1;
	unmarshaled.___m_Type_1 = unmarshaledm_Type_temp_1;
	float unmarshaledm_DefaultFloat_temp_2 = 0.0f;
	unmarshaledm_DefaultFloat_temp_2 = marshaled.___m_DefaultFloat_2;
	unmarshaled.___m_DefaultFloat_2 = unmarshaledm_DefaultFloat_temp_2;
	int32_t unmarshaledm_DefaultInt_temp_3 = 0;
	unmarshaledm_DefaultInt_temp_3 = marshaled.___m_DefaultInt_3;
	unmarshaled.___m_DefaultInt_3 = unmarshaledm_DefaultInt_temp_3;
	bool unmarshaledm_DefaultBool_temp_4 = false;
	unmarshaledm_DefaultBool_temp_4 = static_cast<bool>(marshaled.___m_DefaultBool_4);
	unmarshaled.___m_DefaultBool_4 = unmarshaledm_DefaultBool_temp_4;
}
// Conversion method for clean up from marshalling of: UnityEngine.AnimatorControllerParameter
IL2CPP_EXTERN_C void AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02_marshal_pinvoke_cleanup(AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02_marshaled_pinvoke& marshaled)
{
	il2cpp_codegen_marshal_free(marshaled.___m_Name_0);
	marshaled.___m_Name_0 = NULL;
}
// Conversion methods for marshalling of: UnityEngine.AnimatorControllerParameter
IL2CPP_EXTERN_C void AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02_marshal_com(const AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02& unmarshaled, AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02_marshaled_com& marshaled)
{
	marshaled.___m_Name_0 = il2cpp_codegen_marshal_bstring(unmarshaled.___m_Name_0);
	marshaled.___m_Type_1 = unmarshaled.___m_Type_1;
	marshaled.___m_DefaultFloat_2 = unmarshaled.___m_DefaultFloat_2;
	marshaled.___m_DefaultInt_3 = unmarshaled.___m_DefaultInt_3;
	marshaled.___m_DefaultBool_4 = static_cast<int32_t>(unmarshaled.___m_DefaultBool_4);
}
IL2CPP_EXTERN_C void AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02_marshal_com_back(const AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02_marshaled_com& marshaled, AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02& unmarshaled)
{
	unmarshaled.___m_Name_0 = il2cpp_codegen_marshal_bstring_result(marshaled.___m_Name_0);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___m_Name_0), (void*)il2cpp_codegen_marshal_bstring_result(marshaled.___m_Name_0));
	int32_t unmarshaledm_Type_temp_1 = 0;
	unmarshaledm_Type_temp_1 = marshaled.___m_Type_1;
	unmarshaled.___m_Type_1 = unmarshaledm_Type_temp_1;
	float unmarshaledm_DefaultFloat_temp_2 = 0.0f;
	unmarshaledm_DefaultFloat_temp_2 = marshaled.___m_DefaultFloat_2;
	unmarshaled.___m_DefaultFloat_2 = unmarshaledm_DefaultFloat_temp_2;
	int32_t unmarshaledm_DefaultInt_temp_3 = 0;
	unmarshaledm_DefaultInt_temp_3 = marshaled.___m_DefaultInt_3;
	unmarshaled.___m_DefaultInt_3 = unmarshaledm_DefaultInt_temp_3;
	bool unmarshaledm_DefaultBool_temp_4 = false;
	unmarshaledm_DefaultBool_temp_4 = static_cast<bool>(marshaled.___m_DefaultBool_4);
	unmarshaled.___m_DefaultBool_4 = unmarshaledm_DefaultBool_temp_4;
}
// Conversion method for clean up from marshalling of: UnityEngine.AnimatorControllerParameter
IL2CPP_EXTERN_C void AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02_marshal_com_cleanup(AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02_marshaled_com& marshaled)
{
	il2cpp_codegen_marshal_free_bstring(marshaled.___m_Name_0);
	marshaled.___m_Name_0 = NULL;
}
// System.String UnityEngine.AnimatorControllerParameter::get_name()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AnimatorControllerParameter_get_name_mEB3938ADDF296A0FB37283C987AEE6EC0F4F629E (AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* __this, const RuntimeMethod* method) 
{
	String_t* V_0 = NULL;
	{
		String_t* L_0 = __this->___m_Name_0;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		String_t* L_1 = V_0;
		return L_1;
	}
}
// System.Int32 UnityEngine.AnimatorControllerParameter::get_nameHash()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerParameter_get_nameHash_m92DA605E70604B1BBFD5EA5AE0CD0311F21400EE (AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		String_t* L_0 = __this->___m_Name_0;
		int32_t L_1;
		L_1 = Animator_StringToHash_mD67B872C411BE37641F49D7AA1DBD45B67F63E3A(L_0, NULL);
		V_0 = L_1;
		goto IL_000f;
	}

IL_000f:
	{
		int32_t L_2 = V_0;
		return L_2;
	}
}
// UnityEngine.AnimatorControllerParameterType UnityEngine.AnimatorControllerParameter::get_type()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerParameter_get_type_mACEB110E346B27168F177E7A909CFB8586A2B966 (AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->___m_Type_1;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
// System.Boolean UnityEngine.AnimatorControllerParameter::Equals(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerParameter_Equals_m9FDC3900B8DB91E9F99295CADB9574F7E1C55C71 (AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* __this, RuntimeObject* ___0_o, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* V_0 = NULL;
	bool V_1 = false;
	int32_t G_B7_0 = 0;
	{
		RuntimeObject* L_0 = ___0_o;
		V_0 = ((AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02*)IsInstClass((RuntimeObject*)L_0, AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02_il2cpp_TypeInfo_var));
		AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* L_1 = V_0;
		if (!L_1)
		{
			goto IL_0058;
		}
	}
	{
		String_t* L_2 = __this->___m_Name_0;
		AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* L_3 = V_0;
		NullCheck(L_3);
		String_t* L_4 = L_3->___m_Name_0;
		bool L_5;
		L_5 = String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1(L_2, L_4, NULL);
		if (!L_5)
		{
			goto IL_0058;
		}
	}
	{
		int32_t L_6 = __this->___m_Type_1;
		AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* L_7 = V_0;
		NullCheck(L_7);
		int32_t L_8 = L_7->___m_Type_1;
		if ((!(((uint32_t)L_6) == ((uint32_t)L_8))))
		{
			goto IL_0058;
		}
	}
	{
		float L_9 = __this->___m_DefaultFloat_2;
		AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* L_10 = V_0;
		NullCheck(L_10);
		float L_11 = L_10->___m_DefaultFloat_2;
		if ((!(((float)L_9) == ((float)L_11))))
		{
			goto IL_0058;
		}
	}
	{
		int32_t L_12 = __this->___m_DefaultInt_3;
		AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* L_13 = V_0;
		NullCheck(L_13);
		int32_t L_14 = L_13->___m_DefaultInt_3;
		if ((!(((uint32_t)L_12) == ((uint32_t)L_14))))
		{
			goto IL_0058;
		}
	}
	{
		bool L_15 = __this->___m_DefaultBool_4;
		AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* L_16 = V_0;
		NullCheck(L_16);
		bool L_17 = L_16->___m_DefaultBool_4;
		G_B7_0 = ((((int32_t)L_15) == ((int32_t)L_17))? 1 : 0);
		goto IL_0059;
	}

IL_0058:
	{
		G_B7_0 = 0;
	}

IL_0059:
	{
		V_1 = (bool)G_B7_0;
		goto IL_005c;
	}

IL_005c:
	{
		bool L_18 = V_1;
		return L_18;
	}
}
// System.Int32 UnityEngine.AnimatorControllerParameter::GetHashCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerParameter_GetHashCode_m145EFDAFC4D2C410BB84F8290883977340E25312 (AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		String_t* L_0;
		L_0 = AnimatorControllerParameter_get_name_mEB3938ADDF296A0FB37283C987AEE6EC0F4F629E(__this, NULL);
		NullCheck(L_0);
		int32_t L_1;
		L_1 = VirtualFuncInvoker0< int32_t >::Invoke(2 /* System.Int32 System.Object::GetHashCode() */, L_0);
		V_0 = L_1;
		goto IL_000f;
	}

IL_000f:
	{
		int32_t L_2 = V_0;
		return L_2;
	}
}
// System.Void UnityEngine.AnimatorControllerParameter::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerParameter__ctor_m91C7057D6AC6D38ACA5EC852D5FDA829F83C8474 (AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	{
		__this->___m_Name_0 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_Name_0), (void*)_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.RuntimeAnimatorController::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RuntimeAnimatorController__ctor_m676D4538BB6C62314B256173C5F592EFCA16AAC8 (RuntimeAnimatorController_t6F7C753402B42EC23C163099CF935C5E0D7A7254* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		Object__ctor_m2149FA40CEC8D82AC20D3508AB40C0D8EFEF68E6(__this, NULL);
		return;
	}
}
// UnityEngine.AnimationClip[] UnityEngine.RuntimeAnimatorController::get_animationClips()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationClipU5BU5D_t48CE1A495BA95608745A065C735F2D5BB8DE5A0F* RuntimeAnimatorController_get_animationClips_mA8F51FF202C2C41A3E9C5366ABDEE35EDFBE8F93 (RuntimeAnimatorController_t6F7C753402B42EC23C163099CF935C5E0D7A7254* __this, const RuntimeMethod* method) 
{
	typedef AnimationClipU5BU5D_t48CE1A495BA95608745A065C735F2D5BB8DE5A0F* (*RuntimeAnimatorController_get_animationClips_mA8F51FF202C2C41A3E9C5366ABDEE35EDFBE8F93_ftn) (RuntimeAnimatorController_t6F7C753402B42EC23C163099CF935C5E0D7A7254*);
	static RuntimeAnimatorController_get_animationClips_mA8F51FF202C2C41A3E9C5366ABDEE35EDFBE8F93_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (RuntimeAnimatorController_get_animationClips_mA8F51FF202C2C41A3E9C5366ABDEE35EDFBE8F93_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.RuntimeAnimatorController::get_animationClips()");
	AnimationClipU5BU5D_t48CE1A495BA95608745A065C735F2D5BB8DE5A0F* icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Collections.IEnumerator UnityEngine.Animation::GetEnumerator()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Animation_GetEnumerator_m247062F212D9C579DAE25D9BC86E4921DC5719E6 (Animation_t6593B06C39E3B139808B19F2C719C860F3F61040* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_t81434F7D5603121F3D7BD6DB916FE1C755307530_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	{
		Enumerator_t81434F7D5603121F3D7BD6DB916FE1C755307530* L_0 = (Enumerator_t81434F7D5603121F3D7BD6DB916FE1C755307530*)il2cpp_codegen_object_new(Enumerator_t81434F7D5603121F3D7BD6DB916FE1C755307530_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		Enumerator__ctor_mF3FB66377864673B8DAF14A36DB6D069B98A92F4(L_0, __this, NULL);
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		RuntimeObject* L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.AnimationState UnityEngine.Animation::GetStateAtIndex(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationState_tC704F25A20169025B6CFDC2F00DC84152B5B73CE* Animation_GetStateAtIndex_mA06564CBB11021A3ADA69EA0BCDCD820183E240F (Animation_t6593B06C39E3B139808B19F2C719C860F3F61040* __this, int32_t ___0_index, const RuntimeMethod* method) 
{
	typedef AnimationState_tC704F25A20169025B6CFDC2F00DC84152B5B73CE* (*Animation_GetStateAtIndex_mA06564CBB11021A3ADA69EA0BCDCD820183E240F_ftn) (Animation_t6593B06C39E3B139808B19F2C719C860F3F61040*, int32_t);
	static Animation_GetStateAtIndex_mA06564CBB11021A3ADA69EA0BCDCD820183E240F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_GetStateAtIndex_mA06564CBB11021A3ADA69EA0BCDCD820183E240F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::GetStateAtIndex(System.Int32)");
	AnimationState_tC704F25A20169025B6CFDC2F00DC84152B5B73CE* icallRetVal = _il2cpp_icall_func(__this, ___0_index);
	return icallRetVal;
}
// System.Int32 UnityEngine.Animation::GetStateCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animation_GetStateCount_mB779E6750180C77CE5F2E81B78C9AFEE93FCB1FE (Animation_t6593B06C39E3B139808B19F2C719C860F3F61040* __this, const RuntimeMethod* method) 
{
	typedef int32_t (*Animation_GetStateCount_mB779E6750180C77CE5F2E81B78C9AFEE93FCB1FE_ftn) (Animation_t6593B06C39E3B139808B19F2C719C860F3F61040*);
	static Animation_GetStateCount_mB779E6750180C77CE5F2E81B78C9AFEE93FCB1FE_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_GetStateCount_mB779E6750180C77CE5F2E81B78C9AFEE93FCB1FE_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::GetStateCount()");
	int32_t icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Animation/Enumerator::.ctor(UnityEngine.Animation)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Enumerator__ctor_mF3FB66377864673B8DAF14A36DB6D069B98A92F4 (Enumerator_t81434F7D5603121F3D7BD6DB916FE1C755307530* __this, Animation_t6593B06C39E3B139808B19F2C719C860F3F61040* ___0_outer, const RuntimeMethod* method) 
{
	{
		__this->___m_CurrentIndex_1 = (-1);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		Animation_t6593B06C39E3B139808B19F2C719C860F3F61040* L_0 = ___0_outer;
		__this->___m_Outer_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_Outer_0), (void*)L_0);
		return;
	}
}
// System.Object UnityEngine.Animation/Enumerator::get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Enumerator_get_Current_m4A17FE0020D4C8856EFC8EF531B99723FFB2B9DF (Enumerator_t81434F7D5603121F3D7BD6DB916FE1C755307530* __this, const RuntimeMethod* method) 
{
	RuntimeObject* V_0 = NULL;
	{
		Animation_t6593B06C39E3B139808B19F2C719C860F3F61040* L_0 = __this->___m_Outer_0;
		int32_t L_1 = __this->___m_CurrentIndex_1;
		NullCheck(L_0);
		AnimationState_tC704F25A20169025B6CFDC2F00DC84152B5B73CE* L_2;
		L_2 = Animation_GetStateAtIndex_mA06564CBB11021A3ADA69EA0BCDCD820183E240F(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0015;
	}

IL_0015:
	{
		RuntimeObject* L_3 = V_0;
		return L_3;
	}
}
// System.Boolean UnityEngine.Animation/Enumerator::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_m82477C155D4F7CF98317C0EEC9F5070D196AA671 (Enumerator_t81434F7D5603121F3D7BD6DB916FE1C755307530* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	bool V_1 = false;
	{
		Animation_t6593B06C39E3B139808B19F2C719C860F3F61040* L_0 = __this->___m_Outer_0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = Animation_GetStateCount_mB779E6750180C77CE5F2E81B78C9AFEE93FCB1FE(L_0, NULL);
		V_0 = L_1;
		int32_t L_2 = __this->___m_CurrentIndex_1;
		__this->___m_CurrentIndex_1 = ((int32_t)il2cpp_codegen_add(L_2, 1));
		int32_t L_3 = __this->___m_CurrentIndex_1;
		int32_t L_4 = V_0;
		V_1 = (bool)((((int32_t)L_3) < ((int32_t)L_4))? 1 : 0);
		goto IL_0027;
	}

IL_0027:
	{
		bool L_5 = V_1;
		return L_5;
	}
}
// System.Void UnityEngine.Animation/Enumerator::Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Enumerator_Reset_m687381C45ECBBD052447FAC06ECE9760FF23DA63 (Enumerator_t81434F7D5603121F3D7BD6DB916FE1C755307530* __this, const RuntimeMethod* method) 
{
	{
		__this->___m_CurrentIndex_1 = (-1);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.AnimationState::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationState__ctor_mB18C82530ADA40EE3BC245AAB0673941D78B779E (AnimationState_tC704F25A20169025B6CFDC2F00DC84152B5B73CE* __this, const RuntimeMethod* method) 
{
	{
		TrackedReference__ctor_m0E498FD0AD5807B7B91CB0005170E522DAE3616A(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif


// Conversion methods for marshalling of: UnityEngine.AnimationEvent
IL2CPP_EXTERN_C void AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174_marshal_pinvoke(const AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174& unmarshaled, AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174_marshaled_pinvoke& marshaled)
{
	Exception_t* ___m_StateSender_8Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_StateSender' of type 'AnimationEvent': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_StateSender_8Exception, NULL);
}
IL2CPP_EXTERN_C void AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174_marshal_pinvoke_back(const AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174_marshaled_pinvoke& marshaled, AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174& unmarshaled)
{
	Exception_t* ___m_StateSender_8Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_StateSender' of type 'AnimationEvent': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_StateSender_8Exception, NULL);
}
// Conversion method for clean up from marshalling of: UnityEngine.AnimationEvent
IL2CPP_EXTERN_C void AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174_marshal_pinvoke_cleanup(AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174_marshaled_pinvoke& marshaled)
{
}


// Conversion methods for marshalling of: UnityEngine.AnimationEvent
IL2CPP_EXTERN_C void AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174_marshal_com(const AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174& unmarshaled, AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174_marshaled_com& marshaled)
{
	Exception_t* ___m_StateSender_8Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_StateSender' of type 'AnimationEvent': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_StateSender_8Exception, NULL);
}
IL2CPP_EXTERN_C void AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174_marshal_com_back(const AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174_marshaled_com& marshaled, AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174& unmarshaled)
{
	Exception_t* ___m_StateSender_8Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_StateSender' of type 'AnimationEvent': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_StateSender_8Exception, NULL);
}
// Conversion method for clean up from marshalling of: UnityEngine.AnimationEvent
IL2CPP_EXTERN_C void AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174_marshal_com_cleanup(AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174_marshaled_com& marshaled)
{
}
// System.Void UnityEngine.AnimationEvent::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationEvent__ctor_mBC954085B1D18B436D08E7ADE3458B91E208F3B2 (AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		__this->___m_Time_0 = (0.0f);
		__this->___m_FunctionName_1 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_FunctionName_1), (void*)_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		__this->___m_StringParameter_2 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_StringParameter_2), (void*)_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		__this->___m_ObjectReferenceParameter_3 = (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_ObjectReferenceParameter_3), (void*)(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL);
		__this->___m_FloatParameter_4 = (0.0f);
		__this->___m_IntParameter_5 = 0;
		__this->___m_MessageOptions_6 = 0;
		__this->___m_Source_7 = 0;
		__this->___m_StateSender_8 = (AnimationState_tC704F25A20169025B6CFDC2F00DC84152B5B73CE*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_StateSender_8), (void*)(AnimationState_tC704F25A20169025B6CFDC2F00DC84152B5B73CE*)NULL);
		return;
	}
}
// System.Single UnityEngine.AnimationEvent::get_floatParameter()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimationEvent_get_floatParameter_m00CC143874DF66921808693FE6E56D27AAC07642 (AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174* __this, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->___m_FloatParameter_4;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		float L_1 = V_0;
		return L_1;
	}
}
// System.String UnityEngine.AnimationEvent::get_functionName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AnimationEvent_get_functionName_m717A4770DD98BEFF7F64E56C55B0712BD13F479B (AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174* __this, const RuntimeMethod* method) 
{
	String_t* V_0 = NULL;
	{
		String_t* L_0 = __this->___m_FunctionName_1;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		String_t* L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.SendMessageOptions UnityEngine.AnimationEvent::get_messageOptions()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimationEvent_get_messageOptions_m9E350CE3BBE883207A5B7B658F0339DB99737B97 (AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->___m_MessageOptions_6;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
// System.Boolean UnityEngine.AnimationEvent::get_isFiredByAnimator()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationEvent_get_isFiredByAnimator_m933B34D40A0B7781D943D77731D93A6D6A334AD3 (AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174* __this, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		int32_t L_0 = __this->___m_Source_7;
		V_0 = (bool)((((int32_t)L_0) == ((int32_t)2))? 1 : 0);
		goto IL_000d;
	}

IL_000d:
	{
		bool L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.AnimatorClipInfo UnityEngine.AnimationEvent::get_animatorClipInfo()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03 AnimationEvent_get_animatorClipInfo_m0D763FA1A2E3CD81AC08F1F24977859AE25938F3 (AnimationEvent_t77294DB2372A5C387B53EEA3EFDC550C75EC3174* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB2969BA8505A612F4D5D731D20ECF63F6A6793A6);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03 V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		bool L_0;
		L_0 = AnimationEvent_get_isFiredByAnimator_m933B34D40A0B7781D943D77731D93A6D6A334AD3(__this, NULL);
		V_0 = (bool)((((int32_t)L_0) == ((int32_t)0))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0019;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2(_stringLiteralB2969BA8505A612F4D5D731D20ECF63F6A6793A6, NULL);
	}

IL_0019:
	{
		AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03 L_2 = __this->___m_AnimatorClipInfo_10;
		V_1 = L_2;
		goto IL_0022;
	}

IL_0022:
	{
		AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03 L_3 = V_1;
		return L_3;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Motion::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Motion__ctor_mB6190858E566BFA1B80D2E94B65CD27920A49443 (Motion_tBCD49FBF5608AD21FC03B63C8182FABCEF2707AC* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		Object__ctor_m2149FA40CEC8D82AC20D3508AB40C0D8EFEF68E6(__this, NULL);
		return;
	}
}
// System.Single UnityEngine.Motion::get_averageAngularSpeed()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Motion_get_averageAngularSpeed_m5167326516C36DFDF57F80CDE104054DD4957D74 (Motion_tBCD49FBF5608AD21FC03B63C8182FABCEF2707AC* __this, const RuntimeMethod* method) 
{
	typedef float (*Motion_get_averageAngularSpeed_m5167326516C36DFDF57F80CDE104054DD4957D74_ftn) (Motion_tBCD49FBF5608AD21FC03B63C8182FABCEF2707AC*);
	static Motion_get_averageAngularSpeed_m5167326516C36DFDF57F80CDE104054DD4957D74_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Motion_get_averageAngularSpeed_m5167326516C36DFDF57F80CDE104054DD4957D74_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Motion::get_averageAngularSpeed()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// UnityEngine.Vector3 UnityEngine.Motion::get_averageSpeed()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Motion_get_averageSpeed_m76C239071A90E7E2CAFD34BCBAA5F15FC209C148 (Motion_tBCD49FBF5608AD21FC03B63C8182FABCEF2707AC* __this, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Motion_get_averageSpeed_Injected_m11BC2AAEBABFC331969F355305A413277D8C1533(__this, (&V_0), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = V_0;
		return L_0;
	}
}
// System.Boolean UnityEngine.Motion::get_isLooping()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Motion_get_isLooping_mD11B7C5FFEC7BC2BC5D2AB4D3B2A06D2959DFB99 (Motion_tBCD49FBF5608AD21FC03B63C8182FABCEF2707AC* __this, const RuntimeMethod* method) 
{
	typedef bool (*Motion_get_isLooping_mD11B7C5FFEC7BC2BC5D2AB4D3B2A06D2959DFB99_ftn) (Motion_tBCD49FBF5608AD21FC03B63C8182FABCEF2707AC*);
	static Motion_get_isLooping_mD11B7C5FFEC7BC2BC5D2AB4D3B2A06D2959DFB99_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Motion_get_isLooping_mD11B7C5FFEC7BC2BC5D2AB4D3B2A06D2959DFB99_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Motion::get_isLooping()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Motion::get_averageSpeed_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Motion_get_averageSpeed_Injected_m11BC2AAEBABFC331969F355305A413277D8C1533 (Motion_tBCD49FBF5608AD21FC03B63C8182FABCEF2707AC* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_ret, const RuntimeMethod* method) 
{
	typedef void (*Motion_get_averageSpeed_Injected_m11BC2AAEBABFC331969F355305A413277D8C1533_ftn) (Motion_tBCD49FBF5608AD21FC03B63C8182FABCEF2707AC*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*);
	static Motion_get_averageSpeed_Injected_m11BC2AAEBABFC331969F355305A413277D8C1533_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Motion_get_averageSpeed_Injected_m11BC2AAEBABFC331969F355305A413277D8C1533_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Motion::get_averageSpeed_Injected(UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___0_ret);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Int32 UnityEngine.HumanTrait::GetBoneIndexFromMono(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t HumanTrait_GetBoneIndexFromMono_mDE16E21275A55D263014CFD3307BEB7353AE6925 (int32_t ___0_humanId, const RuntimeMethod* method) 
{
	typedef int32_t (*HumanTrait_GetBoneIndexFromMono_mDE16E21275A55D263014CFD3307BEB7353AE6925_ftn) (int32_t);
	static HumanTrait_GetBoneIndexFromMono_mDE16E21275A55D263014CFD3307BEB7353AE6925_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (HumanTrait_GetBoneIndexFromMono_mDE16E21275A55D263014CFD3307BEB7353AE6925_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.HumanTrait::GetBoneIndexFromMono(System.Int32)");
	int32_t icallRetVal = _il2cpp_icall_func(___0_humanId);
	return icallRetVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.AnimationClip UnityEngine.AnimatorClipInfo::get_clip()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* AnimatorClipInfo_get_clip_m6205DB403EBEAEAC14DB8928FFC7EBC50142E1AC (AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03* __this, const RuntimeMethod* method) 
{
	AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* V_0 = NULL;
	AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* G_B3_0 = NULL;
	{
		int32_t L_0 = __this->___m_ClipInstanceID_0;
		if (L_0)
		{
			goto IL_000c;
		}
	}
	{
		G_B3_0 = ((AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712*)(NULL));
		goto IL_0017;
	}

IL_000c:
	{
		int32_t L_1 = __this->___m_ClipInstanceID_0;
		AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* L_2;
		L_2 = AnimatorClipInfo_InstanceIDToAnimationClipPPtr_mF656EAD29AB800127963F8A663F260E89EBF2CEC(L_1, NULL);
		G_B3_0 = L_2;
	}

IL_0017:
	{
		V_0 = G_B3_0;
		goto IL_001a;
	}

IL_001a:
	{
		AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* AnimatorClipInfo_get_clip_m6205DB403EBEAEAC14DB8928FFC7EBC50142E1AC_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03*>(__this + _offset);
	AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* _returnValue;
	_returnValue = AnimatorClipInfo_get_clip_m6205DB403EBEAEAC14DB8928FFC7EBC50142E1AC(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.AnimatorClipInfo::get_weight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorClipInfo_get_weight_m1CC29E2C37B30993EFFD12161059E4AD86EE287D (AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03* __this, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->___m_Weight_1;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		float L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  float AnimatorClipInfo_get_weight_m1CC29E2C37B30993EFFD12161059E4AD86EE287D_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorClipInfo_t0C913173594C893E36282602F54ABD06AC1CFA03*>(__this + _offset);
	float _returnValue;
	_returnValue = AnimatorClipInfo_get_weight_m1CC29E2C37B30993EFFD12161059E4AD86EE287D(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.AnimationClip UnityEngine.AnimatorClipInfo::InstanceIDToAnimationClipPPtr(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* AnimatorClipInfo_InstanceIDToAnimationClipPPtr_mF656EAD29AB800127963F8A663F260E89EBF2CEC (int32_t ___0_instanceID, const RuntimeMethod* method) 
{
	typedef AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* (*AnimatorClipInfo_InstanceIDToAnimationClipPPtr_mF656EAD29AB800127963F8A663F260E89EBF2CEC_ftn) (int32_t);
	static AnimatorClipInfo_InstanceIDToAnimationClipPPtr_mF656EAD29AB800127963F8A663F260E89EBF2CEC_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorClipInfo_InstanceIDToAnimationClipPPtr_mF656EAD29AB800127963F8A663F260E89EBF2CEC_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimatorClipInfo::InstanceIDToAnimationClipPPtr(System.Int32)");
	AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* icallRetVal = _il2cpp_icall_func(___0_instanceID);
	return icallRetVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Int32 UnityEngine.AnimatorStateInfo::get_fullPathHash()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorStateInfo_get_fullPathHash_m583FA8FAAC28BF65A65166D100949833E515210F (AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->___m_FullPath_2;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  int32_t AnimatorStateInfo_get_fullPathHash_m583FA8FAAC28BF65A65166D100949833E515210F_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = AnimatorStateInfo_get_fullPathHash_m583FA8FAAC28BF65A65166D100949833E515210F(_thisAdjusted, method);
	return _returnValue;
}
// System.Int32 UnityEngine.AnimatorStateInfo::get_shortNameHash()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorStateInfo_get_shortNameHash_mEE816B999C282A3BA95AFC64278B994E899B7004 (AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->___m_Name_0;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  int32_t AnimatorStateInfo_get_shortNameHash_mEE816B999C282A3BA95AFC64278B994E899B7004_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = AnimatorStateInfo_get_shortNameHash_mEE816B999C282A3BA95AFC64278B994E899B7004(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.AnimatorStateInfo::get_normalizedTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorStateInfo_get_normalizedTime_m087C7E5A72122ADF18EBB4AC8391103B9119CCC6 (AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* __this, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->___m_NormalizedTime_3;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		float L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  float AnimatorStateInfo_get_normalizedTime_m087C7E5A72122ADF18EBB4AC8391103B9119CCC6_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2*>(__this + _offset);
	float _returnValue;
	_returnValue = AnimatorStateInfo_get_normalizedTime_m087C7E5A72122ADF18EBB4AC8391103B9119CCC6(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.AnimatorStateInfo::get_length()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorStateInfo_get_length_m2FAE317264F7C796427207F8F28E550DB49F9541 (AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* __this, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->___m_Length_4;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		float L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  float AnimatorStateInfo_get_length_m2FAE317264F7C796427207F8F28E550DB49F9541_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2*>(__this + _offset);
	float _returnValue;
	_returnValue = AnimatorStateInfo_get_length_m2FAE317264F7C796427207F8F28E550DB49F9541(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.AnimatorStateInfo::get_speed()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorStateInfo_get_speed_m473826E53D827AEE36A7FF0662AC4817C2EF3495 (AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* __this, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->___m_Speed_5;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		float L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  float AnimatorStateInfo_get_speed_m473826E53D827AEE36A7FF0662AC4817C2EF3495_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2*>(__this + _offset);
	float _returnValue;
	_returnValue = AnimatorStateInfo_get_speed_m473826E53D827AEE36A7FF0662AC4817C2EF3495(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.AnimatorStateInfo::get_speedMultiplier()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorStateInfo_get_speedMultiplier_mA078AADECC98C266C82E2756A351235DDC63A107 (AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* __this, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->___m_SpeedMultiplier_6;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		float L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  float AnimatorStateInfo_get_speedMultiplier_mA078AADECC98C266C82E2756A351235DDC63A107_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2*>(__this + _offset);
	float _returnValue;
	_returnValue = AnimatorStateInfo_get_speedMultiplier_mA078AADECC98C266C82E2756A351235DDC63A107(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.AnimatorStateInfo::get_loop()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorStateInfo_get_loop_m3DC728FC9AF0D4B27B3C28157395BB2F57CC3DA7 (AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* __this, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		int32_t L_0 = __this->___m_Loop_8;
		V_0 = (bool)((!(((uint32_t)L_0) <= ((uint32_t)0)))? 1 : 0);
		goto IL_000d;
	}

IL_000d:
	{
		bool L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  bool AnimatorStateInfo_get_loop_m3DC728FC9AF0D4B27B3C28157395BB2F57CC3DA7_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2*>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimatorStateInfo_get_loop_m3DC728FC9AF0D4B27B3C28157395BB2F57CC3DA7(_thisAdjusted, method);
	return _returnValue;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: UnityEngine.AnimatorTransitionInfo
IL2CPP_EXTERN_C void AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD_marshal_pinvoke(const AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD& unmarshaled, AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD_marshaled_pinvoke& marshaled)
{
	marshaled.___m_FullPath_0 = unmarshaled.___m_FullPath_0;
	marshaled.___m_UserName_1 = unmarshaled.___m_UserName_1;
	marshaled.___m_Name_2 = unmarshaled.___m_Name_2;
	marshaled.___m_HasFixedDuration_3 = static_cast<int32_t>(unmarshaled.___m_HasFixedDuration_3);
	marshaled.___m_Duration_4 = unmarshaled.___m_Duration_4;
	marshaled.___m_NormalizedTime_5 = unmarshaled.___m_NormalizedTime_5;
	marshaled.___m_AnyState_6 = static_cast<int32_t>(unmarshaled.___m_AnyState_6);
	marshaled.___m_TransitionType_7 = unmarshaled.___m_TransitionType_7;
}
IL2CPP_EXTERN_C void AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD_marshal_pinvoke_back(const AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD_marshaled_pinvoke& marshaled, AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD& unmarshaled)
{
	int32_t unmarshaledm_FullPath_temp_0 = 0;
	unmarshaledm_FullPath_temp_0 = marshaled.___m_FullPath_0;
	unmarshaled.___m_FullPath_0 = unmarshaledm_FullPath_temp_0;
	int32_t unmarshaledm_UserName_temp_1 = 0;
	unmarshaledm_UserName_temp_1 = marshaled.___m_UserName_1;
	unmarshaled.___m_UserName_1 = unmarshaledm_UserName_temp_1;
	int32_t unmarshaledm_Name_temp_2 = 0;
	unmarshaledm_Name_temp_2 = marshaled.___m_Name_2;
	unmarshaled.___m_Name_2 = unmarshaledm_Name_temp_2;
	bool unmarshaledm_HasFixedDuration_temp_3 = false;
	unmarshaledm_HasFixedDuration_temp_3 = static_cast<bool>(marshaled.___m_HasFixedDuration_3);
	unmarshaled.___m_HasFixedDuration_3 = unmarshaledm_HasFixedDuration_temp_3;
	float unmarshaledm_Duration_temp_4 = 0.0f;
	unmarshaledm_Duration_temp_4 = marshaled.___m_Duration_4;
	unmarshaled.___m_Duration_4 = unmarshaledm_Duration_temp_4;
	float unmarshaledm_NormalizedTime_temp_5 = 0.0f;
	unmarshaledm_NormalizedTime_temp_5 = marshaled.___m_NormalizedTime_5;
	unmarshaled.___m_NormalizedTime_5 = unmarshaledm_NormalizedTime_temp_5;
	bool unmarshaledm_AnyState_temp_6 = false;
	unmarshaledm_AnyState_temp_6 = static_cast<bool>(marshaled.___m_AnyState_6);
	unmarshaled.___m_AnyState_6 = unmarshaledm_AnyState_temp_6;
	int32_t unmarshaledm_TransitionType_temp_7 = 0;
	unmarshaledm_TransitionType_temp_7 = marshaled.___m_TransitionType_7;
	unmarshaled.___m_TransitionType_7 = unmarshaledm_TransitionType_temp_7;
}
// Conversion method for clean up from marshalling of: UnityEngine.AnimatorTransitionInfo
IL2CPP_EXTERN_C void AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD_marshal_pinvoke_cleanup(AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: UnityEngine.AnimatorTransitionInfo
IL2CPP_EXTERN_C void AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD_marshal_com(const AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD& unmarshaled, AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD_marshaled_com& marshaled)
{
	marshaled.___m_FullPath_0 = unmarshaled.___m_FullPath_0;
	marshaled.___m_UserName_1 = unmarshaled.___m_UserName_1;
	marshaled.___m_Name_2 = unmarshaled.___m_Name_2;
	marshaled.___m_HasFixedDuration_3 = static_cast<int32_t>(unmarshaled.___m_HasFixedDuration_3);
	marshaled.___m_Duration_4 = unmarshaled.___m_Duration_4;
	marshaled.___m_NormalizedTime_5 = unmarshaled.___m_NormalizedTime_5;
	marshaled.___m_AnyState_6 = static_cast<int32_t>(unmarshaled.___m_AnyState_6);
	marshaled.___m_TransitionType_7 = unmarshaled.___m_TransitionType_7;
}
IL2CPP_EXTERN_C void AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD_marshal_com_back(const AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD_marshaled_com& marshaled, AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD& unmarshaled)
{
	int32_t unmarshaledm_FullPath_temp_0 = 0;
	unmarshaledm_FullPath_temp_0 = marshaled.___m_FullPath_0;
	unmarshaled.___m_FullPath_0 = unmarshaledm_FullPath_temp_0;
	int32_t unmarshaledm_UserName_temp_1 = 0;
	unmarshaledm_UserName_temp_1 = marshaled.___m_UserName_1;
	unmarshaled.___m_UserName_1 = unmarshaledm_UserName_temp_1;
	int32_t unmarshaledm_Name_temp_2 = 0;
	unmarshaledm_Name_temp_2 = marshaled.___m_Name_2;
	unmarshaled.___m_Name_2 = unmarshaledm_Name_temp_2;
	bool unmarshaledm_HasFixedDuration_temp_3 = false;
	unmarshaledm_HasFixedDuration_temp_3 = static_cast<bool>(marshaled.___m_HasFixedDuration_3);
	unmarshaled.___m_HasFixedDuration_3 = unmarshaledm_HasFixedDuration_temp_3;
	float unmarshaledm_Duration_temp_4 = 0.0f;
	unmarshaledm_Duration_temp_4 = marshaled.___m_Duration_4;
	unmarshaled.___m_Duration_4 = unmarshaledm_Duration_temp_4;
	float unmarshaledm_NormalizedTime_temp_5 = 0.0f;
	unmarshaledm_NormalizedTime_temp_5 = marshaled.___m_NormalizedTime_5;
	unmarshaled.___m_NormalizedTime_5 = unmarshaledm_NormalizedTime_temp_5;
	bool unmarshaledm_AnyState_temp_6 = false;
	unmarshaledm_AnyState_temp_6 = static_cast<bool>(marshaled.___m_AnyState_6);
	unmarshaled.___m_AnyState_6 = unmarshaledm_AnyState_temp_6;
	int32_t unmarshaledm_TransitionType_temp_7 = 0;
	unmarshaledm_TransitionType_temp_7 = marshaled.___m_TransitionType_7;
	unmarshaled.___m_TransitionType_7 = unmarshaledm_TransitionType_temp_7;
}
// Conversion method for clean up from marshalling of: UnityEngine.AnimatorTransitionInfo
IL2CPP_EXTERN_C void AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD_marshal_com_cleanup(AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD_marshaled_com& marshaled)
{
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Boolean UnityEngine.Animator::get_isHuman()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_isHuman_mE1154471F516DA8BB47B0605410640344028E2A0 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) 
{
	typedef bool (*Animator_get_isHuman_mE1154471F516DA8BB47B0605410640344028E2A0_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*);
	static Animator_get_isHuman_mE1154471F516DA8BB47B0605410640344028E2A0_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_isHuman_mE1154471F516DA8BB47B0605410640344028E2A0_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_isHuman()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.Animator::get_hasRootMotion()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_hasRootMotion_mA39728839F19F4E103CF2599281E6F796D2AB341 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) 
{
	typedef bool (*Animator_get_hasRootMotion_mA39728839F19F4E103CF2599281E6F796D2AB341_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*);
	static Animator_get_hasRootMotion_mA39728839F19F4E103CF2599281E6F796D2AB341_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_hasRootMotion_mA39728839F19F4E103CF2599281E6F796D2AB341_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_hasRootMotion()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Single UnityEngine.Animator::GetFloat(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetFloat_mEFA968AD9EEB92E6A03AEEB968600798E61F9B1D (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	{
		int32_t L_0 = ___0_id;
		float L_1;
		L_1 = Animator_GetFloatID_m0300DB1901B65F007EA9E0E98ACB91E105FDD366(__this, L_0, NULL);
		V_0 = L_1;
		goto IL_000b;
	}

IL_000b:
	{
		float L_2 = V_0;
		return L_2;
	}
}
// System.Void UnityEngine.Animator::SetFloat(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetFloat_m10C78733FAFC7AFEDBDACC48B7C66D3A35A0A7FE (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, String_t* ___0_name, float ___1_value, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = ___0_name;
		float L_1 = ___1_value;
		Animator_SetFloatString_m1AA50083AAAE1DFFA7FB64502EA106795D3756B4(__this, L_0, L_1, NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetFloat(System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetFloat_m2CDA219BBAB214F4069C9844780EBCE6CCF579F5 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, float ___1_value, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = ___0_id;
		float L_1 = ___1_value;
		Animator_SetFloatID_m348942A23D4C734DDF4D04C7609E5CD9EBAB66AA(__this, L_0, L_1, NULL);
		return;
	}
}
// System.Boolean UnityEngine.Animator::GetBool(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_GetBool_mFEC9C0565C52965FBD5D6A02084484F00F8ECE2C (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		int32_t L_0 = ___0_id;
		bool L_1;
		L_1 = Animator_GetBoolID_mD88CBA007AB7C968BF526B518E90F90E0935A9DD(__this, L_0, NULL);
		V_0 = L_1;
		goto IL_000b;
	}

IL_000b:
	{
		bool L_2 = V_0;
		return L_2;
	}
}
// System.Void UnityEngine.Animator::SetBool(System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetBool_m6F8D4FAF0770CD4EC1F54406249785DE7391E42B (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, String_t* ___0_name, bool ___1_value, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = ___0_name;
		bool L_1 = ___1_value;
		Animator_SetBoolString_m08A0BC6717BF5FD3E43D3EFB2509E359C1196C00(__this, L_0, L_1, NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetBool(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetBool_m1DD34A313E6882B6FBF379A53DD8D52E4023F1D8 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, bool ___1_value, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = ___0_id;
		bool L_1 = ___1_value;
		Animator_SetBoolID_mCDA31E47A1AA78E830D0B76394BE2FA7296E03BE(__this, L_0, L_1, NULL);
		return;
	}
}
// System.Int32 UnityEngine.Animator::GetInteger(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_GetInteger_mF4E1564D3791C968FA8952954B5AAC4C4E2C8B91 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = ___0_id;
		int32_t L_1;
		L_1 = Animator_GetIntegerID_mCAC9F61639DAF52DD2DE8891DB8A2F7FE5C3DF4A(__this, L_0, NULL);
		V_0 = L_1;
		goto IL_000b;
	}

IL_000b:
	{
		int32_t L_2 = V_0;
		return L_2;
	}
}
// System.Void UnityEngine.Animator::SetInteger(System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetInteger_m7B4BB5FD5BD8DE3F713D8E9AD2870C1AAF8E19EF (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, String_t* ___0_name, int32_t ___1_value, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = ___0_name;
		int32_t L_1 = ___1_value;
		Animator_SetIntegerString_m3080217346B85D69FA5A99B2ABC64BF5E4580455(__this, L_0, L_1, NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetInteger(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetInteger_mE823EC7492A7FB266FA723C168226D17085DF3E8 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, int32_t ___1_value, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = ___0_id;
		int32_t L_1 = ___1_value;
		Animator_SetIntegerID_m08431A06E5905C62BA397B9BAB30F87E3C30569F(__this, L_0, L_1, NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetTrigger(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetTrigger_mC9CD54D627C8843EF6E159E167449D216EF6EB30 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, String_t* ___0_name, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = ___0_name;
		Animator_SetTriggerString_m177C75DFBE070DE66FC08A3232444CCEA409C25E(__this, L_0, NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetTrigger(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetTrigger_m2D9CACEFDE11FF9DB99207B5CBD251C1EC047939 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = ___0_id;
		Animator_SetTriggerID_mCC0A74BF79A56BC1EA634641C64B8E527B0B49E7(__this, L_0, NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::ResetTrigger(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_ResetTrigger_m8DCA67D5A6B56702E3FAD4E18243E194B71297CC (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, String_t* ___0_name, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = ___0_name;
		Animator_ResetTriggerString_m78259348CED35F156148A64B95EBD73CE3951868(__this, L_0, NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::ResetTrigger(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_ResetTrigger_m2DF2C6DE87314918C151616FD5C39EB93EE14011 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = ___0_id;
		Animator_ResetTriggerID_mD3E0C24AC862F049622D09933E7A3A2CDE256C13(__this, L_0, NULL);
		return;
	}
}
// UnityEngine.Vector3 UnityEngine.Animator::get_deltaPosition()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Animator_get_deltaPosition_m1759DB2D343FDAFAA7FE85ED66451D5210B0A606 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Animator_get_deltaPosition_Injected_mF37497B00055319EE54006C19AAEE221A99791F4(__this, (&V_0), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = V_0;
		return L_0;
	}
}
// UnityEngine.Quaternion UnityEngine.Animator::get_deltaRotation()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 Animator_get_deltaRotation_m54839D596F81D477E91E2746E4141AB389238FFD (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) 
{
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Animator_get_deltaRotation_Injected_mFEC802815227FE4B11491F80B281425A10E19ABD(__this, (&V_0), NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_0 = V_0;
		return L_0;
	}
}
// System.Boolean UnityEngine.Animator::get_applyRootMotion()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_applyRootMotion_mC8C4D583F86A9E0B1BF395BBFFAACACD496EDBB8 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) 
{
	typedef bool (*Animator_get_applyRootMotion_mC8C4D583F86A9E0B1BF395BBFFAACACD496EDBB8_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*);
	static Animator_get_applyRootMotion_mC8C4D583F86A9E0B1BF395BBFFAACACD496EDBB8_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_applyRootMotion_mC8C4D583F86A9E0B1BF395BBFFAACACD496EDBB8_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_applyRootMotion()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::set_applyRootMotion(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_applyRootMotion_mA0953B6AEE43D4AF0837365E7BFF60FCC74B0F98 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, bool ___0_value, const RuntimeMethod* method) 
{
	typedef void (*Animator_set_applyRootMotion_mA0953B6AEE43D4AF0837365E7BFF60FCC74B0F98_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, bool);
	static Animator_set_applyRootMotion_mA0953B6AEE43D4AF0837365E7BFF60FCC74B0F98_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_applyRootMotion_mA0953B6AEE43D4AF0837365E7BFF60FCC74B0F98_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_applyRootMotion(System.Boolean)");
	_il2cpp_icall_func(__this, ___0_value);
}
// UnityEngine.AnimatorUpdateMode UnityEngine.Animator::get_updateMode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_get_updateMode_m63C8A41D5D0F214FB5CF554B69CFBBEB6EE141DB (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) 
{
	typedef int32_t (*Animator_get_updateMode_m63C8A41D5D0F214FB5CF554B69CFBBEB6EE141DB_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*);
	static Animator_get_updateMode_m63C8A41D5D0F214FB5CF554B69CFBBEB6EE141DB_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_updateMode_m63C8A41D5D0F214FB5CF554B69CFBBEB6EE141DB_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_updateMode()");
	int32_t icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::set_updateMode(UnityEngine.AnimatorUpdateMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_updateMode_mA21CC888FEEBC5A06099E5D33A6C7ACCC266B056 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_value, const RuntimeMethod* method) 
{
	typedef void (*Animator_set_updateMode_mA21CC888FEEBC5A06099E5D33A6C7ACCC266B056_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, int32_t);
	static Animator_set_updateMode_mA21CC888FEEBC5A06099E5D33A6C7ACCC266B056_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_updateMode_mA21CC888FEEBC5A06099E5D33A6C7ACCC266B056_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_updateMode(UnityEngine.AnimatorUpdateMode)");
	_il2cpp_icall_func(__this, ___0_value);
}
// System.Void UnityEngine.Animator::set_bodyPosition(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_bodyPosition_m7CFDA1C974A11D5BFC52181879A25FA8AEAFFC61 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_value, const RuntimeMethod* method) 
{
	{
		Animator_CheckIfInIKPass_mE7815990AFAD02738D0D5B4DA8DDB3E649D30CCF(__this, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_value;
		Animator_set_bodyPositionInternal_m6042D23A6CC550D438B4522C4755BD08692D2F1A(__this, L_0, NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::set_bodyPositionInternal(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_bodyPositionInternal_m6042D23A6CC550D438B4522C4755BD08692D2F1A (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_value, const RuntimeMethod* method) 
{
	{
		Animator_set_bodyPositionInternal_Injected_m434A0C848EF277237CBAA68C4A94A1DD4A05DC75(__this, (&___0_value), NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::set_bodyRotation(UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_bodyRotation_m8763282BEFDD626963D985435E3BC3FE576E27BC (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___0_value, const RuntimeMethod* method) 
{
	{
		Animator_CheckIfInIKPass_mE7815990AFAD02738D0D5B4DA8DDB3E649D30CCF(__this, NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_0 = ___0_value;
		Animator_set_bodyRotationInternal_mA381F771D03290AF383D3203071D9B04746BD2E6(__this, L_0, NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::set_bodyRotationInternal(UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_bodyRotationInternal_mA381F771D03290AF383D3203071D9B04746BD2E6 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___0_value, const RuntimeMethod* method) 
{
	{
		Animator_set_bodyRotationInternal_Injected_m0BDC67195DA58582AEFC3567906106BD96C1D173(__this, (&___0_value), NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetIKPosition(UnityEngine.AvatarIKGoal,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetIKPosition_mB7BE88C93990186D94AF75439E2F216D6ECBCDEE (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_goal, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_goalPosition, const RuntimeMethod* method) 
{
	{
		Animator_CheckIfInIKPass_mE7815990AFAD02738D0D5B4DA8DDB3E649D30CCF(__this, NULL);
		int32_t L_0 = ___0_goal;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = ___1_goalPosition;
		Animator_SetGoalPosition_m0811DE827A66638ECA79A2BAA6A59D9D21D7D5A2(__this, L_0, L_1, NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetGoalPosition(UnityEngine.AvatarIKGoal,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalPosition_m0811DE827A66638ECA79A2BAA6A59D9D21D7D5A2 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_goal, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_goalPosition, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = ___0_goal;
		Animator_SetGoalPosition_Injected_mE03B76DB578A3B15ED91437071BEF70F61985707(__this, L_0, (&___1_goalPosition), NULL);
		return;
	}
}
// UnityEngine.Quaternion UnityEngine.Animator::GetIKRotation(UnityEngine.AvatarIKGoal)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 Animator_GetIKRotation_mF2969E5FBD59C125EF95AB689A9B3AAB434F79FC (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_goal, const RuntimeMethod* method) 
{
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Animator_CheckIfInIKPass_mE7815990AFAD02738D0D5B4DA8DDB3E649D30CCF(__this, NULL);
		int32_t L_0 = ___0_goal;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_1;
		L_1 = Animator_GetGoalRotation_mB7B67DE4EBA3C26D713754D1D76D4F529E783DB2(__this, L_0, NULL);
		V_0 = L_1;
		goto IL_0012;
	}

IL_0012:
	{
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_2 = V_0;
		return L_2;
	}
}
// UnityEngine.Quaternion UnityEngine.Animator::GetGoalRotation(UnityEngine.AvatarIKGoal)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 Animator_GetGoalRotation_mB7B67DE4EBA3C26D713754D1D76D4F529E783DB2 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_goal, const RuntimeMethod* method) 
{
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		int32_t L_0 = ___0_goal;
		Animator_GetGoalRotation_Injected_m76092248C853479A1E6178DA4AF19F69FF8C8F75(__this, L_0, (&V_0), NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.Animator::SetIKRotation(UnityEngine.AvatarIKGoal,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetIKRotation_m328A64AD20922F0F2A1D0CD5DBB9F01FE7675DF6 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_goal, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___1_goalRotation, const RuntimeMethod* method) 
{
	{
		Animator_CheckIfInIKPass_mE7815990AFAD02738D0D5B4DA8DDB3E649D30CCF(__this, NULL);
		int32_t L_0 = ___0_goal;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_1 = ___1_goalRotation;
		Animator_SetGoalRotation_m1BFE2425DE75954B1233ABD96D6AB3682D42E5BA(__this, L_0, L_1, NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetGoalRotation(UnityEngine.AvatarIKGoal,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalRotation_m1BFE2425DE75954B1233ABD96D6AB3682D42E5BA (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_goal, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___1_goalRotation, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = ___0_goal;
		Animator_SetGoalRotation_Injected_m93587602A0C43AC9B184D30B03F751C02E6BF045(__this, L_0, (&___1_goalRotation), NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetIKPositionWeight(UnityEngine.AvatarIKGoal,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetIKPositionWeight_m8C707F505FFE2A6F36BE81ED12786B941D3B990C (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_goal, float ___1_value, const RuntimeMethod* method) 
{
	{
		Animator_CheckIfInIKPass_mE7815990AFAD02738D0D5B4DA8DDB3E649D30CCF(__this, NULL);
		int32_t L_0 = ___0_goal;
		float L_1 = ___1_value;
		Animator_SetGoalWeightPosition_mBCC0ED516684541F6AD9B784ECCCA2D7C14DC75E(__this, L_0, L_1, NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetGoalWeightPosition(UnityEngine.AvatarIKGoal,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalWeightPosition_mBCC0ED516684541F6AD9B784ECCCA2D7C14DC75E (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_goal, float ___1_value, const RuntimeMethod* method) 
{
	typedef void (*Animator_SetGoalWeightPosition_mBCC0ED516684541F6AD9B784ECCCA2D7C14DC75E_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, int32_t, float);
	static Animator_SetGoalWeightPosition_mBCC0ED516684541F6AD9B784ECCCA2D7C14DC75E_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetGoalWeightPosition_mBCC0ED516684541F6AD9B784ECCCA2D7C14DC75E_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetGoalWeightPosition(UnityEngine.AvatarIKGoal,System.Single)");
	_il2cpp_icall_func(__this, ___0_goal, ___1_value);
}
// System.Void UnityEngine.Animator::SetIKRotationWeight(UnityEngine.AvatarIKGoal,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetIKRotationWeight_m5F0F5BD5A9A85912EA1CDF32917FE483E849978D (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_goal, float ___1_value, const RuntimeMethod* method) 
{
	{
		Animator_CheckIfInIKPass_mE7815990AFAD02738D0D5B4DA8DDB3E649D30CCF(__this, NULL);
		int32_t L_0 = ___0_goal;
		float L_1 = ___1_value;
		Animator_SetGoalWeightRotation_mA8A5BE4C22583CFB7C66EF59A1997E241A3001EF(__this, L_0, L_1, NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetGoalWeightRotation(UnityEngine.AvatarIKGoal,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalWeightRotation_mA8A5BE4C22583CFB7C66EF59A1997E241A3001EF (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_goal, float ___1_value, const RuntimeMethod* method) 
{
	typedef void (*Animator_SetGoalWeightRotation_mA8A5BE4C22583CFB7C66EF59A1997E241A3001EF_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, int32_t, float);
	static Animator_SetGoalWeightRotation_mA8A5BE4C22583CFB7C66EF59A1997E241A3001EF_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetGoalWeightRotation_mA8A5BE4C22583CFB7C66EF59A1997E241A3001EF_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetGoalWeightRotation(UnityEngine.AvatarIKGoal,System.Single)");
	_il2cpp_icall_func(__this, ___0_goal, ___1_value);
}
// System.Void UnityEngine.Animator::SetLookAtPosition(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLookAtPosition_m39A2C326BDE156360972C5EEDA1F9ACEBE34A8A6 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_lookAtPosition, const RuntimeMethod* method) 
{
	{
		Animator_CheckIfInIKPass_mE7815990AFAD02738D0D5B4DA8DDB3E649D30CCF(__this, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_lookAtPosition;
		Animator_SetLookAtPositionInternal_m6A20F2667C36D8363BA0F38A961BAB941E2DDC1B(__this, L_0, NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetLookAtPositionInternal(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLookAtPositionInternal_m6A20F2667C36D8363BA0F38A961BAB941E2DDC1B (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_lookAtPosition, const RuntimeMethod* method) 
{
	{
		Animator_SetLookAtPositionInternal_Injected_mE50AFECADA7DC76D0E73C6B7131EBBD1CED5D59D(__this, (&___0_lookAtPosition), NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetLookAtWeight(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLookAtWeight_mDCC8C8792E2E23C133AF3D91A96C49BEBC828F79 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, float ___0_weight, const RuntimeMethod* method) 
{
	{
		Animator_CheckIfInIKPass_mE7815990AFAD02738D0D5B4DA8DDB3E649D30CCF(__this, NULL);
		float L_0 = ___0_weight;
		Animator_SetLookAtWeightInternal_m41D66B6DA78B1ACB7EE3E3B51A29904DEB05778F(__this, L_0, (0.0f), (1.0f), (0.0f), (0.5f), NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetLookAtWeight(System.Single,System.Single,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLookAtWeight_m536B18C7EC83703CF0320924D9FE13CBD93CC752 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, float ___0_weight, float ___1_bodyWeight, float ___2_headWeight, float ___3_eyesWeight, float ___4_clampWeight, const RuntimeMethod* method) 
{
	{
		Animator_CheckIfInIKPass_mE7815990AFAD02738D0D5B4DA8DDB3E649D30CCF(__this, NULL);
		float L_0 = ___0_weight;
		float L_1 = ___1_bodyWeight;
		float L_2 = ___2_headWeight;
		float L_3 = ___3_eyesWeight;
		float L_4 = ___4_clampWeight;
		Animator_SetLookAtWeightInternal_m41D66B6DA78B1ACB7EE3E3B51A29904DEB05778F(__this, L_0, L_1, L_2, L_3, L_4, NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetLookAtWeightInternal(System.Single,System.Single,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLookAtWeightInternal_m41D66B6DA78B1ACB7EE3E3B51A29904DEB05778F (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, float ___0_weight, float ___1_bodyWeight, float ___2_headWeight, float ___3_eyesWeight, float ___4_clampWeight, const RuntimeMethod* method) 
{
	typedef void (*Animator_SetLookAtWeightInternal_m41D66B6DA78B1ACB7EE3E3B51A29904DEB05778F_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, float, float, float, float, float);
	static Animator_SetLookAtWeightInternal_m41D66B6DA78B1ACB7EE3E3B51A29904DEB05778F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetLookAtWeightInternal_m41D66B6DA78B1ACB7EE3E3B51A29904DEB05778F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetLookAtWeightInternal(System.Single,System.Single,System.Single,System.Single,System.Single)");
	_il2cpp_icall_func(__this, ___0_weight, ___1_bodyWeight, ___2_headWeight, ___3_eyesWeight, ___4_clampWeight);
}
// System.Int32 UnityEngine.Animator::get_layerCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_get_layerCount_m75C20E7284800DFA0E4AD7EC23910BDB6D62BDA8 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) 
{
	typedef int32_t (*Animator_get_layerCount_m75C20E7284800DFA0E4AD7EC23910BDB6D62BDA8_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*);
	static Animator_get_layerCount_m75C20E7284800DFA0E4AD7EC23910BDB6D62BDA8_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_layerCount_m75C20E7284800DFA0E4AD7EC23910BDB6D62BDA8_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_layerCount()");
	int32_t icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.String UnityEngine.Animator::GetLayerName(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Animator_GetLayerName_m7458E91DE0B0769E79038DFEF32B750BE6801BA7 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) 
{
	typedef String_t* (*Animator_GetLayerName_m7458E91DE0B0769E79038DFEF32B750BE6801BA7_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, int32_t);
	static Animator_GetLayerName_m7458E91DE0B0769E79038DFEF32B750BE6801BA7_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetLayerName_m7458E91DE0B0769E79038DFEF32B750BE6801BA7_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetLayerName(System.Int32)");
	String_t* icallRetVal = _il2cpp_icall_func(__this, ___0_layerIndex);
	return icallRetVal;
}
// System.Single UnityEngine.Animator::GetLayerWeight(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetLayerWeight_m24EB83CB3CFC724CB77461A26BB794E7DEE15BCA (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) 
{
	typedef float (*Animator_GetLayerWeight_m24EB83CB3CFC724CB77461A26BB794E7DEE15BCA_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, int32_t);
	static Animator_GetLayerWeight_m24EB83CB3CFC724CB77461A26BB794E7DEE15BCA_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetLayerWeight_m24EB83CB3CFC724CB77461A26BB794E7DEE15BCA_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetLayerWeight(System.Int32)");
	float icallRetVal = _il2cpp_icall_func(__this, ___0_layerIndex);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::SetLayerWeight(System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLayerWeight_m06ADC732F76F22B4B1424F25525E7CBB80E6230F (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_layerIndex, float ___1_weight, const RuntimeMethod* method) 
{
	typedef void (*Animator_SetLayerWeight_m06ADC732F76F22B4B1424F25525E7CBB80E6230F_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, int32_t, float);
	static Animator_SetLayerWeight_m06ADC732F76F22B4B1424F25525E7CBB80E6230F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetLayerWeight_m06ADC732F76F22B4B1424F25525E7CBB80E6230F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetLayerWeight(System.Int32,System.Single)");
	_il2cpp_icall_func(__this, ___0_layerIndex, ___1_weight);
}
// System.Void UnityEngine.Animator::GetAnimatorStateInfo(System.Int32,UnityEngine.StateInfoIndex,UnityEngine.AnimatorStateInfo&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetAnimatorStateInfo_mC6C046A539DE6E8D481E830D3DA1FBF96DFC367D (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_layerIndex, int32_t ___1_stateInfoIndex, AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* ___2_info, const RuntimeMethod* method) 
{
	typedef void (*Animator_GetAnimatorStateInfo_mC6C046A539DE6E8D481E830D3DA1FBF96DFC367D_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, int32_t, int32_t, AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2*);
	static Animator_GetAnimatorStateInfo_mC6C046A539DE6E8D481E830D3DA1FBF96DFC367D_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetAnimatorStateInfo_mC6C046A539DE6E8D481E830D3DA1FBF96DFC367D_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetAnimatorStateInfo(System.Int32,UnityEngine.StateInfoIndex,UnityEngine.AnimatorStateInfo&)");
	_il2cpp_icall_func(__this, ___0_layerIndex, ___1_stateInfoIndex, ___2_info);
}
// UnityEngine.AnimatorStateInfo UnityEngine.Animator::GetCurrentAnimatorStateInfo(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 Animator_GetCurrentAnimatorStateInfo_mD5B526FA605F6CFBC31B7DE36740F6AD1E534CAD (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) 
{
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		int32_t L_0 = ___0_layerIndex;
		Animator_GetAnimatorStateInfo_mC6C046A539DE6E8D481E830D3DA1FBF96DFC367D(__this, L_0, 0, (&V_0), NULL);
		AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 L_1 = V_0;
		V_1 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 L_2 = V_1;
		return L_2;
	}
}
// UnityEngine.AnimatorStateInfo UnityEngine.Animator::GetNextAnimatorStateInfo(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 Animator_GetNextAnimatorStateInfo_m4661892C3F99329907EE3EE1C1FCB7974CDA2433 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) 
{
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		int32_t L_0 = ___0_layerIndex;
		Animator_GetAnimatorStateInfo_mC6C046A539DE6E8D481E830D3DA1FBF96DFC367D(__this, L_0, 1, (&V_0), NULL);
		AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 L_1 = V_0;
		V_1 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 L_2 = V_1;
		return L_2;
	}
}
// System.Int32 UnityEngine.Animator::GetAnimatorClipInfoCount(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_GetAnimatorClipInfoCount_m83C02F470FEC1DAF548AB88C578B64B6B3BB8E9B (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_layerIndex, bool ___1_current, const RuntimeMethod* method) 
{
	typedef int32_t (*Animator_GetAnimatorClipInfoCount_m83C02F470FEC1DAF548AB88C578B64B6B3BB8E9B_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, int32_t, bool);
	static Animator_GetAnimatorClipInfoCount_m83C02F470FEC1DAF548AB88C578B64B6B3BB8E9B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetAnimatorClipInfoCount_m83C02F470FEC1DAF548AB88C578B64B6B3BB8E9B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetAnimatorClipInfoCount(System.Int32,System.Boolean)");
	int32_t icallRetVal = _il2cpp_icall_func(__this, ___0_layerIndex, ___1_current);
	return icallRetVal;
}
// System.Int32 UnityEngine.Animator::GetCurrentAnimatorClipInfoCount(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_GetCurrentAnimatorClipInfoCount_mB506E49EC0B2DD764D78A21D6AE55B4E9AAB9AE4 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = ___0_layerIndex;
		int32_t L_1;
		L_1 = Animator_GetAnimatorClipInfoCount_m83C02F470FEC1DAF548AB88C578B64B6B3BB8E9B(__this, L_0, (bool)1, NULL);
		V_0 = L_1;
		goto IL_000c;
	}

IL_000c:
	{
		int32_t L_2 = V_0;
		return L_2;
	}
}
// System.Int32 UnityEngine.Animator::GetNextAnimatorClipInfoCount(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_GetNextAnimatorClipInfoCount_m079742F61B3A1616C4419C82F91B84BD9D5613CC (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = ___0_layerIndex;
		int32_t L_1;
		L_1 = Animator_GetAnimatorClipInfoCount_m83C02F470FEC1DAF548AB88C578B64B6B3BB8E9B(__this, L_0, (bool)0, NULL);
		V_0 = L_1;
		goto IL_000c;
	}

IL_000c:
	{
		int32_t L_2 = V_0;
		return L_2;
	}
}
// System.Void UnityEngine.Animator::GetCurrentAnimatorClipInfo(System.Int32,System.Collections.Generic.List`1<UnityEngine.AnimatorClipInfo>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetCurrentAnimatorClipInfo_m7C061EE420A67B7D751A2F34D38062FDFF064ED3 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_layerIndex, List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331* ___1_clips, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331* L_0 = ___1_clips;
		V_0 = (bool)((((RuntimeObject*)(List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331*)L_0) == ((RuntimeObject*)(RuntimeObject*)NULL))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0014;
		}
	}
	{
		ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129* L_2 = (ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129_il2cpp_TypeInfo_var)));
		NullCheck(L_2);
		ArgumentNullException__ctor_m444AE141157E333844FC1A9500224C2F9FD24F4B(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral05ACCFE2F05290DF031B27B4C6B2AD1DC43CCDC6)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Animator_GetCurrentAnimatorClipInfo_m7C061EE420A67B7D751A2F34D38062FDFF064ED3_RuntimeMethod_var)));
	}

IL_0014:
	{
		int32_t L_3 = ___0_layerIndex;
		List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331* L_4 = ___1_clips;
		Animator_GetAnimatorClipInfoInternal_m98028420AD065F1B6F3DC2EB4C6C2A42B8567600(__this, L_3, (bool)1, L_4, NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::GetAnimatorClipInfoInternal(System.Int32,System.Boolean,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetAnimatorClipInfoInternal_m98028420AD065F1B6F3DC2EB4C6C2A42B8567600 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_layerIndex, bool ___1_isCurrent, RuntimeObject* ___2_clips, const RuntimeMethod* method) 
{
	typedef void (*Animator_GetAnimatorClipInfoInternal_m98028420AD065F1B6F3DC2EB4C6C2A42B8567600_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, int32_t, bool, RuntimeObject*);
	static Animator_GetAnimatorClipInfoInternal_m98028420AD065F1B6F3DC2EB4C6C2A42B8567600_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetAnimatorClipInfoInternal_m98028420AD065F1B6F3DC2EB4C6C2A42B8567600_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetAnimatorClipInfoInternal(System.Int32,System.Boolean,System.Object)");
	_il2cpp_icall_func(__this, ___0_layerIndex, ___1_isCurrent, ___2_clips);
}
// System.Void UnityEngine.Animator::GetNextAnimatorClipInfo(System.Int32,System.Collections.Generic.List`1<UnityEngine.AnimatorClipInfo>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetNextAnimatorClipInfo_m376D90AA469A7F7268B8D0E5B6930CE7095185D3 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_layerIndex, List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331* ___1_clips, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331* L_0 = ___1_clips;
		V_0 = (bool)((((RuntimeObject*)(List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331*)L_0) == ((RuntimeObject*)(RuntimeObject*)NULL))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0014;
		}
	}
	{
		ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129* L_2 = (ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129_il2cpp_TypeInfo_var)));
		NullCheck(L_2);
		ArgumentNullException__ctor_m444AE141157E333844FC1A9500224C2F9FD24F4B(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral05ACCFE2F05290DF031B27B4C6B2AD1DC43CCDC6)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Animator_GetNextAnimatorClipInfo_m376D90AA469A7F7268B8D0E5B6930CE7095185D3_RuntimeMethod_var)));
	}

IL_0014:
	{
		int32_t L_3 = ___0_layerIndex;
		List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331* L_4 = ___1_clips;
		Animator_GetAnimatorClipInfoInternal_m98028420AD065F1B6F3DC2EB4C6C2A42B8567600(__this, L_3, (bool)0, L_4, NULL);
		return;
	}
}
// System.Single UnityEngine.Animator::get_speed()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_get_speed_m41AFD6B0AB3FF4FFF8855CCAF684813BA1148CD2 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) 
{
	typedef float (*Animator_get_speed_m41AFD6B0AB3FF4FFF8855CCAF684813BA1148CD2_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*);
	static Animator_get_speed_m41AFD6B0AB3FF4FFF8855CCAF684813BA1148CD2_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_speed_m41AFD6B0AB3FF4FFF8855CCAF684813BA1148CD2_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_speed()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::set_speed(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_speed_m933F4D6770122BC9D8A7FF82DE1CD33D514379FC (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, float ___0_value, const RuntimeMethod* method) 
{
	typedef void (*Animator_set_speed_m933F4D6770122BC9D8A7FF82DE1CD33D514379FC_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, float);
	static Animator_set_speed_m933F4D6770122BC9D8A7FF82DE1CD33D514379FC_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_speed_m933F4D6770122BC9D8A7FF82DE1CD33D514379FC_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_speed(System.Single)");
	_il2cpp_icall_func(__this, ___0_value);
}
// UnityEngine.Transform UnityEngine.Animator::GetBoneTransform(UnityEngine.HumanBodyBones)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* Animator_GetBoneTransform_m02042CB47C468D576C6EE436F4AA71D8C47AAF56 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_humanBoneId, const RuntimeMethod* method) 
{
	bool V_0 = false;
	int32_t V_1 = 0;
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* V_2 = NULL;
	int32_t G_B3_0 = 0;
	{
		int32_t L_0 = ___0_humanBoneId;
		if ((((int32_t)L_0) < ((int32_t)0)))
		{
			goto IL_000f;
		}
	}
	{
		int32_t L_1 = ___0_humanBoneId;
		G_B3_0 = ((((int32_t)((((int32_t)L_1) < ((int32_t)((int32_t)55)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_0010;
	}

IL_000f:
	{
		G_B3_0 = 1;
	}

IL_0010:
	{
		V_0 = (bool)G_B3_0;
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_0034;
		}
	}
	{
		V_1 = ((int32_t)55);
		Il2CppFakeBox<int32_t> L_3(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&HumanBodyBones_tA2A904890A05ABCFFAB7E119244E97C5EA9807E6_il2cpp_TypeInfo_var)), (&V_1));
		String_t* L_4;
		L_4 = Enum_ToString_m946B0B83C4470457D0FF555D862022C72BB55741((Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2*)(&L_3), NULL);
		String_t* L_5;
		L_5 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral00F97321929E0D7989E72D633D157BD761DD173A)), L_4, NULL);
		IndexOutOfRangeException_t7ECB35264FB6CA8FAA516BD958F4B2ADC78E8A82* L_6 = (IndexOutOfRangeException_t7ECB35264FB6CA8FAA516BD958F4B2ADC78E8A82*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&IndexOutOfRangeException_t7ECB35264FB6CA8FAA516BD958F4B2ADC78E8A82_il2cpp_TypeInfo_var)));
		NullCheck(L_6);
		IndexOutOfRangeException__ctor_mFD06819F05B815BE2D6E826D4E04F4C449D0A425(L_6, L_5, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_6, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Animator_GetBoneTransform_m02042CB47C468D576C6EE436F4AA71D8C47AAF56_RuntimeMethod_var)));
	}

IL_0034:
	{
		int32_t L_7 = ___0_humanBoneId;
		int32_t L_8;
		L_8 = HumanTrait_GetBoneIndexFromMono_mDE16E21275A55D263014CFD3307BEB7353AE6925(L_7, NULL);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_9;
		L_9 = Animator_GetBoneTransformInternal_m875DC36979BC9FB162D83E799421243AD3842857(__this, L_8, NULL);
		V_2 = L_9;
		goto IL_0043;
	}

IL_0043:
	{
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_10 = V_2;
		return L_10;
	}
}
// UnityEngine.Transform UnityEngine.Animator::GetBoneTransformInternal(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* Animator_GetBoneTransformInternal_m875DC36979BC9FB162D83E799421243AD3842857 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_humanBoneId, const RuntimeMethod* method) 
{
	typedef Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* (*Animator_GetBoneTransformInternal_m875DC36979BC9FB162D83E799421243AD3842857_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, int32_t);
	static Animator_GetBoneTransformInternal_m875DC36979BC9FB162D83E799421243AD3842857_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetBoneTransformInternal_m875DC36979BC9FB162D83E799421243AD3842857_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetBoneTransformInternal(System.Int32)");
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* icallRetVal = _il2cpp_icall_func(__this, ___0_humanBoneId);
	return icallRetVal;
}
// UnityEngine.RuntimeAnimatorController UnityEngine.Animator::get_runtimeAnimatorController()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeAnimatorController_t6F7C753402B42EC23C163099CF935C5E0D7A7254* Animator_get_runtimeAnimatorController_mE10F46F893A630D1AE846EF66DC2769E3ECE5AB8 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) 
{
	typedef RuntimeAnimatorController_t6F7C753402B42EC23C163099CF935C5E0D7A7254* (*Animator_get_runtimeAnimatorController_mE10F46F893A630D1AE846EF66DC2769E3ECE5AB8_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*);
	static Animator_get_runtimeAnimatorController_mE10F46F893A630D1AE846EF66DC2769E3ECE5AB8_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_runtimeAnimatorController_mE10F46F893A630D1AE846EF66DC2769E3ECE5AB8_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_runtimeAnimatorController()");
	RuntimeAnimatorController_t6F7C753402B42EC23C163099CF935C5E0D7A7254* icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.Animator::get_hasBoundPlayables()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_hasBoundPlayables_mA5A6132C03593851FE80D8E7490191E051E5A1C9 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) 
{
	typedef bool (*Animator_get_hasBoundPlayables_mA5A6132C03593851FE80D8E7490191E051E5A1C9_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*);
	static Animator_get_hasBoundPlayables_mA5A6132C03593851FE80D8E7490191E051E5A1C9_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_hasBoundPlayables_mA5A6132C03593851FE80D8E7490191E051E5A1C9_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_hasBoundPlayables()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Int32 UnityEngine.Animator::StringToHash(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_StringToHash_mD67B872C411BE37641F49D7AA1DBD45B67F63E3A (String_t* ___0_name, const RuntimeMethod* method) 
{
	typedef int32_t (*Animator_StringToHash_mD67B872C411BE37641F49D7AA1DBD45B67F63E3A_ftn) (String_t*);
	static Animator_StringToHash_mD67B872C411BE37641F49D7AA1DBD45B67F63E3A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_StringToHash_mD67B872C411BE37641F49D7AA1DBD45B67F63E3A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::StringToHash(System.String)");
	int32_t icallRetVal = _il2cpp_icall_func(___0_name);
	return icallRetVal;
}
// UnityEngine.Avatar UnityEngine.Animator::get_avatar()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Avatar_t7861E57EEE2CF8CC61BD63C09737BA22F7ABCA0F* Animator_get_avatar_m01E445FC754BC6F4A39639EAF68D3954580EAA67 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) 
{
	typedef Avatar_t7861E57EEE2CF8CC61BD63C09737BA22F7ABCA0F* (*Animator_get_avatar_m01E445FC754BC6F4A39639EAF68D3954580EAA67_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*);
	static Animator_get_avatar_m01E445FC754BC6F4A39639EAF68D3954580EAA67_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_avatar_m01E445FC754BC6F4A39639EAF68D3954580EAA67_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_avatar()");
	Avatar_t7861E57EEE2CF8CC61BD63C09737BA22F7ABCA0F* icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// UnityEngine.Playables.PlayableGraph UnityEngine.Animator::get_playableGraph()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E Animator_get_playableGraph_m118650892C13ED75C535C2A32CE09641C7E3BAD7 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) 
{
	PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E V_0;
	memset((&V_0), 0, sizeof(V_0));
	PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		il2cpp_codegen_initobj((&V_0), sizeof(PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E));
		Animator_GetCurrentGraph_mDDDDABBEA3E4BBD025401F92FFFE5B71DAC9486F(__this, (&V_0), NULL);
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_0 = V_0;
		V_1 = L_0;
		goto IL_0016;
	}

IL_0016:
	{
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_1 = V_1;
		return L_1;
	}
}
// System.Void UnityEngine.Animator::GetCurrentGraph(UnityEngine.Playables.PlayableGraph&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetCurrentGraph_mDDDDABBEA3E4BBD025401F92FFFE5B71DAC9486F (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, const RuntimeMethod* method) 
{
	typedef void (*Animator_GetCurrentGraph_mDDDDABBEA3E4BBD025401F92FFFE5B71DAC9486F_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E*);
	static Animator_GetCurrentGraph_mDDDDABBEA3E4BBD025401F92FFFE5B71DAC9486F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetCurrentGraph_mDDDDABBEA3E4BBD025401F92FFFE5B71DAC9486F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetCurrentGraph(UnityEngine.Playables.PlayableGraph&)");
	_il2cpp_icall_func(__this, ___0_graph);
}
// System.Void UnityEngine.Animator::CheckIfInIKPass()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CheckIfInIKPass_mE7815990AFAD02738D0D5B4DA8DDB3E649D30CCF (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD1DCB778EB9DF1B12AD26B829002FF8E78A1AFCE);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	int32_t G_B3_0 = 0;
	{
		bool L_0;
		L_0 = Animator_get_logWarnings_m39949DA4A177E2D107023FB0BD89DC3D6F303652(__this, NULL);
		if (!L_0)
		{
			goto IL_0014;
		}
	}
	{
		bool L_1;
		L_1 = Animator_IsInIKPass_m35BF844B06D845BD0C6778F3B6E87B9C0B26BA5F(__this, NULL);
		G_B3_0 = ((((int32_t)L_1) == ((int32_t)0))? 1 : 0);
		goto IL_0015;
	}

IL_0014:
	{
		G_B3_0 = 0;
	}

IL_0015:
	{
		V_0 = (bool)G_B3_0;
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_0024;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogWarning_m33EF1B897E0C7C6FF538989610BFAFFEF4628CA9(_stringLiteralD1DCB778EB9DF1B12AD26B829002FF8E78A1AFCE, NULL);
	}

IL_0024:
	{
		return;
	}
}
// System.Boolean UnityEngine.Animator::IsInIKPass()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_IsInIKPass_m35BF844B06D845BD0C6778F3B6E87B9C0B26BA5F (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) 
{
	typedef bool (*Animator_IsInIKPass_m35BF844B06D845BD0C6778F3B6E87B9C0B26BA5F_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*);
	static Animator_IsInIKPass_m35BF844B06D845BD0C6778F3B6E87B9C0B26BA5F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_IsInIKPass_m35BF844B06D845BD0C6778F3B6E87B9C0B26BA5F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::IsInIKPass()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::SetFloatString(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetFloatString_m1AA50083AAAE1DFFA7FB64502EA106795D3756B4 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, String_t* ___0_name, float ___1_value, const RuntimeMethod* method) 
{
	typedef void (*Animator_SetFloatString_m1AA50083AAAE1DFFA7FB64502EA106795D3756B4_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, String_t*, float);
	static Animator_SetFloatString_m1AA50083AAAE1DFFA7FB64502EA106795D3756B4_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetFloatString_m1AA50083AAAE1DFFA7FB64502EA106795D3756B4_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetFloatString(System.String,System.Single)");
	_il2cpp_icall_func(__this, ___0_name, ___1_value);
}
// System.Void UnityEngine.Animator::SetFloatID(System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetFloatID_m348942A23D4C734DDF4D04C7609E5CD9EBAB66AA (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, float ___1_value, const RuntimeMethod* method) 
{
	typedef void (*Animator_SetFloatID_m348942A23D4C734DDF4D04C7609E5CD9EBAB66AA_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, int32_t, float);
	static Animator_SetFloatID_m348942A23D4C734DDF4D04C7609E5CD9EBAB66AA_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetFloatID_m348942A23D4C734DDF4D04C7609E5CD9EBAB66AA_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetFloatID(System.Int32,System.Single)");
	_il2cpp_icall_func(__this, ___0_id, ___1_value);
}
// System.Single UnityEngine.Animator::GetFloatID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetFloatID_m0300DB1901B65F007EA9E0E98ACB91E105FDD366 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, const RuntimeMethod* method) 
{
	typedef float (*Animator_GetFloatID_m0300DB1901B65F007EA9E0E98ACB91E105FDD366_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, int32_t);
	static Animator_GetFloatID_m0300DB1901B65F007EA9E0E98ACB91E105FDD366_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetFloatID_m0300DB1901B65F007EA9E0E98ACB91E105FDD366_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetFloatID(System.Int32)");
	float icallRetVal = _il2cpp_icall_func(__this, ___0_id);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::SetBoolString(System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetBoolString_m08A0BC6717BF5FD3E43D3EFB2509E359C1196C00 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, String_t* ___0_name, bool ___1_value, const RuntimeMethod* method) 
{
	typedef void (*Animator_SetBoolString_m08A0BC6717BF5FD3E43D3EFB2509E359C1196C00_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, String_t*, bool);
	static Animator_SetBoolString_m08A0BC6717BF5FD3E43D3EFB2509E359C1196C00_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetBoolString_m08A0BC6717BF5FD3E43D3EFB2509E359C1196C00_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetBoolString(System.String,System.Boolean)");
	_il2cpp_icall_func(__this, ___0_name, ___1_value);
}
// System.Void UnityEngine.Animator::SetBoolID(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetBoolID_mCDA31E47A1AA78E830D0B76394BE2FA7296E03BE (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, bool ___1_value, const RuntimeMethod* method) 
{
	typedef void (*Animator_SetBoolID_mCDA31E47A1AA78E830D0B76394BE2FA7296E03BE_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, int32_t, bool);
	static Animator_SetBoolID_mCDA31E47A1AA78E830D0B76394BE2FA7296E03BE_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetBoolID_mCDA31E47A1AA78E830D0B76394BE2FA7296E03BE_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetBoolID(System.Int32,System.Boolean)");
	_il2cpp_icall_func(__this, ___0_id, ___1_value);
}
// System.Boolean UnityEngine.Animator::GetBoolID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_GetBoolID_mD88CBA007AB7C968BF526B518E90F90E0935A9DD (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, const RuntimeMethod* method) 
{
	typedef bool (*Animator_GetBoolID_mD88CBA007AB7C968BF526B518E90F90E0935A9DD_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, int32_t);
	static Animator_GetBoolID_mD88CBA007AB7C968BF526B518E90F90E0935A9DD_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetBoolID_mD88CBA007AB7C968BF526B518E90F90E0935A9DD_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetBoolID(System.Int32)");
	bool icallRetVal = _il2cpp_icall_func(__this, ___0_id);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::SetIntegerString(System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetIntegerString_m3080217346B85D69FA5A99B2ABC64BF5E4580455 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, String_t* ___0_name, int32_t ___1_value, const RuntimeMethod* method) 
{
	typedef void (*Animator_SetIntegerString_m3080217346B85D69FA5A99B2ABC64BF5E4580455_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, String_t*, int32_t);
	static Animator_SetIntegerString_m3080217346B85D69FA5A99B2ABC64BF5E4580455_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetIntegerString_m3080217346B85D69FA5A99B2ABC64BF5E4580455_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetIntegerString(System.String,System.Int32)");
	_il2cpp_icall_func(__this, ___0_name, ___1_value);
}
// System.Void UnityEngine.Animator::SetIntegerID(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetIntegerID_m08431A06E5905C62BA397B9BAB30F87E3C30569F (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, int32_t ___1_value, const RuntimeMethod* method) 
{
	typedef void (*Animator_SetIntegerID_m08431A06E5905C62BA397B9BAB30F87E3C30569F_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, int32_t, int32_t);
	static Animator_SetIntegerID_m08431A06E5905C62BA397B9BAB30F87E3C30569F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetIntegerID_m08431A06E5905C62BA397B9BAB30F87E3C30569F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetIntegerID(System.Int32,System.Int32)");
	_il2cpp_icall_func(__this, ___0_id, ___1_value);
}
// System.Int32 UnityEngine.Animator::GetIntegerID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_GetIntegerID_mCAC9F61639DAF52DD2DE8891DB8A2F7FE5C3DF4A (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, const RuntimeMethod* method) 
{
	typedef int32_t (*Animator_GetIntegerID_mCAC9F61639DAF52DD2DE8891DB8A2F7FE5C3DF4A_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, int32_t);
	static Animator_GetIntegerID_mCAC9F61639DAF52DD2DE8891DB8A2F7FE5C3DF4A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetIntegerID_mCAC9F61639DAF52DD2DE8891DB8A2F7FE5C3DF4A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetIntegerID(System.Int32)");
	int32_t icallRetVal = _il2cpp_icall_func(__this, ___0_id);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::SetTriggerString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetTriggerString_m177C75DFBE070DE66FC08A3232444CCEA409C25E (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, String_t* ___0_name, const RuntimeMethod* method) 
{
	typedef void (*Animator_SetTriggerString_m177C75DFBE070DE66FC08A3232444CCEA409C25E_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, String_t*);
	static Animator_SetTriggerString_m177C75DFBE070DE66FC08A3232444CCEA409C25E_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetTriggerString_m177C75DFBE070DE66FC08A3232444CCEA409C25E_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetTriggerString(System.String)");
	_il2cpp_icall_func(__this, ___0_name);
}
// System.Void UnityEngine.Animator::SetTriggerID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetTriggerID_mCC0A74BF79A56BC1EA634641C64B8E527B0B49E7 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, const RuntimeMethod* method) 
{
	typedef void (*Animator_SetTriggerID_mCC0A74BF79A56BC1EA634641C64B8E527B0B49E7_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, int32_t);
	static Animator_SetTriggerID_mCC0A74BF79A56BC1EA634641C64B8E527B0B49E7_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetTriggerID_mCC0A74BF79A56BC1EA634641C64B8E527B0B49E7_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetTriggerID(System.Int32)");
	_il2cpp_icall_func(__this, ___0_id);
}
// System.Void UnityEngine.Animator::ResetTriggerString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_ResetTriggerString_m78259348CED35F156148A64B95EBD73CE3951868 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, String_t* ___0_name, const RuntimeMethod* method) 
{
	typedef void (*Animator_ResetTriggerString_m78259348CED35F156148A64B95EBD73CE3951868_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, String_t*);
	static Animator_ResetTriggerString_m78259348CED35F156148A64B95EBD73CE3951868_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_ResetTriggerString_m78259348CED35F156148A64B95EBD73CE3951868_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::ResetTriggerString(System.String)");
	_il2cpp_icall_func(__this, ___0_name);
}
// System.Void UnityEngine.Animator::ResetTriggerID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_ResetTriggerID_mD3E0C24AC862F049622D09933E7A3A2CDE256C13 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_id, const RuntimeMethod* method) 
{
	typedef void (*Animator_ResetTriggerID_mD3E0C24AC862F049622D09933E7A3A2CDE256C13_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, int32_t);
	static Animator_ResetTriggerID_mD3E0C24AC862F049622D09933E7A3A2CDE256C13_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_ResetTriggerID_mD3E0C24AC862F049622D09933E7A3A2CDE256C13_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::ResetTriggerID(System.Int32)");
	_il2cpp_icall_func(__this, ___0_id);
}
// System.Single UnityEngine.Animator::get_leftFeetBottomHeight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_get_leftFeetBottomHeight_m5ECBAF5B6CCC20691ADA416B95AAE9192DF09C76 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) 
{
	typedef float (*Animator_get_leftFeetBottomHeight_m5ECBAF5B6CCC20691ADA416B95AAE9192DF09C76_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*);
	static Animator_get_leftFeetBottomHeight_m5ECBAF5B6CCC20691ADA416B95AAE9192DF09C76_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_leftFeetBottomHeight_m5ECBAF5B6CCC20691ADA416B95AAE9192DF09C76_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_leftFeetBottomHeight()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Single UnityEngine.Animator::get_rightFeetBottomHeight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_get_rightFeetBottomHeight_m0C68C9515FF2AD560D36357A134246DADB8A3544 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) 
{
	typedef float (*Animator_get_rightFeetBottomHeight_m0C68C9515FF2AD560D36357A134246DADB8A3544_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*);
	static Animator_get_rightFeetBottomHeight_m0C68C9515FF2AD560D36357A134246DADB8A3544_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_rightFeetBottomHeight_m0C68C9515FF2AD560D36357A134246DADB8A3544_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_rightFeetBottomHeight()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::Rebind()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_Rebind_m853F9E50ACB0A29D4F144FFD851E92F346195F9F (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) 
{
	{
		Animator_Rebind_mA8163C9B7150958C0FB3F071B7ED41850BE3A130(__this, (bool)1, NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::Rebind(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_Rebind_mA8163C9B7150958C0FB3F071B7ED41850BE3A130 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, bool ___0_writeDefaultValues, const RuntimeMethod* method) 
{
	typedef void (*Animator_Rebind_mA8163C9B7150958C0FB3F071B7ED41850BE3A130_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, bool);
	static Animator_Rebind_mA8163C9B7150958C0FB3F071B7ED41850BE3A130_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_Rebind_mA8163C9B7150958C0FB3F071B7ED41850BE3A130_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::Rebind(System.Boolean)");
	_il2cpp_icall_func(__this, ___0_writeDefaultValues);
}
// System.Void UnityEngine.Animator::ApplyBuiltinRootMotion()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_ApplyBuiltinRootMotion_m2ED8DAFF78DC1A0CA62CF3785692074DBC51808C (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) 
{
	typedef void (*Animator_ApplyBuiltinRootMotion_m2ED8DAFF78DC1A0CA62CF3785692074DBC51808C_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*);
	static Animator_ApplyBuiltinRootMotion_m2ED8DAFF78DC1A0CA62CF3785692074DBC51808C_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_ApplyBuiltinRootMotion_m2ED8DAFF78DC1A0CA62CF3785692074DBC51808C_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::ApplyBuiltinRootMotion()");
	_il2cpp_icall_func(__this);
}
// System.Boolean UnityEngine.Animator::get_logWarnings()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_logWarnings_m39949DA4A177E2D107023FB0BD89DC3D6F303652 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) 
{
	typedef bool (*Animator_get_logWarnings_m39949DA4A177E2D107023FB0BD89DC3D6F303652_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*);
	static Animator_get_logWarnings_m39949DA4A177E2D107023FB0BD89DC3D6F303652_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_logWarnings_m39949DA4A177E2D107023FB0BD89DC3D6F303652_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_logWarnings()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.Animator::get_keepAnimatorStateOnDisable()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_keepAnimatorStateOnDisable_m7FAE9E72FA31D90E7D55664BD627C2903893A76B (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, const RuntimeMethod* method) 
{
	typedef bool (*Animator_get_keepAnimatorStateOnDisable_m7FAE9E72FA31D90E7D55664BD627C2903893A76B_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*);
	static Animator_get_keepAnimatorStateOnDisable_m7FAE9E72FA31D90E7D55664BD627C2903893A76B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_keepAnimatorStateOnDisable_m7FAE9E72FA31D90E7D55664BD627C2903893A76B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_keepAnimatorStateOnDisable()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::set_keepAnimatorStateOnDisable(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_keepAnimatorStateOnDisable_mE439995234FEE85A9DE7DB5238D301128CABB769 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, bool ___0_value, const RuntimeMethod* method) 
{
	typedef void (*Animator_set_keepAnimatorStateOnDisable_mE439995234FEE85A9DE7DB5238D301128CABB769_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, bool);
	static Animator_set_keepAnimatorStateOnDisable_mE439995234FEE85A9DE7DB5238D301128CABB769_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_keepAnimatorStateOnDisable_mE439995234FEE85A9DE7DB5238D301128CABB769_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_keepAnimatorStateOnDisable(System.Boolean)");
	_il2cpp_icall_func(__this, ___0_value);
}
// System.Void UnityEngine.Animator::get_deltaPosition_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_deltaPosition_Injected_mF37497B00055319EE54006C19AAEE221A99791F4 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_ret, const RuntimeMethod* method) 
{
	typedef void (*Animator_get_deltaPosition_Injected_mF37497B00055319EE54006C19AAEE221A99791F4_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*);
	static Animator_get_deltaPosition_Injected_mF37497B00055319EE54006C19AAEE221A99791F4_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_deltaPosition_Injected_mF37497B00055319EE54006C19AAEE221A99791F4_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_deltaPosition_Injected(UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___0_ret);
}
// System.Void UnityEngine.Animator::get_deltaRotation_Injected(UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_deltaRotation_Injected_mFEC802815227FE4B11491F80B281425A10E19ABD (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974* ___0_ret, const RuntimeMethod* method) 
{
	typedef void (*Animator_get_deltaRotation_Injected_mFEC802815227FE4B11491F80B281425A10E19ABD_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974*);
	static Animator_get_deltaRotation_Injected_mFEC802815227FE4B11491F80B281425A10E19ABD_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_deltaRotation_Injected_mFEC802815227FE4B11491F80B281425A10E19ABD_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_deltaRotation_Injected(UnityEngine.Quaternion&)");
	_il2cpp_icall_func(__this, ___0_ret);
}
// System.Void UnityEngine.Animator::set_bodyPositionInternal_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_bodyPositionInternal_Injected_m434A0C848EF277237CBAA68C4A94A1DD4A05DC75 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_value, const RuntimeMethod* method) 
{
	typedef void (*Animator_set_bodyPositionInternal_Injected_m434A0C848EF277237CBAA68C4A94A1DD4A05DC75_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*);
	static Animator_set_bodyPositionInternal_Injected_m434A0C848EF277237CBAA68C4A94A1DD4A05DC75_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_bodyPositionInternal_Injected_m434A0C848EF277237CBAA68C4A94A1DD4A05DC75_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_bodyPositionInternal_Injected(UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___0_value);
}
// System.Void UnityEngine.Animator::set_bodyRotationInternal_Injected(UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_bodyRotationInternal_Injected_m0BDC67195DA58582AEFC3567906106BD96C1D173 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974* ___0_value, const RuntimeMethod* method) 
{
	typedef void (*Animator_set_bodyRotationInternal_Injected_m0BDC67195DA58582AEFC3567906106BD96C1D173_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974*);
	static Animator_set_bodyRotationInternal_Injected_m0BDC67195DA58582AEFC3567906106BD96C1D173_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_bodyRotationInternal_Injected_m0BDC67195DA58582AEFC3567906106BD96C1D173_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_bodyRotationInternal_Injected(UnityEngine.Quaternion&)");
	_il2cpp_icall_func(__this, ___0_value);
}
// System.Void UnityEngine.Animator::SetGoalPosition_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalPosition_Injected_mE03B76DB578A3B15ED91437071BEF70F61985707 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_goal, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___1_goalPosition, const RuntimeMethod* method) 
{
	typedef void (*Animator_SetGoalPosition_Injected_mE03B76DB578A3B15ED91437071BEF70F61985707_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, int32_t, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*);
	static Animator_SetGoalPosition_Injected_mE03B76DB578A3B15ED91437071BEF70F61985707_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetGoalPosition_Injected_mE03B76DB578A3B15ED91437071BEF70F61985707_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetGoalPosition_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___0_goal, ___1_goalPosition);
}
// System.Void UnityEngine.Animator::GetGoalRotation_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetGoalRotation_Injected_m76092248C853479A1E6178DA4AF19F69FF8C8F75 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_goal, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974* ___1_ret, const RuntimeMethod* method) 
{
	typedef void (*Animator_GetGoalRotation_Injected_m76092248C853479A1E6178DA4AF19F69FF8C8F75_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, int32_t, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974*);
	static Animator_GetGoalRotation_Injected_m76092248C853479A1E6178DA4AF19F69FF8C8F75_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetGoalRotation_Injected_m76092248C853479A1E6178DA4AF19F69FF8C8F75_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetGoalRotation_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Quaternion&)");
	_il2cpp_icall_func(__this, ___0_goal, ___1_ret);
}
// System.Void UnityEngine.Animator::SetGoalRotation_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalRotation_Injected_m93587602A0C43AC9B184D30B03F751C02E6BF045 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___0_goal, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974* ___1_goalRotation, const RuntimeMethod* method) 
{
	typedef void (*Animator_SetGoalRotation_Injected_m93587602A0C43AC9B184D30B03F751C02E6BF045_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, int32_t, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974*);
	static Animator_SetGoalRotation_Injected_m93587602A0C43AC9B184D30B03F751C02E6BF045_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetGoalRotation_Injected_m93587602A0C43AC9B184D30B03F751C02E6BF045_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetGoalRotation_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Quaternion&)");
	_il2cpp_icall_func(__this, ___0_goal, ___1_goalRotation);
}
// System.Void UnityEngine.Animator::SetLookAtPositionInternal_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLookAtPositionInternal_Injected_mE50AFECADA7DC76D0E73C6B7131EBBD1CED5D59D (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_lookAtPosition, const RuntimeMethod* method) 
{
	typedef void (*Animator_SetLookAtPositionInternal_Injected_mE50AFECADA7DC76D0E73C6B7131EBBD1CED5D59D_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*);
	static Animator_SetLookAtPositionInternal_Injected_mE50AFECADA7DC76D0E73C6B7131EBBD1CED5D59D_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetLookAtPositionInternal_Injected_mE50AFECADA7DC76D0E73C6B7131EBBD1CED5D59D_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetLookAtPositionInternal_Injected(UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___0_lookAtPosition);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.AnimationClip::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip__ctor_m3F9B3DE671547640479DB976423EEBC689D26F79 (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* __this, const RuntimeMethod* method) 
{
	{
		Motion__ctor_mB6190858E566BFA1B80D2E94B65CD27920A49443(__this, NULL);
		AnimationClip_Internal_CreateAnimationClip_m1410C35D6386CEA1F068C9314751D0F6A7D34789(__this, NULL);
		return;
	}
}
// System.Void UnityEngine.AnimationClip::Internal_CreateAnimationClip(UnityEngine.AnimationClip)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_Internal_CreateAnimationClip_m1410C35D6386CEA1F068C9314751D0F6A7D34789 (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* ___0_self, const RuntimeMethod* method) 
{
	typedef void (*AnimationClip_Internal_CreateAnimationClip_m1410C35D6386CEA1F068C9314751D0F6A7D34789_ftn) (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712*);
	static AnimationClip_Internal_CreateAnimationClip_m1410C35D6386CEA1F068C9314751D0F6A7D34789_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_Internal_CreateAnimationClip_m1410C35D6386CEA1F068C9314751D0F6A7D34789_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::Internal_CreateAnimationClip(UnityEngine.AnimationClip)");
	_il2cpp_icall_func(___0_self);
}
// System.Single UnityEngine.AnimationClip::get_length()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimationClip_get_length_mAD91A1C134662285F26886489AC2D8E0EC79AF41 (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* __this, const RuntimeMethod* method) 
{
	typedef float (*AnimationClip_get_length_mAD91A1C134662285F26886489AC2D8E0EC79AF41_ftn) (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712*);
	static AnimationClip_get_length_mAD91A1C134662285F26886489AC2D8E0EC79AF41_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_length_mAD91A1C134662285F26886489AC2D8E0EC79AF41_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_length()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Single UnityEngine.AnimationClip::get_frameRate()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimationClip_get_frameRate_mBECE2AAD43501FB8CE2E5F4302BD2989066AF242 (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* __this, const RuntimeMethod* method) 
{
	typedef float (*AnimationClip_get_frameRate_mBECE2AAD43501FB8CE2E5F4302BD2989066AF242_ftn) (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712*);
	static AnimationClip_get_frameRate_mBECE2AAD43501FB8CE2E5F4302BD2989066AF242_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_frameRate_mBECE2AAD43501FB8CE2E5F4302BD2989066AF242_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_frameRate()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.AnimationClip::set_frameRate(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_set_frameRate_m68E3FF5D77738194EFEC9279F1B3FB1FCFEEED74 (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* __this, float ___0_value, const RuntimeMethod* method) 
{
	typedef void (*AnimationClip_set_frameRate_m68E3FF5D77738194EFEC9279F1B3FB1FCFEEED74_ftn) (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712*, float);
	static AnimationClip_set_frameRate_m68E3FF5D77738194EFEC9279F1B3FB1FCFEEED74_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_set_frameRate_m68E3FF5D77738194EFEC9279F1B3FB1FCFEEED74_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::set_frameRate(System.Single)");
	_il2cpp_icall_func(__this, ___0_value);
}
// System.Boolean UnityEngine.AnimationClip::get_legacy()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClip_get_legacy_m2ACB9171DA504B26635D0C0CFF64D5F4DEF9C82B (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* __this, const RuntimeMethod* method) 
{
	typedef bool (*AnimationClip_get_legacy_m2ACB9171DA504B26635D0C0CFF64D5F4DEF9C82B_ftn) (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712*);
	static AnimationClip_get_legacy_m2ACB9171DA504B26635D0C0CFF64D5F4DEF9C82B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_legacy_m2ACB9171DA504B26635D0C0CFF64D5F4DEF9C82B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_legacy()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.AnimationClip::set_legacy(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_set_legacy_mA24DEDCB86CB9439005B71B6916C09C751731377 (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* __this, bool ___0_value, const RuntimeMethod* method) 
{
	typedef void (*AnimationClip_set_legacy_mA24DEDCB86CB9439005B71B6916C09C751731377_ftn) (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712*, bool);
	static AnimationClip_set_legacy_mA24DEDCB86CB9439005B71B6916C09C751731377_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_set_legacy_mA24DEDCB86CB9439005B71B6916C09C751731377_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::set_legacy(System.Boolean)");
	_il2cpp_icall_func(__this, ___0_value);
}
// System.Boolean UnityEngine.AnimationClip::get_empty()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClip_get_empty_mA55084A0DDBE57E75DC412FCEE2285626E76B986 (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* __this, const RuntimeMethod* method) 
{
	typedef bool (*AnimationClip_get_empty_mA55084A0DDBE57E75DC412FCEE2285626E76B986_ftn) (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712*);
	static AnimationClip_get_empty_mA55084A0DDBE57E75DC412FCEE2285626E76B986_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_empty_mA55084A0DDBE57E75DC412FCEE2285626E76B986_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_empty()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.AnimationClip::get_hasGenericRootTransform()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClip_get_hasGenericRootTransform_mED40404C94754A7CE75E96EF8C2CE35CB71B343F (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* __this, const RuntimeMethod* method) 
{
	typedef bool (*AnimationClip_get_hasGenericRootTransform_mED40404C94754A7CE75E96EF8C2CE35CB71B343F_ftn) (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712*);
	static AnimationClip_get_hasGenericRootTransform_mED40404C94754A7CE75E96EF8C2CE35CB71B343F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_hasGenericRootTransform_mED40404C94754A7CE75E96EF8C2CE35CB71B343F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_hasGenericRootTransform()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.AnimationClip::get_hasMotionCurves()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClip_get_hasMotionCurves_m36F62751D417AC698D8D60A5C43E4EAA49B4FDAF (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* __this, const RuntimeMethod* method) 
{
	typedef bool (*AnimationClip_get_hasMotionCurves_m36F62751D417AC698D8D60A5C43E4EAA49B4FDAF_ftn) (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712*);
	static AnimationClip_get_hasMotionCurves_m36F62751D417AC698D8D60A5C43E4EAA49B4FDAF_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_hasMotionCurves_m36F62751D417AC698D8D60A5C43E4EAA49B4FDAF_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_hasMotionCurves()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.AnimationClip::get_hasRootCurves()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClip_get_hasRootCurves_mD871E5382B94163A7CA3B917BBAC50F0E1405B81 (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* __this, const RuntimeMethod* method) 
{
	typedef bool (*AnimationClip_get_hasRootCurves_mD871E5382B94163A7CA3B917BBAC50F0E1405B81_ftn) (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712*);
	static AnimationClip_get_hasRootCurves_mD871E5382B94163A7CA3B917BBAC50F0E1405B81_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_hasRootCurves_mD871E5382B94163A7CA3B917BBAC50F0E1405B81_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_hasRootCurves()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.AnimationClip::get_hasRootMotion()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClip_get_hasRootMotion_mF736536B45B62D56EBD402A8A033767A88CFAE3E (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* __this, const RuntimeMethod* method) 
{
	typedef bool (*AnimationClip_get_hasRootMotion_mF736536B45B62D56EBD402A8A033767A88CFAE3E_ftn) (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712*);
	static AnimationClip_get_hasRootMotion_mF736536B45B62D56EBD402A8A033767A88CFAE3E_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_hasRootMotion_mF736536B45B62D56EBD402A8A033767A88CFAE3E_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_hasRootMotion()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// UnityEngine.AnimationEvent[] UnityEngine.AnimationClip::get_events()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationEventU5BU5D_t7618D98124AE2DE212E31279AD51EB4D9CEEAA9E* AnimationClip_get_events_m700FBB913D1FD2E715139B5C9D9D03B6D8B0078D (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationEventU5BU5D_t7618D98124AE2DE212E31279AD51EB4D9CEEAA9E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	AnimationEventU5BU5D_t7618D98124AE2DE212E31279AD51EB4D9CEEAA9E* V_0 = NULL;
	{
		RuntimeArray* L_0;
		L_0 = AnimationClip_GetEventsInternal_mF2E21B70DC3E96105B7F696767FEA06400EF805F(__this, NULL);
		V_0 = ((AnimationEventU5BU5D_t7618D98124AE2DE212E31279AD51EB4D9CEEAA9E*)Castclass((RuntimeObject*)L_0, AnimationEventU5BU5D_t7618D98124AE2DE212E31279AD51EB4D9CEEAA9E_il2cpp_TypeInfo_var));
		goto IL_000f;
	}

IL_000f:
	{
		AnimationEventU5BU5D_t7618D98124AE2DE212E31279AD51EB4D9CEEAA9E* L_1 = V_0;
		return L_1;
	}
}
// System.Array UnityEngine.AnimationClip::GetEventsInternal()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeArray* AnimationClip_GetEventsInternal_mF2E21B70DC3E96105B7F696767FEA06400EF805F (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* __this, const RuntimeMethod* method) 
{
	typedef RuntimeArray* (*AnimationClip_GetEventsInternal_mF2E21B70DC3E96105B7F696767FEA06400EF805F_ftn) (AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712*);
	static AnimationClip_GetEventsInternal_mF2E21B70DC3E96105B7F696767FEA06400EF805F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_GetEventsInternal_mF2E21B70DC3E96105B7F696767FEA06400EF805F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::GetEventsInternal()");
	RuntimeArray* icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.StateMachineBehaviour::OnStateEnter(UnityEngine.Animator,UnityEngine.AnimatorStateInfo,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateEnter_mB618EFE75A50CBAA3EE6471E64A3E2CA2A2C90FD (StateMachineBehaviour_t59C5685227B06222F5AF7027E2DA530AB99AFDF7* __this, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 ___1_stateInfo, int32_t ___2_layerIndex, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateUpdate(UnityEngine.Animator,UnityEngine.AnimatorStateInfo,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateUpdate_mC1A83A4F693AF3AB51BC592A0CE525CE4F320D6B (StateMachineBehaviour_t59C5685227B06222F5AF7027E2DA530AB99AFDF7* __this, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 ___1_stateInfo, int32_t ___2_layerIndex, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateExit(UnityEngine.Animator,UnityEngine.AnimatorStateInfo,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateExit_mC113F0B2F53847F9A6755B82D0AC53C971171CFD (StateMachineBehaviour_t59C5685227B06222F5AF7027E2DA530AB99AFDF7* __this, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 ___1_stateInfo, int32_t ___2_layerIndex, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateMove(UnityEngine.Animator,UnityEngine.AnimatorStateInfo,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateMove_m7229D5EFBA432665B9046FC3C21D463FFD281978 (StateMachineBehaviour_t59C5685227B06222F5AF7027E2DA530AB99AFDF7* __this, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 ___1_stateInfo, int32_t ___2_layerIndex, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateIK(UnityEngine.Animator,UnityEngine.AnimatorStateInfo,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateIK_m310C17694D8D1B9D60D549259A39837F22FD3240 (StateMachineBehaviour_t59C5685227B06222F5AF7027E2DA530AB99AFDF7* __this, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 ___1_stateInfo, int32_t ___2_layerIndex, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateMachineEnter(UnityEngine.Animator,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateMachineEnter_m0CEFF9E4946BFDC4F7066BEB4C961169DBC5073F (StateMachineBehaviour_t59C5685227B06222F5AF7027E2DA530AB99AFDF7* __this, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, int32_t ___1_stateMachinePathHash, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateMachineExit(UnityEngine.Animator,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateMachineExit_m384B808E3961C6C2C375DF7487EF2B49E44E6CD7 (StateMachineBehaviour_t59C5685227B06222F5AF7027E2DA530AB99AFDF7* __this, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, int32_t ___1_stateMachinePathHash, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateEnter(UnityEngine.Animator,UnityEngine.AnimatorStateInfo,System.Int32,UnityEngine.Animations.AnimatorControllerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateEnter_m491D81A9A64DE4AE02415A5909B74AE947EAE1B9 (StateMachineBehaviour_t59C5685227B06222F5AF7027E2DA530AB99AFDF7* __this, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 ___1_stateInfo, int32_t ___2_layerIndex, AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A ___3_controller, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateUpdate(UnityEngine.Animator,UnityEngine.AnimatorStateInfo,System.Int32,UnityEngine.Animations.AnimatorControllerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateUpdate_mF3130BE7BDD7C8B2470303FB1986A336E47CC98C (StateMachineBehaviour_t59C5685227B06222F5AF7027E2DA530AB99AFDF7* __this, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 ___1_stateInfo, int32_t ___2_layerIndex, AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A ___3_controller, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateExit(UnityEngine.Animator,UnityEngine.AnimatorStateInfo,System.Int32,UnityEngine.Animations.AnimatorControllerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateExit_mD47A506ACE251A6341115CBE5607D05C01747127 (StateMachineBehaviour_t59C5685227B06222F5AF7027E2DA530AB99AFDF7* __this, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 ___1_stateInfo, int32_t ___2_layerIndex, AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A ___3_controller, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateMove(UnityEngine.Animator,UnityEngine.AnimatorStateInfo,System.Int32,UnityEngine.Animations.AnimatorControllerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateMove_m1A01C10E754426572C7BBA7AA13044FDA372FDFC (StateMachineBehaviour_t59C5685227B06222F5AF7027E2DA530AB99AFDF7* __this, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 ___1_stateInfo, int32_t ___2_layerIndex, AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A ___3_controller, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateIK(UnityEngine.Animator,UnityEngine.AnimatorStateInfo,System.Int32,UnityEngine.Animations.AnimatorControllerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateIK_mCE3B4C71868B564EE6BE4B8663535058705C3B72 (StateMachineBehaviour_t59C5685227B06222F5AF7027E2DA530AB99AFDF7* __this, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 ___1_stateInfo, int32_t ___2_layerIndex, AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A ___3_controller, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateMachineEnter(UnityEngine.Animator,System.Int32,UnityEngine.Animations.AnimatorControllerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateMachineEnter_m0399B12419A4F990F41BD589C833E2D2C0076762 (StateMachineBehaviour_t59C5685227B06222F5AF7027E2DA530AB99AFDF7* __this, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, int32_t ___1_stateMachinePathHash, AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A ___2_controller, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateMachineExit(UnityEngine.Animator,System.Int32,UnityEngine.Animations.AnimatorControllerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateMachineExit_mF8BB1A8851B0699FC1D85F538E16EF12C08BBB93 (StateMachineBehaviour_t59C5685227B06222F5AF7027E2DA530AB99AFDF7* __this, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, int32_t ___1_stateMachinePathHash, AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A ___2_controller, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour__ctor_m9663A75D1016E16D7E3A48E2D4E6466A041A00AB (StateMachineBehaviour_t59C5685227B06222F5AF7027E2DA530AB99AFDF7* __this, const RuntimeMethod* method) 
{
	{
		ScriptableObject__ctor_mD037FDB0B487295EA47F79A4DB1BF1846C9087FF(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Playables.AnimationPlayableUtilities::Play(UnityEngine.Animator,UnityEngine.Playables.Playable,UnityEngine.Playables.PlayableGraph)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationPlayableUtilities_Play_mACCC886DED3FE540B663261AF5EB6EF28510FB5B (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F ___1_playable, PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___2_graph, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableOutputExtensions_SetSourcePlayable_TisAnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E_TisPlayable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F_m015148BFEF9CA1BBC4DE5625B47A768D4B51A543_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9A0B8F8C43A11ED8E1400C04557C40AC52384963);
		s_Il2CppMethodInitialized = true;
	}
	AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_0 = ___2_graph;
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_1 = ___0_animator;
		AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E L_2;
		L_2 = AnimationPlayableOutput_Create_m65847A70F6C74854387814C5B1D4C281B6CCCDC4(L_0, _stringLiteral9A0B8F8C43A11ED8E1400C04557C40AC52384963, L_1, NULL);
		V_0 = L_2;
		AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E L_3 = V_0;
		Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F L_4 = ___1_playable;
		PlayableOutputExtensions_SetSourcePlayable_TisAnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E_TisPlayable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F_m015148BFEF9CA1BBC4DE5625B47A768D4B51A543(L_3, L_4, 0, PlayableOutputExtensions_SetSourcePlayable_TisAnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E_TisPlayable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F_m015148BFEF9CA1BBC4DE5625B47A768D4B51A543_RuntimeMethod_var);
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_5 = ___2_graph;
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_6 = ___0_animator;
		AnimationPlayableGraphExtensions_SyncUpdateAndTimeMode_mBF6173908DA7C04947C405230A1D66F108E7F493(L_5, L_6, NULL);
		PlayableGraph_Play_mE2A27205C369339BB8B39B9CCBF5F5EE9B26F9A6((&___2_graph), NULL);
		return;
	}
}
// UnityEngine.Animations.AnimationClipPlayable UnityEngine.Playables.AnimationPlayableUtilities::PlayClip(UnityEngine.Animator,UnityEngine.AnimationClip,UnityEngine.Playables.PlayableGraph&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 AnimationPlayableUtilities_PlayClip_mC82BC4ABA6B41BDFAC321707E019FDDF713CFC0F (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* ___1_clip, PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___2_graph, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableOutputExtensions_SetSourcePlayable_TisAnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E_TisAnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969_m389C7055BB3E25FF8CC06AF5A9F6EE1BE821B43D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9A0B8F8C43A11ED8E1400C04557C40AC52384963);
		s_Il2CppMethodInitialized = true;
	}
	AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E V_0;
	memset((&V_0), 0, sizeof(V_0));
	AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 V_1;
	memset((&V_1), 0, sizeof(V_1));
	AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 V_2;
	memset((&V_2), 0, sizeof(V_2));
	{
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* L_0 = ___2_graph;
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_1;
		L_1 = PlayableGraph_Create_mCAFF6F9DA9B2E26ABA61692903EF3F454608A4A7(NULL);
		*(PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E*)L_0 = L_1;
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* L_2 = ___2_graph;
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_3 = (*(PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E*)L_2);
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_4 = ___0_animator;
		AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E L_5;
		L_5 = AnimationPlayableOutput_Create_m65847A70F6C74854387814C5B1D4C281B6CCCDC4(L_3, _stringLiteral9A0B8F8C43A11ED8E1400C04557C40AC52384963, L_4, NULL);
		V_0 = L_5;
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* L_6 = ___2_graph;
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_7 = (*(PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E*)L_6);
		AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* L_8 = ___1_clip;
		AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 L_9;
		L_9 = AnimationClipPlayable_Create_m034A4A30AC2642E675B95A0A7C3C384F533F5C1A(L_7, L_8, NULL);
		V_1 = L_9;
		AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E L_10 = V_0;
		AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 L_11 = V_1;
		PlayableOutputExtensions_SetSourcePlayable_TisAnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E_TisAnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969_m389C7055BB3E25FF8CC06AF5A9F6EE1BE821B43D(L_10, L_11, PlayableOutputExtensions_SetSourcePlayable_TisAnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E_TisAnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969_m389C7055BB3E25FF8CC06AF5A9F6EE1BE821B43D_RuntimeMethod_var);
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* L_12 = ___2_graph;
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_13 = (*(PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E*)L_12);
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_14 = ___0_animator;
		AnimationPlayableGraphExtensions_SyncUpdateAndTimeMode_mBF6173908DA7C04947C405230A1D66F108E7F493(L_13, L_14, NULL);
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* L_15 = ___2_graph;
		PlayableGraph_Play_mE2A27205C369339BB8B39B9CCBF5F5EE9B26F9A6(L_15, NULL);
		AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 L_16 = V_1;
		V_2 = L_16;
		goto IL_004b;
	}

IL_004b:
	{
		AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 L_17 = V_2;
		return L_17;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Animations.AnimationRemoveScalePlayable UnityEngine.Animations.AnimationRemoveScalePlayable::Create(UnityEngine.Playables.PlayableGraph,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD AnimationRemoveScalePlayable_Create_mABCE46803804604412781B86B321BE816649401C (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, int32_t ___1_inputCount, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_0 = ___0_graph;
		int32_t L_1 = ___1_inputCount;
		il2cpp_codegen_runtime_class_init_inline(AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_2;
		L_2 = AnimationRemoveScalePlayable_CreateHandle_mE15186AF821904AC09E8F0DC30096BF63A812D66(L_0, L_1, NULL);
		V_0 = L_2;
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_3 = V_0;
		AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD L_4;
		memset((&L_4), 0, sizeof(L_4));
		AnimationRemoveScalePlayable__ctor_m4D6C7C4AB8E078050B0CC34C6732051CF043CFA2((&L_4), L_3, /*hidden argument*/NULL);
		V_1 = L_4;
		goto IL_0012;
	}

IL_0012:
	{
		AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD L_5 = V_1;
		return L_5;
	}
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationRemoveScalePlayable::CreateHandle(UnityEngine.Playables.PlayableGraph,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationRemoveScalePlayable_CreateHandle_mE15186AF821904AC09E8F0DC30096BF63A812D66 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, int32_t ___1_inputCount, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	bool V_1 = false;
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_2;
	memset((&V_2), 0, sizeof(V_2));
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		V_0 = L_0;
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_1 = ___0_graph;
		il2cpp_codegen_runtime_class_init_inline(AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = AnimationRemoveScalePlayable_CreateHandleInternal_mDB6C3A766BA756328A459D4EBB356A8F8E289FD1(L_1, (&V_0), NULL);
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_001e;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_4;
		L_4 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		V_2 = L_4;
		goto IL_002b;
	}

IL_001e:
	{
		int32_t L_5 = ___1_inputCount;
		PlayableHandle_SetInputCount_m6067CD3616C428F777903FCBFD789060A2185DEE((&V_0), L_5, NULL);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_6 = V_0;
		V_2 = L_6;
		goto IL_002b;
	}

IL_002b:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_7 = V_2;
		return L_7;
	}
}
// System.Void UnityEngine.Animations.AnimationRemoveScalePlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationRemoveScalePlayable__ctor_m4D6C7C4AB8E078050B0CC34C6732051CF043CFA2 (AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_IsPlayableOfType_TisAnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD_m961964786905D9B20B750AC27CB64EA48C4C5971_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		bool L_0;
		L_0 = PlayableHandle_IsValid_m07631D12846BAAF2CC302E69A28A44BFE9EB5098((&___0_handle), NULL);
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0027;
		}
	}
	{
		bool L_2;
		L_2 = PlayableHandle_IsPlayableOfType_TisAnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD_m961964786905D9B20B750AC27CB64EA48C4C5971((&___0_handle), PlayableHandle_IsPlayableOfType_TisAnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD_m961964786905D9B20B750AC27CB64EA48C4C5971_RuntimeMethod_var);
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0026;
		}
	}
	{
		InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E* L_4 = (InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E_il2cpp_TypeInfo_var)));
		NullCheck(L_4);
		InvalidCastException__ctor_mED3F9781E6CA47A92C602C896EDDF2F40ECB8644(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral98C704D69BD1A288ED31DEE4ED4E50097A2D7018)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationRemoveScalePlayable__ctor_m4D6C7C4AB8E078050B0CC34C6732051CF043CFA2_RuntimeMethod_var)));
	}

IL_0026:
	{
	}

IL_0027:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_5 = ___0_handle;
		__this->___m_Handle_0 = L_5;
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationRemoveScalePlayable__ctor_m4D6C7C4AB8E078050B0CC34C6732051CF043CFA2_AdjustorThunk (RuntimeObject* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method)
{
	AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD*>(__this + _offset);
	AnimationRemoveScalePlayable__ctor_m4D6C7C4AB8E078050B0CC34C6732051CF043CFA2(_thisAdjusted, ___0_handle, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationRemoveScalePlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationRemoveScalePlayable_GetHandle_mFFA58B879F31327187A20ED30E1C814B7BEAA9C6 (AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD* __this, const RuntimeMethod* method) 
{
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0 = __this->___m_Handle_0;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationRemoveScalePlayable_GetHandle_mFFA58B879F31327187A20ED30E1C814B7BEAA9C6_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD*>(__this + _offset);
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 _returnValue;
	_returnValue = AnimationRemoveScalePlayable_GetHandle_mFFA58B879F31327187A20ED30E1C814B7BEAA9C6(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.Playables.Playable UnityEngine.Animations.AnimationRemoveScalePlayable::op_Implicit(UnityEngine.Animations.AnimationRemoveScalePlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F AnimationRemoveScalePlayable_op_Implicit_m0658568E028F0099166238728756300A839F0606 (AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD ___0_playable, const RuntimeMethod* method) 
{
	Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = AnimationRemoveScalePlayable_GetHandle_mFFA58B879F31327187A20ED30E1C814B7BEAA9C6((&___0_playable), NULL);
		Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F L_1;
		memset((&L_1), 0, sizeof(L_1));
		Playable__ctor_mD2EB35E024816AEED68795D0124EAB30E05BF6C4((&L_1), L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F L_2 = V_0;
		return L_2;
	}
}
// System.Boolean UnityEngine.Animations.AnimationRemoveScalePlayable::Equals(UnityEngine.Animations.AnimationRemoveScalePlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationRemoveScalePlayable_Equals_m0ACDD59B80103591DA8E84CB387FB10778D8C327 (AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD* __this, AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD ___0_other, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = AnimationRemoveScalePlayable_GetHandle_mFFA58B879F31327187A20ED30E1C814B7BEAA9C6((&___0_other), NULL);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_1 = L_0;
		RuntimeObject* L_2 = Box(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var, &L_1);
		Il2CppFakeBox<AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD> L_3(AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD_il2cpp_TypeInfo_var, __this);
		bool L_4;
		L_4 = ValueType_Equals_mCA5344597A8055EC544855AD60A983B10E0EE67D((ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F*)(&L_3), L_2, NULL);
		V_0 = L_4;
		goto IL_001c;
	}

IL_001c:
	{
		bool L_5 = V_0;
		return L_5;
	}
}
IL2CPP_EXTERN_C  bool AnimationRemoveScalePlayable_Equals_m0ACDD59B80103591DA8E84CB387FB10778D8C327_AdjustorThunk (RuntimeObject* __this, AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD ___0_other, const RuntimeMethod* method)
{
	AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD*>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimationRemoveScalePlayable_Equals_m0ACDD59B80103591DA8E84CB387FB10778D8C327(_thisAdjusted, ___0_other, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.AnimationRemoveScalePlayable::CreateHandleInternal(UnityEngine.Playables.PlayableGraph,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationRemoveScalePlayable_CreateHandleInternal_mDB6C3A766BA756328A459D4EBB356A8F8E289FD1 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___1_handle, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = ___1_handle;
		il2cpp_codegen_runtime_class_init_inline(AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = AnimationRemoveScalePlayable_CreateHandleInternal_Injected_m0ED3A968526682B946A2D157855A91B93CDE9A13((&___0_graph), L_0, NULL);
		return L_1;
	}
}
// System.Void UnityEngine.Animations.AnimationRemoveScalePlayable::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationRemoveScalePlayable__cctor_m42E614B0B33898D92DFE06CA6045698BE94DE633 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD L_1;
		memset((&L_1), 0, sizeof(L_1));
		AnimationRemoveScalePlayable__ctor_m4D6C7C4AB8E078050B0CC34C6732051CF043CFA2((&L_1), L_0, /*hidden argument*/NULL);
		((AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD_StaticFields*)il2cpp_codegen_static_fields_for(AnimationRemoveScalePlayable_t915611F6D3CC150DDCAF56412AC3E5ACB518A9DD_il2cpp_TypeInfo_var))->___m_NullPlayable_1 = L_1;
		return;
	}
}
// System.Boolean UnityEngine.Animations.AnimationRemoveScalePlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationRemoveScalePlayable_CreateHandleInternal_Injected_m0ED3A968526682B946A2D157855A91B93CDE9A13 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___1_handle, const RuntimeMethod* method) 
{
	typedef bool (*AnimationRemoveScalePlayable_CreateHandleInternal_Injected_m0ED3A968526682B946A2D157855A91B93CDE9A13_ftn) (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E*, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*);
	static AnimationRemoveScalePlayable_CreateHandleInternal_Injected_m0ED3A968526682B946A2D157855A91B93CDE9A13_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationRemoveScalePlayable_CreateHandleInternal_Injected_m0ED3A968526682B946A2D157855A91B93CDE9A13_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationRemoveScalePlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Playables.PlayableHandle&)");
	bool icallRetVal = _il2cpp_icall_func(___0_graph, ___1_handle);
	return icallRetVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Animations.AnimatorControllerPlayable UnityEngine.Animations.AnimatorControllerPlayable::Create(UnityEngine.Playables.PlayableGraph,UnityEngine.RuntimeAnimatorController)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A AnimatorControllerPlayable_Create_m2A01CF0D8E08995514A106B713E30021E39E8333 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, RuntimeAnimatorController_t6F7C753402B42EC23C163099CF935C5E0D7A7254* ___1_controller, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_0 = ___0_graph;
		RuntimeAnimatorController_t6F7C753402B42EC23C163099CF935C5E0D7A7254* L_1 = ___1_controller;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_2;
		L_2 = AnimatorControllerPlayable_CreateHandle_mEC5A01894B274C6EC5AD8FBD84688C29AFBCF698(L_0, L_1, NULL);
		V_0 = L_2;
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_3 = V_0;
		AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A L_4;
		memset((&L_4), 0, sizeof(L_4));
		AnimatorControllerPlayable__ctor_mBCB9475E2740BE1AEB94C08BAD14D51333258BFE((&L_4), L_3, /*hidden argument*/NULL);
		V_1 = L_4;
		goto IL_0012;
	}

IL_0012:
	{
		AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A L_5 = V_1;
		return L_5;
	}
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimatorControllerPlayable::CreateHandle(UnityEngine.Playables.PlayableGraph,UnityEngine.RuntimeAnimatorController)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimatorControllerPlayable_CreateHandle_mEC5A01894B274C6EC5AD8FBD84688C29AFBCF698 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, RuntimeAnimatorController_t6F7C753402B42EC23C163099CF935C5E0D7A7254* ___1_controller, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	bool V_1 = false;
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_2;
	memset((&V_2), 0, sizeof(V_2));
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		V_0 = L_0;
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_1 = ___0_graph;
		RuntimeAnimatorController_t6F7C753402B42EC23C163099CF935C5E0D7A7254* L_2 = ___1_controller;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = AnimatorControllerPlayable_CreateHandleInternal_mF52B5F176A31C938DF5909127B27B1E78E3863D4(L_1, L_2, (&V_0), NULL);
		V_1 = (bool)((((int32_t)L_3) == ((int32_t)0))? 1 : 0);
		bool L_4 = V_1;
		if (!L_4)
		{
			goto IL_001f;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_5;
		L_5 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		V_2 = L_5;
		goto IL_0023;
	}

IL_001f:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_6 = V_0;
		V_2 = L_6;
		goto IL_0023;
	}

IL_0023:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_7 = V_2;
		return L_7;
	}
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable__ctor_mBCB9475E2740BE1AEB94C08BAD14D51333258BFE (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		__this->___m_Handle_0 = L_0;
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_1 = ___0_handle;
		AnimatorControllerPlayable_SetHandle_mD86A3C0D03453FAF21903F7A52A743AB2DA6DED4(__this, L_1, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable__ctor_mBCB9475E2740BE1AEB94C08BAD14D51333258BFE_AdjustorThunk (RuntimeObject* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable__ctor_mBCB9475E2740BE1AEB94C08BAD14D51333258BFE(_thisAdjusted, ___0_handle, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimatorControllerPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimatorControllerPlayable_GetHandle_m718D9A4E0DB7AC62947B1D09E47DBCD25C27AF6C (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, const RuntimeMethod* method) 
{
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0 = __this->___m_Handle_0;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimatorControllerPlayable_GetHandle_m718D9A4E0DB7AC62947B1D09E47DBCD25C27AF6C_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 _returnValue;
	_returnValue = AnimatorControllerPlayable_GetHandle_m718D9A4E0DB7AC62947B1D09E47DBCD25C27AF6C(_thisAdjusted, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetHandle(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetHandle_mD86A3C0D03453FAF21903F7A52A743AB2DA6DED4 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_IsPlayableOfType_TisAnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_m83ED61FDEBC627830082467B83BF64724C68CD70_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	bool V_2 = false;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		bool L_1;
		L_1 = PlayableHandle_IsValid_m07631D12846BAAF2CC302E69A28A44BFE9EB5098(L_0, NULL);
		V_0 = L_1;
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_001b;
		}
	}
	{
		InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB* L_3 = (InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB_il2cpp_TypeInfo_var)));
		NullCheck(L_3);
		InvalidOperationException__ctor_mE4CB6F4712AB6D99A2358FBAE2E052B3EE976162(L_3, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralBF563F6FCC25CE41FFE0BF7590AF9F4475916665)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_3, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimatorControllerPlayable_SetHandle_mD86A3C0D03453FAF21903F7A52A743AB2DA6DED4_RuntimeMethod_var)));
	}

IL_001b:
	{
		bool L_4;
		L_4 = PlayableHandle_IsValid_m07631D12846BAAF2CC302E69A28A44BFE9EB5098((&___0_handle), NULL);
		V_1 = L_4;
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_0041;
		}
	}
	{
		bool L_6;
		L_6 = PlayableHandle_IsPlayableOfType_TisAnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_m83ED61FDEBC627830082467B83BF64724C68CD70((&___0_handle), PlayableHandle_IsPlayableOfType_TisAnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_m83ED61FDEBC627830082467B83BF64724C68CD70_RuntimeMethod_var);
		V_2 = (bool)((((int32_t)L_6) == ((int32_t)0))? 1 : 0);
		bool L_7 = V_2;
		if (!L_7)
		{
			goto IL_0040;
		}
	}
	{
		InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E* L_8 = (InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E_il2cpp_TypeInfo_var)));
		NullCheck(L_8);
		InvalidCastException__ctor_mED3F9781E6CA47A92C602C896EDDF2F40ECB8644(L_8, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralF5510C45DDAD777CCB4893578D995C9739F990F2)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_8, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimatorControllerPlayable_SetHandle_mD86A3C0D03453FAF21903F7A52A743AB2DA6DED4_RuntimeMethod_var)));
	}

IL_0040:
	{
	}

IL_0041:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_9 = ___0_handle;
		__this->___m_Handle_0 = L_9;
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_SetHandle_mD86A3C0D03453FAF21903F7A52A743AB2DA6DED4_AdjustorThunk (RuntimeObject* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_SetHandle_mD86A3C0D03453FAF21903F7A52A743AB2DA6DED4(_thisAdjusted, ___0_handle, method);
}
// UnityEngine.Playables.Playable UnityEngine.Animations.AnimatorControllerPlayable::op_Implicit(UnityEngine.Animations.AnimatorControllerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F AnimatorControllerPlayable_op_Implicit_m728BDEDB8AA352D8535567FFEEA678E6DE300922 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A ___0_playable, const RuntimeMethod* method) 
{
	Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = AnimatorControllerPlayable_GetHandle_m718D9A4E0DB7AC62947B1D09E47DBCD25C27AF6C((&___0_playable), NULL);
		Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F L_1;
		memset((&L_1), 0, sizeof(L_1));
		Playable__ctor_mD2EB35E024816AEED68795D0124EAB30E05BF6C4((&L_1), L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F L_2 = V_0;
		return L_2;
	}
}
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::Equals(UnityEngine.Animations.AnimatorControllerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_Equals_m14125BB4CCFCDFFD098223AF20E38501BA264180 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A ___0_other, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = AnimatorControllerPlayable_GetHandle_m718D9A4E0DB7AC62947B1D09E47DBCD25C27AF6C(__this, NULL);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_1;
		L_1 = AnimatorControllerPlayable_GetHandle_m718D9A4E0DB7AC62947B1D09E47DBCD25C27AF6C((&___0_other), NULL);
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = PlayableHandle_op_Equality_m0E6C48A28F75A870AC22ADE3BD42F7F70A43C99C(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0016;
	}

IL_0016:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool AnimatorControllerPlayable_Equals_m14125BB4CCFCDFFD098223AF20E38501BA264180_AdjustorThunk (RuntimeObject* __this, AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A ___0_other, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimatorControllerPlayable_Equals_m14125BB4CCFCDFFD098223AF20E38501BA264180(_thisAdjusted, ___0_other, method);
	return _returnValue;
}
// System.Single UnityEngine.Animations.AnimatorControllerPlayable::GetFloat(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorControllerPlayable_GetFloat_m787538C1B2ED9C4E52E8A3EEF43405913E82E895 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_name, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		String_t* L_1 = ___0_name;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		float L_2;
		L_2 = AnimatorControllerPlayable_GetFloatString_m1DADE177E526468221C892871355B7E0371DC7B5(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		float L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  float AnimatorControllerPlayable_GetFloat_m787538C1B2ED9C4E52E8A3EEF43405913E82E895_AdjustorThunk (RuntimeObject* __this, String_t* ___0_name, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	float _returnValue;
	_returnValue = AnimatorControllerPlayable_GetFloat_m787538C1B2ED9C4E52E8A3EEF43405913E82E895(_thisAdjusted, ___0_name, method);
	return _returnValue;
}
// System.Single UnityEngine.Animations.AnimatorControllerPlayable::GetFloat(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorControllerPlayable_GetFloat_mDBD6169B671FCD0AA3551368A3EE37334E7D7B49 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_id, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_id;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		float L_2;
		L_2 = AnimatorControllerPlayable_GetFloatID_m4EDF8B5F43B2F67DDCF3A566C520E99AF92316E0(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		float L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  float AnimatorControllerPlayable_GetFloat_mDBD6169B671FCD0AA3551368A3EE37334E7D7B49_AdjustorThunk (RuntimeObject* __this, int32_t ___0_id, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	float _returnValue;
	_returnValue = AnimatorControllerPlayable_GetFloat_mDBD6169B671FCD0AA3551368A3EE37334E7D7B49(_thisAdjusted, ___0_id, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetFloat(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetFloat_m95BF662BF3AA8A4F4B5F868801DED66D397E2407 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_name, float ___1_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		String_t* L_1 = ___0_name;
		float L_2 = ___1_value;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorControllerPlayable_SetFloatString_m0F0870A5299A2CF4AFC6C65832D189A5D04D4FD5(L_0, L_1, L_2, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_SetFloat_m95BF662BF3AA8A4F4B5F868801DED66D397E2407_AdjustorThunk (RuntimeObject* __this, String_t* ___0_name, float ___1_value, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_SetFloat_m95BF662BF3AA8A4F4B5F868801DED66D397E2407(_thisAdjusted, ___0_name, ___1_value, method);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetFloat(System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetFloat_mEDD694D72DDBEDF381973F41D83037F330224EDC (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_id, float ___1_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_id;
		float L_2 = ___1_value;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorControllerPlayable_SetFloatID_m3BA4ADD5B318BFF0294EB9ACA58480A66168297A(L_0, L_1, L_2, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_SetFloat_mEDD694D72DDBEDF381973F41D83037F330224EDC_AdjustorThunk (RuntimeObject* __this, int32_t ___0_id, float ___1_value, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_SetFloat_mEDD694D72DDBEDF381973F41D83037F330224EDC(_thisAdjusted, ___0_id, ___1_value, method);
}
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::GetBool(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_GetBool_m30C0C093BA04B2C680E5B8510A189A66A4D5333D (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_name, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		String_t* L_1 = ___0_name;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = AnimatorControllerPlayable_GetBoolString_mECF14FDF6E8B96688869FD00C1CC5F91C54EAB16(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool AnimatorControllerPlayable_GetBool_m30C0C093BA04B2C680E5B8510A189A66A4D5333D_AdjustorThunk (RuntimeObject* __this, String_t* ___0_name, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimatorControllerPlayable_GetBool_m30C0C093BA04B2C680E5B8510A189A66A4D5333D(_thisAdjusted, ___0_name, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::GetBool(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_GetBool_m72BB4B2A95A2C229ADE9B51F7232B8FF4E5DF26E (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_id, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_id;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = AnimatorControllerPlayable_GetBoolID_m7061D395F3200F2128DC6320515789ECB1350D4F(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool AnimatorControllerPlayable_GetBool_m72BB4B2A95A2C229ADE9B51F7232B8FF4E5DF26E_AdjustorThunk (RuntimeObject* __this, int32_t ___0_id, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimatorControllerPlayable_GetBool_m72BB4B2A95A2C229ADE9B51F7232B8FF4E5DF26E(_thisAdjusted, ___0_id, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetBool(System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetBool_mDBBE0C1A970D71F600234B15D0E6B9C51E7A70DC (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_name, bool ___1_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		String_t* L_1 = ___0_name;
		bool L_2 = ___1_value;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorControllerPlayable_SetBoolString_m25BA69DB53D2B741C3A3816F52F2D8B8DB94A563(L_0, L_1, L_2, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_SetBool_mDBBE0C1A970D71F600234B15D0E6B9C51E7A70DC_AdjustorThunk (RuntimeObject* __this, String_t* ___0_name, bool ___1_value, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_SetBool_mDBBE0C1A970D71F600234B15D0E6B9C51E7A70DC(_thisAdjusted, ___0_name, ___1_value, method);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetBool(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetBool_mEBE969EAB2935C3A15848521B06ABB45B1188BAD (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_id, bool ___1_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_id;
		bool L_2 = ___1_value;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorControllerPlayable_SetBoolID_m9D7D23783C516EBA887139E4F3C2089D4F6630C9(L_0, L_1, L_2, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_SetBool_mEBE969EAB2935C3A15848521B06ABB45B1188BAD_AdjustorThunk (RuntimeObject* __this, int32_t ___0_id, bool ___1_value, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_SetBool_mEBE969EAB2935C3A15848521B06ABB45B1188BAD(_thisAdjusted, ___0_id, ___1_value, method);
}
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetInteger(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetInteger_mFE3ADA2A4AD9A7A62B60D7E5F2FCBCF9A5F58AA0 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_name, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		String_t* L_1 = ___0_name;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		int32_t L_2;
		L_2 = AnimatorControllerPlayable_GetIntegerString_mD0C70C8553191AD4B4367CA0C1C7892097157713(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		int32_t L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  int32_t AnimatorControllerPlayable_GetInteger_mFE3ADA2A4AD9A7A62B60D7E5F2FCBCF9A5F58AA0_AdjustorThunk (RuntimeObject* __this, String_t* ___0_name, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = AnimatorControllerPlayable_GetInteger_mFE3ADA2A4AD9A7A62B60D7E5F2FCBCF9A5F58AA0(_thisAdjusted, ___0_name, method);
	return _returnValue;
}
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetInteger(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetInteger_m50B3042FDC1F87A4E0423FCCFEED611996A3860D (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_id, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_id;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		int32_t L_2;
		L_2 = AnimatorControllerPlayable_GetIntegerID_m364BCCFECB516503043592BCE6093B6E71573901(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		int32_t L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  int32_t AnimatorControllerPlayable_GetInteger_m50B3042FDC1F87A4E0423FCCFEED611996A3860D_AdjustorThunk (RuntimeObject* __this, int32_t ___0_id, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = AnimatorControllerPlayable_GetInteger_m50B3042FDC1F87A4E0423FCCFEED611996A3860D(_thisAdjusted, ___0_id, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetInteger(System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetInteger_m4C8B5F237C20CFABF0CAD460F55782D834444A91 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_name, int32_t ___1_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		String_t* L_1 = ___0_name;
		int32_t L_2 = ___1_value;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorControllerPlayable_SetIntegerString_mDC746DB1E487E0A5FB8258FB1FB697D3FEB14579(L_0, L_1, L_2, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_SetInteger_m4C8B5F237C20CFABF0CAD460F55782D834444A91_AdjustorThunk (RuntimeObject* __this, String_t* ___0_name, int32_t ___1_value, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_SetInteger_m4C8B5F237C20CFABF0CAD460F55782D834444A91(_thisAdjusted, ___0_name, ___1_value, method);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetInteger(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetInteger_m6FA135B1C91BED0F97C9E623FB8C37411C6F15B4 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_id, int32_t ___1_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_id;
		int32_t L_2 = ___1_value;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorControllerPlayable_SetIntegerID_m683204581C2F1791D94A53D8E9E81C8C4AA25860(L_0, L_1, L_2, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_SetInteger_m6FA135B1C91BED0F97C9E623FB8C37411C6F15B4_AdjustorThunk (RuntimeObject* __this, int32_t ___0_id, int32_t ___1_value, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_SetInteger_m6FA135B1C91BED0F97C9E623FB8C37411C6F15B4(_thisAdjusted, ___0_id, ___1_value, method);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetTrigger(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetTrigger_m06D7662315ED85A8472E62C2F369B1167BAF51A7 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_name, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		String_t* L_1 = ___0_name;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorControllerPlayable_SetTriggerString_m0EC136890F3D7FC3CCE31D7D97406AEC14BA96A2(L_0, L_1, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_SetTrigger_m06D7662315ED85A8472E62C2F369B1167BAF51A7_AdjustorThunk (RuntimeObject* __this, String_t* ___0_name, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_SetTrigger_m06D7662315ED85A8472E62C2F369B1167BAF51A7(_thisAdjusted, ___0_name, method);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetTrigger(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetTrigger_mA2F8F838D48244468DACBF503E120FF3B06E95B2 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_id, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_id;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorControllerPlayable_SetTriggerID_mB0D1B0D7CFAEA440E8582C322215E5F8843BBFF3(L_0, L_1, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_SetTrigger_mA2F8F838D48244468DACBF503E120FF3B06E95B2_AdjustorThunk (RuntimeObject* __this, int32_t ___0_id, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_SetTrigger_mA2F8F838D48244468DACBF503E120FF3B06E95B2(_thisAdjusted, ___0_id, method);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::ResetTrigger(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_ResetTrigger_mD671335B03DF16D311287002303191D50B802D14 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_name, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		String_t* L_1 = ___0_name;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorControllerPlayable_ResetTriggerString_mC531FDD220C61491E53D609F021DE45AB0A517E8(L_0, L_1, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_ResetTrigger_mD671335B03DF16D311287002303191D50B802D14_AdjustorThunk (RuntimeObject* __this, String_t* ___0_name, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_ResetTrigger_mD671335B03DF16D311287002303191D50B802D14(_thisAdjusted, ___0_name, method);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::ResetTrigger(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_ResetTrigger_mABE88FFA8781EB19F5B06F7BF483F13C61107D6C (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_id, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_id;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorControllerPlayable_ResetTriggerID_m4FB3CD3245F90046AEBEB7DAC46F4ED8A17C2E70(L_0, L_1, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_ResetTrigger_mABE88FFA8781EB19F5B06F7BF483F13C61107D6C_AdjustorThunk (RuntimeObject* __this, int32_t ___0_id, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_ResetTrigger_mABE88FFA8781EB19F5B06F7BF483F13C61107D6C(_thisAdjusted, ___0_id, method);
}
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::IsParameterControlledByCurve(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_IsParameterControlledByCurve_m34F8D191A09BC28CCDF1A044FD02B33A1D64D0B1 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_name, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		String_t* L_1 = ___0_name;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = AnimatorControllerPlayable_IsParameterControlledByCurveString_m9E408D31C0E277E3B81355622EA263D0A889FFBB(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool AnimatorControllerPlayable_IsParameterControlledByCurve_m34F8D191A09BC28CCDF1A044FD02B33A1D64D0B1_AdjustorThunk (RuntimeObject* __this, String_t* ___0_name, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimatorControllerPlayable_IsParameterControlledByCurve_m34F8D191A09BC28CCDF1A044FD02B33A1D64D0B1(_thisAdjusted, ___0_name, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::IsParameterControlledByCurve(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_IsParameterControlledByCurve_m8ADD7EE7A489424B4B99253C96647E67B04E2D1B (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_id, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_id;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = AnimatorControllerPlayable_IsParameterControlledByCurveID_m485E73DF5945A41CBD21A8F9ABDFBE9CDD0C07E6(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool AnimatorControllerPlayable_IsParameterControlledByCurve_m8ADD7EE7A489424B4B99253C96647E67B04E2D1B_AdjustorThunk (RuntimeObject* __this, int32_t ___0_id, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimatorControllerPlayable_IsParameterControlledByCurve_m8ADD7EE7A489424B4B99253C96647E67B04E2D1B(_thisAdjusted, ___0_id, method);
	return _returnValue;
}
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetLayerCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetLayerCount_m3941A7DA375B26988A59DA13A22C08476D59D34F (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		int32_t L_1;
		L_1 = AnimatorControllerPlayable_GetLayerCountInternal_m1E9E07012C508DF0D452D350F658AB897B2C7C76(L_0, NULL);
		V_0 = L_1;
		goto IL_000f;
	}

IL_000f:
	{
		int32_t L_2 = V_0;
		return L_2;
	}
}
IL2CPP_EXTERN_C  int32_t AnimatorControllerPlayable_GetLayerCount_m3941A7DA375B26988A59DA13A22C08476D59D34F_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = AnimatorControllerPlayable_GetLayerCount_m3941A7DA375B26988A59DA13A22C08476D59D34F(_thisAdjusted, method);
	return _returnValue;
}
// System.String UnityEngine.Animations.AnimatorControllerPlayable::GetLayerName(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AnimatorControllerPlayable_GetLayerName_m33BDF74B10C6BFDB82FF404E288F52F1EBABC809 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_layerIndex;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		String_t* L_2;
		L_2 = AnimatorControllerPlayable_GetLayerNameInternal_m29B1F15DB851564CA5D4D505F71636FBCAD787B9(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		String_t* L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  String_t* AnimatorControllerPlayable_GetLayerName_m33BDF74B10C6BFDB82FF404E288F52F1EBABC809_AdjustorThunk (RuntimeObject* __this, int32_t ___0_layerIndex, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	String_t* _returnValue;
	_returnValue = AnimatorControllerPlayable_GetLayerName_m33BDF74B10C6BFDB82FF404E288F52F1EBABC809(_thisAdjusted, ___0_layerIndex, method);
	return _returnValue;
}
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetLayerIndex(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetLayerIndex_m48AB42D7F82BE03576D4AC480F048EEDF01B0A0D (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_layerName, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		String_t* L_1 = ___0_layerName;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		int32_t L_2;
		L_2 = AnimatorControllerPlayable_GetLayerIndexInternal_mF8B5003325DC63AA1E35959BBC77F54BA5FB69B6(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		int32_t L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  int32_t AnimatorControllerPlayable_GetLayerIndex_m48AB42D7F82BE03576D4AC480F048EEDF01B0A0D_AdjustorThunk (RuntimeObject* __this, String_t* ___0_layerName, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = AnimatorControllerPlayable_GetLayerIndex_m48AB42D7F82BE03576D4AC480F048EEDF01B0A0D(_thisAdjusted, ___0_layerName, method);
	return _returnValue;
}
// System.Single UnityEngine.Animations.AnimatorControllerPlayable::GetLayerWeight(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorControllerPlayable_GetLayerWeight_m09D5E7AB77824DE2DE20E4E4491BF2A90E3B28BB (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_layerIndex;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		float L_2;
		L_2 = AnimatorControllerPlayable_GetLayerWeightInternal_m35F8593E7F54FF389010F2C2C202662F78A4D076(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		float L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  float AnimatorControllerPlayable_GetLayerWeight_m09D5E7AB77824DE2DE20E4E4491BF2A90E3B28BB_AdjustorThunk (RuntimeObject* __this, int32_t ___0_layerIndex, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	float _returnValue;
	_returnValue = AnimatorControllerPlayable_GetLayerWeight_m09D5E7AB77824DE2DE20E4E4491BF2A90E3B28BB(_thisAdjusted, ___0_layerIndex, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetLayerWeight(System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetLayerWeight_mE432DA7CC2FC4425D0DA064B71B5ACCEB83F8EE3 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, float ___1_weight, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_layerIndex;
		float L_2 = ___1_weight;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorControllerPlayable_SetLayerWeightInternal_m35738E7223F0B22A86DAA2BF2066132E25FD1B8B(L_0, L_1, L_2, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_SetLayerWeight_mE432DA7CC2FC4425D0DA064B71B5ACCEB83F8EE3_AdjustorThunk (RuntimeObject* __this, int32_t ___0_layerIndex, float ___1_weight, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_SetLayerWeight_mE432DA7CC2FC4425D0DA064B71B5ACCEB83F8EE3(_thisAdjusted, ___0_layerIndex, ___1_weight, method);
}
// UnityEngine.AnimatorStateInfo UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorStateInfo(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 AnimatorControllerPlayable_GetCurrentAnimatorStateInfo_mBA937DD74A4964C743880FFE7CFFE67B18D8264B (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_layerIndex;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 L_2;
		L_2 = AnimatorControllerPlayable_GetCurrentAnimatorStateInfoInternal_m9EBFBAF82969F46703B6F9C15F42C29CB963063E(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 AnimatorControllerPlayable_GetCurrentAnimatorStateInfo_mBA937DD74A4964C743880FFE7CFFE67B18D8264B_AdjustorThunk (RuntimeObject* __this, int32_t ___0_layerIndex, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 _returnValue;
	_returnValue = AnimatorControllerPlayable_GetCurrentAnimatorStateInfo_mBA937DD74A4964C743880FFE7CFFE67B18D8264B(_thisAdjusted, ___0_layerIndex, method);
	return _returnValue;
}
// UnityEngine.AnimatorStateInfo UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorStateInfo(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 AnimatorControllerPlayable_GetNextAnimatorStateInfo_m1BD26B635F70840C13BC34D0632D82B5EA48CDE0 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_layerIndex;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 L_2;
		L_2 = AnimatorControllerPlayable_GetNextAnimatorStateInfoInternal_m6573FAB9FB964669D28460771FACBADFC300FC3E(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 AnimatorControllerPlayable_GetNextAnimatorStateInfo_m1BD26B635F70840C13BC34D0632D82B5EA48CDE0_AdjustorThunk (RuntimeObject* __this, int32_t ___0_layerIndex, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 _returnValue;
	_returnValue = AnimatorControllerPlayable_GetNextAnimatorStateInfo_m1BD26B635F70840C13BC34D0632D82B5EA48CDE0(_thisAdjusted, ___0_layerIndex, method);
	return _returnValue;
}
// UnityEngine.AnimatorTransitionInfo UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorTransitionInfo(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD AnimatorControllerPlayable_GetAnimatorTransitionInfo_m5157FED95B567D4441228BC0F3AF31563FD5BF1C (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_layerIndex;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD L_2;
		L_2 = AnimatorControllerPlayable_GetAnimatorTransitionInfoInternal_m02EDD789D0AF671B56CC16D7172FDE8193A1C469(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD AnimatorControllerPlayable_GetAnimatorTransitionInfo_m5157FED95B567D4441228BC0F3AF31563FD5BF1C_AdjustorThunk (RuntimeObject* __this, int32_t ___0_layerIndex, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD _returnValue;
	_returnValue = AnimatorControllerPlayable_GetAnimatorTransitionInfo_m5157FED95B567D4441228BC0F3AF31563FD5BF1C(_thisAdjusted, ___0_layerIndex, method);
	return _returnValue;
}
// UnityEngine.AnimatorClipInfo[] UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorClipInfo(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* AnimatorControllerPlayable_GetCurrentAnimatorClipInfo_mF89B409BFDD2B021BB6862B93A68879BCAB60076 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* V_0 = NULL;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_layerIndex;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* L_2;
		L_2 = AnimatorControllerPlayable_GetCurrentAnimatorClipInfoInternal_mACAEC7A2BCB3EE6DCE40A1608DA3F466E4A9BEEF(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* AnimatorControllerPlayable_GetCurrentAnimatorClipInfo_mF89B409BFDD2B021BB6862B93A68879BCAB60076_AdjustorThunk (RuntimeObject* __this, int32_t ___0_layerIndex, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* _returnValue;
	_returnValue = AnimatorControllerPlayable_GetCurrentAnimatorClipInfo_mF89B409BFDD2B021BB6862B93A68879BCAB60076(_thisAdjusted, ___0_layerIndex, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorClipInfo(System.Int32,System.Collections.Generic.List`1<UnityEngine.AnimatorClipInfo>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_GetCurrentAnimatorClipInfo_mB103A1F9EC5E23947C8A1802D644FC4D22093F14 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331* ___1_clips, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331* L_0 = ___1_clips;
		V_0 = (bool)((((RuntimeObject*)(List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331*)L_0) == ((RuntimeObject*)(RuntimeObject*)NULL))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0014;
		}
	}
	{
		ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129* L_2 = (ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129_il2cpp_TypeInfo_var)));
		NullCheck(L_2);
		ArgumentNullException__ctor_m444AE141157E333844FC1A9500224C2F9FD24F4B(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral05ACCFE2F05290DF031B27B4C6B2AD1DC43CCDC6)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimatorControllerPlayable_GetCurrentAnimatorClipInfo_mB103A1F9EC5E23947C8A1802D644FC4D22093F14_RuntimeMethod_var)));
	}

IL_0014:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_3 = (&__this->___m_Handle_0);
		int32_t L_4 = ___0_layerIndex;
		List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331* L_5 = ___1_clips;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorControllerPlayable_GetAnimatorClipInfoInternal_m18301A84A3ACAE2F7A34B0966564CD4F65D2BB2F(L_3, L_4, (bool)1, L_5, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_GetCurrentAnimatorClipInfo_mB103A1F9EC5E23947C8A1802D644FC4D22093F14_AdjustorThunk (RuntimeObject* __this, int32_t ___0_layerIndex, List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331* ___1_clips, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_GetCurrentAnimatorClipInfo_mB103A1F9EC5E23947C8A1802D644FC4D22093F14(_thisAdjusted, ___0_layerIndex, ___1_clips, method);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorClipInfo(System.Int32,System.Collections.Generic.List`1<UnityEngine.AnimatorClipInfo>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_GetNextAnimatorClipInfo_mF00B978E844FF7E6DF0AF670C0CF2022A8DD2517 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331* ___1_clips, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331* L_0 = ___1_clips;
		V_0 = (bool)((((RuntimeObject*)(List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331*)L_0) == ((RuntimeObject*)(RuntimeObject*)NULL))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0014;
		}
	}
	{
		ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129* L_2 = (ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129_il2cpp_TypeInfo_var)));
		NullCheck(L_2);
		ArgumentNullException__ctor_m444AE141157E333844FC1A9500224C2F9FD24F4B(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral05ACCFE2F05290DF031B27B4C6B2AD1DC43CCDC6)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimatorControllerPlayable_GetNextAnimatorClipInfo_mF00B978E844FF7E6DF0AF670C0CF2022A8DD2517_RuntimeMethod_var)));
	}

IL_0014:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_3 = (&__this->___m_Handle_0);
		int32_t L_4 = ___0_layerIndex;
		List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331* L_5 = ___1_clips;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorControllerPlayable_GetAnimatorClipInfoInternal_m18301A84A3ACAE2F7A34B0966564CD4F65D2BB2F(L_3, L_4, (bool)0, L_5, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_GetNextAnimatorClipInfo_mF00B978E844FF7E6DF0AF670C0CF2022A8DD2517_AdjustorThunk (RuntimeObject* __this, int32_t ___0_layerIndex, List_1_t56EDE3B12B8F9DB1D7D9A1750D981702FECA2331* ___1_clips, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_GetNextAnimatorClipInfo_mF00B978E844FF7E6DF0AF670C0CF2022A8DD2517(_thisAdjusted, ___0_layerIndex, ___1_clips, method);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorClipInfoInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Boolean,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_GetAnimatorClipInfoInternal_m18301A84A3ACAE2F7A34B0966564CD4F65D2BB2F (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, bool ___2_isCurrent, RuntimeObject* ___3_clips, const RuntimeMethod* method) 
{
	typedef void (*AnimatorControllerPlayable_GetAnimatorClipInfoInternal_m18301A84A3ACAE2F7A34B0966564CD4F65D2BB2F_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t, bool, RuntimeObject*);
	static AnimatorControllerPlayable_GetAnimatorClipInfoInternal_m18301A84A3ACAE2F7A34B0966564CD4F65D2BB2F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_GetAnimatorClipInfoInternal_m18301A84A3ACAE2F7A34B0966564CD4F65D2BB2F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorClipInfoInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Boolean,System.Object)");
	_il2cpp_icall_func(___0_handle, ___1_layerIndex, ___2_isCurrent, ___3_clips);
}
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorClipInfoCount(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetCurrentAnimatorClipInfoCount_mB80BDB04DF276D53D45EAA549CAD88DA9A7E8BE8 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_layerIndex;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		int32_t L_2;
		L_2 = AnimatorControllerPlayable_GetAnimatorClipInfoCountInternal_m30ACC99D56EF6C81325F21B16538A70689A4F712(L_0, L_1, (bool)1, NULL);
		V_0 = L_2;
		goto IL_0011;
	}

IL_0011:
	{
		int32_t L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  int32_t AnimatorControllerPlayable_GetCurrentAnimatorClipInfoCount_mB80BDB04DF276D53D45EAA549CAD88DA9A7E8BE8_AdjustorThunk (RuntimeObject* __this, int32_t ___0_layerIndex, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = AnimatorControllerPlayable_GetCurrentAnimatorClipInfoCount_mB80BDB04DF276D53D45EAA549CAD88DA9A7E8BE8(_thisAdjusted, ___0_layerIndex, method);
	return _returnValue;
}
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorClipInfoCount(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetNextAnimatorClipInfoCount_m19CD5C12E89C22E3521175CD6C1E2F033C53D070 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_layerIndex;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		int32_t L_2;
		L_2 = AnimatorControllerPlayable_GetAnimatorClipInfoCountInternal_m30ACC99D56EF6C81325F21B16538A70689A4F712(L_0, L_1, (bool)0, NULL);
		V_0 = L_2;
		goto IL_0011;
	}

IL_0011:
	{
		int32_t L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  int32_t AnimatorControllerPlayable_GetNextAnimatorClipInfoCount_m19CD5C12E89C22E3521175CD6C1E2F033C53D070_AdjustorThunk (RuntimeObject* __this, int32_t ___0_layerIndex, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = AnimatorControllerPlayable_GetNextAnimatorClipInfoCount_m19CD5C12E89C22E3521175CD6C1E2F033C53D070(_thisAdjusted, ___0_layerIndex, method);
	return _returnValue;
}
// UnityEngine.AnimatorClipInfo[] UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorClipInfo(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* AnimatorControllerPlayable_GetNextAnimatorClipInfo_mD247136758432A4036FC338D4C8E67ECAF5EDD26 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* V_0 = NULL;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_layerIndex;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* L_2;
		L_2 = AnimatorControllerPlayable_GetNextAnimatorClipInfoInternal_m9FE0E9288A890CDF52C9F825C619188BBFEB7F6C(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* AnimatorControllerPlayable_GetNextAnimatorClipInfo_mD247136758432A4036FC338D4C8E67ECAF5EDD26_AdjustorThunk (RuntimeObject* __this, int32_t ___0_layerIndex, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* _returnValue;
	_returnValue = AnimatorControllerPlayable_GetNextAnimatorClipInfo_mD247136758432A4036FC338D4C8E67ECAF5EDD26(_thisAdjusted, ___0_layerIndex, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::IsInTransition(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_IsInTransition_m041E31E9DAD976867BCCBDDD27CB556F590D61D9 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_layerIndex;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = AnimatorControllerPlayable_IsInTransitionInternal_m0DA12D5A39272162175FC51E47458871BB8B4E42(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool AnimatorControllerPlayable_IsInTransition_m041E31E9DAD976867BCCBDDD27CB556F590D61D9_AdjustorThunk (RuntimeObject* __this, int32_t ___0_layerIndex, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimatorControllerPlayable_IsInTransition_m041E31E9DAD976867BCCBDDD27CB556F590D61D9(_thisAdjusted, ___0_layerIndex, method);
	return _returnValue;
}
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetParameterCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetParameterCount_m899EE6DAD7209174D7568E632DA986D39E435A70 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		int32_t L_1;
		L_1 = AnimatorControllerPlayable_GetParameterCountInternal_m382C6BFCEE151B9DF3DFE232B287D6C6D522DD8D(L_0, NULL);
		V_0 = L_1;
		goto IL_000f;
	}

IL_000f:
	{
		int32_t L_2 = V_0;
		return L_2;
	}
}
IL2CPP_EXTERN_C  int32_t AnimatorControllerPlayable_GetParameterCount_m899EE6DAD7209174D7568E632DA986D39E435A70_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = AnimatorControllerPlayable_GetParameterCount_m899EE6DAD7209174D7568E632DA986D39E435A70(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.AnimatorControllerParameter UnityEngine.Animations.AnimatorControllerPlayable::GetParameter(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* AnimatorControllerPlayable_GetParameter_mB7ECCC4E41138CC7D9A28ABF499679B8792E9CC3 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_index, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	AnimatorControllerParameterU5BU5D_tAB05125F5DC0D98F59351CD7D8C9880DFFA8EA21* V_0 = NULL;
	bool V_1 = false;
	AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* V_2 = NULL;
	int32_t G_B3_0 = 0;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorControllerParameterU5BU5D_tAB05125F5DC0D98F59351CD7D8C9880DFFA8EA21* L_1;
		L_1 = AnimatorControllerPlayable_GetParametersArrayInternal_mFB9F6ACE0FD4B8FBA8C5641195B71EEC242F99E5(L_0, NULL);
		V_0 = L_1;
		int32_t L_2 = ___0_index;
		if ((((int32_t)L_2) < ((int32_t)0)))
		{
			goto IL_001c;
		}
	}
	{
		int32_t L_3 = ___0_index;
		AnimatorControllerParameterU5BU5D_tAB05125F5DC0D98F59351CD7D8C9880DFFA8EA21* L_4 = V_0;
		NullCheck(L_4);
		G_B3_0 = ((((int32_t)((((int32_t)L_3) < ((int32_t)((int32_t)(((RuntimeArray*)L_4)->max_length))))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_001d;
	}

IL_001c:
	{
		G_B3_0 = 1;
	}

IL_001d:
	{
		V_1 = (bool)G_B3_0;
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_002c;
		}
	}
	{
		IndexOutOfRangeException_t7ECB35264FB6CA8FAA516BD958F4B2ADC78E8A82* L_6 = (IndexOutOfRangeException_t7ECB35264FB6CA8FAA516BD958F4B2ADC78E8A82*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&IndexOutOfRangeException_t7ECB35264FB6CA8FAA516BD958F4B2ADC78E8A82_il2cpp_TypeInfo_var)));
		NullCheck(L_6);
		IndexOutOfRangeException__ctor_mFD06819F05B815BE2D6E826D4E04F4C449D0A425(L_6, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral95FD319744C5A359A08D63293C9F417B4D0BAB9E)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_6, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimatorControllerPlayable_GetParameter_mB7ECCC4E41138CC7D9A28ABF499679B8792E9CC3_RuntimeMethod_var)));
	}

IL_002c:
	{
		AnimatorControllerParameterU5BU5D_tAB05125F5DC0D98F59351CD7D8C9880DFFA8EA21* L_7 = V_0;
		int32_t L_8 = ___0_index;
		NullCheck(L_7);
		int32_t L_9 = L_8;
		AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* L_10 = (L_7)->GetAt(static_cast<il2cpp_array_size_t>(L_9));
		V_2 = L_10;
		goto IL_0032;
	}

IL_0032:
	{
		AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* L_11 = V_2;
		return L_11;
	}
}
IL2CPP_EXTERN_C  AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* AnimatorControllerPlayable_GetParameter_mB7ECCC4E41138CC7D9A28ABF499679B8792E9CC3_AdjustorThunk (RuntimeObject* __this, int32_t ___0_index, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerParameter_t1FA67485445446540D4F2857762C960AE6980E02* _returnValue;
	_returnValue = AnimatorControllerPlayable_GetParameter_mB7ECCC4E41138CC7D9A28ABF499679B8792E9CC3(_thisAdjusted, ___0_index, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::CrossFadeInFixedTime(System.String,System.Single,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_CrossFadeInFixedTime_m43166ED8F80B94469DFA25374911A64637438674 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_stateName, float ___1_transitionDuration, int32_t ___2_layer, float ___3_fixedTime, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		String_t* L_1 = ___0_stateName;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		int32_t L_2;
		L_2 = AnimatorControllerPlayable_StringToHash_m75E3FCE65BF77734C4781FADFFC9568B0EE483E2(L_1, NULL);
		float L_3 = ___1_transitionDuration;
		int32_t L_4 = ___2_layer;
		float L_5 = ___3_fixedTime;
		AnimatorControllerPlayable_CrossFadeInFixedTimeInternal_m2F3C0BAE59468B079106B730F8F0EE9874928561(L_0, L_2, L_3, L_4, L_5, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_CrossFadeInFixedTime_m43166ED8F80B94469DFA25374911A64637438674_AdjustorThunk (RuntimeObject* __this, String_t* ___0_stateName, float ___1_transitionDuration, int32_t ___2_layer, float ___3_fixedTime, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_CrossFadeInFixedTime_m43166ED8F80B94469DFA25374911A64637438674(_thisAdjusted, ___0_stateName, ___1_transitionDuration, ___2_layer, ___3_fixedTime, method);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::CrossFadeInFixedTime(System.Int32,System.Single,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_CrossFadeInFixedTime_m93EC21F858FE76184FA91D2B6EA3B361A2929503 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_stateNameHash, float ___1_transitionDuration, int32_t ___2_layer, float ___3_fixedTime, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_stateNameHash;
		float L_2 = ___1_transitionDuration;
		int32_t L_3 = ___2_layer;
		float L_4 = ___3_fixedTime;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorControllerPlayable_CrossFadeInFixedTimeInternal_m2F3C0BAE59468B079106B730F8F0EE9874928561(L_0, L_1, L_2, L_3, L_4, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_CrossFadeInFixedTime_m93EC21F858FE76184FA91D2B6EA3B361A2929503_AdjustorThunk (RuntimeObject* __this, int32_t ___0_stateNameHash, float ___1_transitionDuration, int32_t ___2_layer, float ___3_fixedTime, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_CrossFadeInFixedTime_m93EC21F858FE76184FA91D2B6EA3B361A2929503(_thisAdjusted, ___0_stateNameHash, ___1_transitionDuration, ___2_layer, ___3_fixedTime, method);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::CrossFade(System.String,System.Single,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_CrossFade_m8AD5C075E4B4B645796A36980AE15378167019AA (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_stateName, float ___1_transitionDuration, int32_t ___2_layer, float ___3_normalizedTime, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		String_t* L_1 = ___0_stateName;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		int32_t L_2;
		L_2 = AnimatorControllerPlayable_StringToHash_m75E3FCE65BF77734C4781FADFFC9568B0EE483E2(L_1, NULL);
		float L_3 = ___1_transitionDuration;
		int32_t L_4 = ___2_layer;
		float L_5 = ___3_normalizedTime;
		AnimatorControllerPlayable_CrossFadeInternal_m4861EAD661B4EA490CDAF4413F8D6E1F1EF6F6D2(L_0, L_2, L_3, L_4, L_5, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_CrossFade_m8AD5C075E4B4B645796A36980AE15378167019AA_AdjustorThunk (RuntimeObject* __this, String_t* ___0_stateName, float ___1_transitionDuration, int32_t ___2_layer, float ___3_normalizedTime, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_CrossFade_m8AD5C075E4B4B645796A36980AE15378167019AA(_thisAdjusted, ___0_stateName, ___1_transitionDuration, ___2_layer, ___3_normalizedTime, method);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::CrossFade(System.Int32,System.Single,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_CrossFade_m0C777C0385BE3E8AA8D86C99897D490ED553F9DD (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_stateNameHash, float ___1_transitionDuration, int32_t ___2_layer, float ___3_normalizedTime, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_stateNameHash;
		float L_2 = ___1_transitionDuration;
		int32_t L_3 = ___2_layer;
		float L_4 = ___3_normalizedTime;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorControllerPlayable_CrossFadeInternal_m4861EAD661B4EA490CDAF4413F8D6E1F1EF6F6D2(L_0, L_1, L_2, L_3, L_4, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_CrossFade_m0C777C0385BE3E8AA8D86C99897D490ED553F9DD_AdjustorThunk (RuntimeObject* __this, int32_t ___0_stateNameHash, float ___1_transitionDuration, int32_t ___2_layer, float ___3_normalizedTime, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_CrossFade_m0C777C0385BE3E8AA8D86C99897D490ED553F9DD(_thisAdjusted, ___0_stateNameHash, ___1_transitionDuration, ___2_layer, ___3_normalizedTime, method);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::PlayInFixedTime(System.String,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_PlayInFixedTime_mE4DAC931BFEDBCAABE0D410BE3DF85C5C4FF1425 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_stateName, int32_t ___1_layer, float ___2_fixedTime, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		String_t* L_1 = ___0_stateName;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		int32_t L_2;
		L_2 = AnimatorControllerPlayable_StringToHash_m75E3FCE65BF77734C4781FADFFC9568B0EE483E2(L_1, NULL);
		int32_t L_3 = ___1_layer;
		float L_4 = ___2_fixedTime;
		AnimatorControllerPlayable_PlayInFixedTimeInternal_mC0683AD548C14DA24F82388F68150F174275E376(L_0, L_2, L_3, L_4, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_PlayInFixedTime_mE4DAC931BFEDBCAABE0D410BE3DF85C5C4FF1425_AdjustorThunk (RuntimeObject* __this, String_t* ___0_stateName, int32_t ___1_layer, float ___2_fixedTime, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_PlayInFixedTime_mE4DAC931BFEDBCAABE0D410BE3DF85C5C4FF1425(_thisAdjusted, ___0_stateName, ___1_layer, ___2_fixedTime, method);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::PlayInFixedTime(System.Int32,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_PlayInFixedTime_m513E1A9D864FCC8DF9E16A9DE05465A5694ACE2B (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_stateNameHash, int32_t ___1_layer, float ___2_fixedTime, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_stateNameHash;
		int32_t L_2 = ___1_layer;
		float L_3 = ___2_fixedTime;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorControllerPlayable_PlayInFixedTimeInternal_mC0683AD548C14DA24F82388F68150F174275E376(L_0, L_1, L_2, L_3, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_PlayInFixedTime_m513E1A9D864FCC8DF9E16A9DE05465A5694ACE2B_AdjustorThunk (RuntimeObject* __this, int32_t ___0_stateNameHash, int32_t ___1_layer, float ___2_fixedTime, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_PlayInFixedTime_m513E1A9D864FCC8DF9E16A9DE05465A5694ACE2B(_thisAdjusted, ___0_stateNameHash, ___1_layer, ___2_fixedTime, method);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::Play(System.String,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_Play_m703A612D5040F4F99C17D300E5BD57ABB992E976 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, String_t* ___0_stateName, int32_t ___1_layer, float ___2_normalizedTime, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		String_t* L_1 = ___0_stateName;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		int32_t L_2;
		L_2 = AnimatorControllerPlayable_StringToHash_m75E3FCE65BF77734C4781FADFFC9568B0EE483E2(L_1, NULL);
		int32_t L_3 = ___1_layer;
		float L_4 = ___2_normalizedTime;
		AnimatorControllerPlayable_PlayInternal_mD5A3AAC8CFE034C5D8FA9CC26AC9CAA364145524(L_0, L_2, L_3, L_4, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_Play_m703A612D5040F4F99C17D300E5BD57ABB992E976_AdjustorThunk (RuntimeObject* __this, String_t* ___0_stateName, int32_t ___1_layer, float ___2_normalizedTime, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_Play_m703A612D5040F4F99C17D300E5BD57ABB992E976(_thisAdjusted, ___0_stateName, ___1_layer, ___2_normalizedTime, method);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::Play(System.Int32,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_Play_mB14FF22BE5BF41EB807BD3F14C111A3D60E59394 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_stateNameHash, int32_t ___1_layer, float ___2_normalizedTime, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_stateNameHash;
		int32_t L_2 = ___1_layer;
		float L_3 = ___2_normalizedTime;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorControllerPlayable_PlayInternal_mD5A3AAC8CFE034C5D8FA9CC26AC9CAA364145524(L_0, L_1, L_2, L_3, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_Play_mB14FF22BE5BF41EB807BD3F14C111A3D60E59394_AdjustorThunk (RuntimeObject* __this, int32_t ___0_stateNameHash, int32_t ___1_layer, float ___2_normalizedTime, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	AnimatorControllerPlayable_Play_mB14FF22BE5BF41EB807BD3F14C111A3D60E59394(_thisAdjusted, ___0_stateNameHash, ___1_layer, ___2_normalizedTime, method);
}
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::HasState(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_HasState_mE537ED9F84D34939019463D4A2F6171B053759C2 (AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* __this, int32_t ___0_layerIndex, int32_t ___1_stateID, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		int32_t L_1 = ___0_layerIndex;
		int32_t L_2 = ___1_stateID;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = AnimatorControllerPlayable_HasStateInternal_m1D49854E9E6AFAC2DFE979DFF6911B6946B5555A(L_0, L_1, L_2, NULL);
		V_0 = L_3;
		goto IL_0011;
	}

IL_0011:
	{
		bool L_4 = V_0;
		return L_4;
	}
}
IL2CPP_EXTERN_C  bool AnimatorControllerPlayable_HasState_mE537ED9F84D34939019463D4A2F6171B053759C2_AdjustorThunk (RuntimeObject* __this, int32_t ___0_layerIndex, int32_t ___1_stateID, const RuntimeMethod* method)
{
	AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A*>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimatorControllerPlayable_HasState_mE537ED9F84D34939019463D4A2F6171B053759C2(_thisAdjusted, ___0_layerIndex, ___1_stateID, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::CreateHandleInternal(UnityEngine.Playables.PlayableGraph,UnityEngine.RuntimeAnimatorController,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_CreateHandleInternal_mF52B5F176A31C938DF5909127B27B1E78E3863D4 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, RuntimeAnimatorController_t6F7C753402B42EC23C163099CF935C5E0D7A7254* ___1_controller, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___2_handle, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		RuntimeAnimatorController_t6F7C753402B42EC23C163099CF935C5E0D7A7254* L_0 = ___1_controller;
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_1 = ___2_handle;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = AnimatorControllerPlayable_CreateHandleInternal_Injected_mCBD001EF18F0143DD0568A9D5FBAF157206ED21D((&___0_graph), L_0, L_1, NULL);
		return L_2;
	}
}
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetLayerCountInternal(UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetLayerCountInternal_m1E9E07012C508DF0D452D350F658AB897B2C7C76 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, const RuntimeMethod* method) 
{
	typedef int32_t (*AnimatorControllerPlayable_GetLayerCountInternal_m1E9E07012C508DF0D452D350F658AB897B2C7C76_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*);
	static AnimatorControllerPlayable_GetLayerCountInternal_m1E9E07012C508DF0D452D350F658AB897B2C7C76_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_GetLayerCountInternal_m1E9E07012C508DF0D452D350F658AB897B2C7C76_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::GetLayerCountInternal(UnityEngine.Playables.PlayableHandle&)");
	int32_t icallRetVal = _il2cpp_icall_func(___0_handle);
	return icallRetVal;
}
// System.String UnityEngine.Animations.AnimatorControllerPlayable::GetLayerNameInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AnimatorControllerPlayable_GetLayerNameInternal_m29B1F15DB851564CA5D4D505F71636FBCAD787B9 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, const RuntimeMethod* method) 
{
	typedef String_t* (*AnimatorControllerPlayable_GetLayerNameInternal_m29B1F15DB851564CA5D4D505F71636FBCAD787B9_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t);
	static AnimatorControllerPlayable_GetLayerNameInternal_m29B1F15DB851564CA5D4D505F71636FBCAD787B9_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_GetLayerNameInternal_m29B1F15DB851564CA5D4D505F71636FBCAD787B9_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::GetLayerNameInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)");
	String_t* icallRetVal = _il2cpp_icall_func(___0_handle, ___1_layerIndex);
	return icallRetVal;
}
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetLayerIndexInternal(UnityEngine.Playables.PlayableHandle&,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetLayerIndexInternal_mF8B5003325DC63AA1E35959BBC77F54BA5FB69B6 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, String_t* ___1_layerName, const RuntimeMethod* method) 
{
	typedef int32_t (*AnimatorControllerPlayable_GetLayerIndexInternal_mF8B5003325DC63AA1E35959BBC77F54BA5FB69B6_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, String_t*);
	static AnimatorControllerPlayable_GetLayerIndexInternal_mF8B5003325DC63AA1E35959BBC77F54BA5FB69B6_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_GetLayerIndexInternal_mF8B5003325DC63AA1E35959BBC77F54BA5FB69B6_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::GetLayerIndexInternal(UnityEngine.Playables.PlayableHandle&,System.String)");
	int32_t icallRetVal = _il2cpp_icall_func(___0_handle, ___1_layerName);
	return icallRetVal;
}
// System.Single UnityEngine.Animations.AnimatorControllerPlayable::GetLayerWeightInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorControllerPlayable_GetLayerWeightInternal_m35F8593E7F54FF389010F2C2C202662F78A4D076 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, const RuntimeMethod* method) 
{
	typedef float (*AnimatorControllerPlayable_GetLayerWeightInternal_m35F8593E7F54FF389010F2C2C202662F78A4D076_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t);
	static AnimatorControllerPlayable_GetLayerWeightInternal_m35F8593E7F54FF389010F2C2C202662F78A4D076_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_GetLayerWeightInternal_m35F8593E7F54FF389010F2C2C202662F78A4D076_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::GetLayerWeightInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)");
	float icallRetVal = _il2cpp_icall_func(___0_handle, ___1_layerIndex);
	return icallRetVal;
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetLayerWeightInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetLayerWeightInternal_m35738E7223F0B22A86DAA2BF2066132E25FD1B8B (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, float ___2_weight, const RuntimeMethod* method) 
{
	typedef void (*AnimatorControllerPlayable_SetLayerWeightInternal_m35738E7223F0B22A86DAA2BF2066132E25FD1B8B_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t, float);
	static AnimatorControllerPlayable_SetLayerWeightInternal_m35738E7223F0B22A86DAA2BF2066132E25FD1B8B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_SetLayerWeightInternal_m35738E7223F0B22A86DAA2BF2066132E25FD1B8B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::SetLayerWeightInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Single)");
	_il2cpp_icall_func(___0_handle, ___1_layerIndex, ___2_weight);
}
// UnityEngine.AnimatorStateInfo UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorStateInfoInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 AnimatorControllerPlayable_GetCurrentAnimatorStateInfoInternal_m9EBFBAF82969F46703B6F9C15F42C29CB963063E (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = ___0_handle;
		int32_t L_1 = ___1_layerIndex;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorControllerPlayable_GetCurrentAnimatorStateInfoInternal_Injected_m7B608D6B42D37184F7C778E9DEBCD77B350923AD(L_0, L_1, (&V_0), NULL);
		AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 L_2 = V_0;
		return L_2;
	}
}
// UnityEngine.AnimatorStateInfo UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorStateInfoInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 AnimatorControllerPlayable_GetNextAnimatorStateInfoInternal_m6573FAB9FB964669D28460771FACBADFC300FC3E (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = ___0_handle;
		int32_t L_1 = ___1_layerIndex;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorControllerPlayable_GetNextAnimatorStateInfoInternal_Injected_m6939850E0366960A04B5B3009220B1AAC6F77D0F(L_0, L_1, (&V_0), NULL);
		AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 L_2 = V_0;
		return L_2;
	}
}
// UnityEngine.AnimatorTransitionInfo UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorTransitionInfoInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD AnimatorControllerPlayable_GetAnimatorTransitionInfoInternal_m02EDD789D0AF671B56CC16D7172FDE8193A1C469 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = ___0_handle;
		int32_t L_1 = ___1_layerIndex;
		il2cpp_codegen_runtime_class_init_inline(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		AnimatorControllerPlayable_GetAnimatorTransitionInfoInternal_Injected_m6CFF884FDBEF401BA13CAA1F9FA68EFC56B62870(L_0, L_1, (&V_0), NULL);
		AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD L_2 = V_0;
		return L_2;
	}
}
// UnityEngine.AnimatorClipInfo[] UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorClipInfoInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* AnimatorControllerPlayable_GetCurrentAnimatorClipInfoInternal_mACAEC7A2BCB3EE6DCE40A1608DA3F466E4A9BEEF (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, const RuntimeMethod* method) 
{
	typedef AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* (*AnimatorControllerPlayable_GetCurrentAnimatorClipInfoInternal_mACAEC7A2BCB3EE6DCE40A1608DA3F466E4A9BEEF_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t);
	static AnimatorControllerPlayable_GetCurrentAnimatorClipInfoInternal_mACAEC7A2BCB3EE6DCE40A1608DA3F466E4A9BEEF_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_GetCurrentAnimatorClipInfoInternal_mACAEC7A2BCB3EE6DCE40A1608DA3F466E4A9BEEF_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorClipInfoInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)");
	AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* icallRetVal = _il2cpp_icall_func(___0_handle, ___1_layerIndex);
	return icallRetVal;
}
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorClipInfoCountInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetAnimatorClipInfoCountInternal_m30ACC99D56EF6C81325F21B16538A70689A4F712 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, bool ___2_current, const RuntimeMethod* method) 
{
	typedef int32_t (*AnimatorControllerPlayable_GetAnimatorClipInfoCountInternal_m30ACC99D56EF6C81325F21B16538A70689A4F712_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t, bool);
	static AnimatorControllerPlayable_GetAnimatorClipInfoCountInternal_m30ACC99D56EF6C81325F21B16538A70689A4F712_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_GetAnimatorClipInfoCountInternal_m30ACC99D56EF6C81325F21B16538A70689A4F712_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorClipInfoCountInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Boolean)");
	int32_t icallRetVal = _il2cpp_icall_func(___0_handle, ___1_layerIndex, ___2_current);
	return icallRetVal;
}
// UnityEngine.AnimatorClipInfo[] UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorClipInfoInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* AnimatorControllerPlayable_GetNextAnimatorClipInfoInternal_m9FE0E9288A890CDF52C9F825C619188BBFEB7F6C (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, const RuntimeMethod* method) 
{
	typedef AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* (*AnimatorControllerPlayable_GetNextAnimatorClipInfoInternal_m9FE0E9288A890CDF52C9F825C619188BBFEB7F6C_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t);
	static AnimatorControllerPlayable_GetNextAnimatorClipInfoInternal_m9FE0E9288A890CDF52C9F825C619188BBFEB7F6C_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_GetNextAnimatorClipInfoInternal_m9FE0E9288A890CDF52C9F825C619188BBFEB7F6C_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorClipInfoInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)");
	AnimatorClipInfoU5BU5D_t202D955679134FCCD698779FBABD2530E58CD60A* icallRetVal = _il2cpp_icall_func(___0_handle, ___1_layerIndex);
	return icallRetVal;
}
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::IsInTransitionInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_IsInTransitionInternal_m0DA12D5A39272162175FC51E47458871BB8B4E42 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, const RuntimeMethod* method) 
{
	typedef bool (*AnimatorControllerPlayable_IsInTransitionInternal_m0DA12D5A39272162175FC51E47458871BB8B4E42_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t);
	static AnimatorControllerPlayable_IsInTransitionInternal_m0DA12D5A39272162175FC51E47458871BB8B4E42_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_IsInTransitionInternal_m0DA12D5A39272162175FC51E47458871BB8B4E42_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::IsInTransitionInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)");
	bool icallRetVal = _il2cpp_icall_func(___0_handle, ___1_layerIndex);
	return icallRetVal;
}
// UnityEngine.AnimatorControllerParameter[] UnityEngine.Animations.AnimatorControllerPlayable::GetParametersArrayInternal(UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorControllerParameterU5BU5D_tAB05125F5DC0D98F59351CD7D8C9880DFFA8EA21* AnimatorControllerPlayable_GetParametersArrayInternal_mFB9F6ACE0FD4B8FBA8C5641195B71EEC242F99E5 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, const RuntimeMethod* method) 
{
	typedef AnimatorControllerParameterU5BU5D_tAB05125F5DC0D98F59351CD7D8C9880DFFA8EA21* (*AnimatorControllerPlayable_GetParametersArrayInternal_mFB9F6ACE0FD4B8FBA8C5641195B71EEC242F99E5_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*);
	static AnimatorControllerPlayable_GetParametersArrayInternal_mFB9F6ACE0FD4B8FBA8C5641195B71EEC242F99E5_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_GetParametersArrayInternal_mFB9F6ACE0FD4B8FBA8C5641195B71EEC242F99E5_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::GetParametersArrayInternal(UnityEngine.Playables.PlayableHandle&)");
	AnimatorControllerParameterU5BU5D_tAB05125F5DC0D98F59351CD7D8C9880DFFA8EA21* icallRetVal = _il2cpp_icall_func(___0_handle);
	return icallRetVal;
}
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetParameterCountInternal(UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetParameterCountInternal_m382C6BFCEE151B9DF3DFE232B287D6C6D522DD8D (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, const RuntimeMethod* method) 
{
	typedef int32_t (*AnimatorControllerPlayable_GetParameterCountInternal_m382C6BFCEE151B9DF3DFE232B287D6C6D522DD8D_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*);
	static AnimatorControllerPlayable_GetParameterCountInternal_m382C6BFCEE151B9DF3DFE232B287D6C6D522DD8D_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_GetParameterCountInternal_m382C6BFCEE151B9DF3DFE232B287D6C6D522DD8D_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::GetParameterCountInternal(UnityEngine.Playables.PlayableHandle&)");
	int32_t icallRetVal = _il2cpp_icall_func(___0_handle);
	return icallRetVal;
}
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::StringToHash(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_StringToHash_m75E3FCE65BF77734C4781FADFFC9568B0EE483E2 (String_t* ___0_name, const RuntimeMethod* method) 
{
	typedef int32_t (*AnimatorControllerPlayable_StringToHash_m75E3FCE65BF77734C4781FADFFC9568B0EE483E2_ftn) (String_t*);
	static AnimatorControllerPlayable_StringToHash_m75E3FCE65BF77734C4781FADFFC9568B0EE483E2_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_StringToHash_m75E3FCE65BF77734C4781FADFFC9568B0EE483E2_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::StringToHash(System.String)");
	int32_t icallRetVal = _il2cpp_icall_func(___0_name);
	return icallRetVal;
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::CrossFadeInFixedTimeInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Single,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_CrossFadeInFixedTimeInternal_m2F3C0BAE59468B079106B730F8F0EE9874928561 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_stateNameHash, float ___2_transitionDuration, int32_t ___3_layer, float ___4_fixedTime, const RuntimeMethod* method) 
{
	typedef void (*AnimatorControllerPlayable_CrossFadeInFixedTimeInternal_m2F3C0BAE59468B079106B730F8F0EE9874928561_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t, float, int32_t, float);
	static AnimatorControllerPlayable_CrossFadeInFixedTimeInternal_m2F3C0BAE59468B079106B730F8F0EE9874928561_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_CrossFadeInFixedTimeInternal_m2F3C0BAE59468B079106B730F8F0EE9874928561_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::CrossFadeInFixedTimeInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Single,System.Int32,System.Single)");
	_il2cpp_icall_func(___0_handle, ___1_stateNameHash, ___2_transitionDuration, ___3_layer, ___4_fixedTime);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::CrossFadeInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Single,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_CrossFadeInternal_m4861EAD661B4EA490CDAF4413F8D6E1F1EF6F6D2 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_stateNameHash, float ___2_transitionDuration, int32_t ___3_layer, float ___4_normalizedTime, const RuntimeMethod* method) 
{
	typedef void (*AnimatorControllerPlayable_CrossFadeInternal_m4861EAD661B4EA490CDAF4413F8D6E1F1EF6F6D2_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t, float, int32_t, float);
	static AnimatorControllerPlayable_CrossFadeInternal_m4861EAD661B4EA490CDAF4413F8D6E1F1EF6F6D2_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_CrossFadeInternal_m4861EAD661B4EA490CDAF4413F8D6E1F1EF6F6D2_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::CrossFadeInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Single,System.Int32,System.Single)");
	_il2cpp_icall_func(___0_handle, ___1_stateNameHash, ___2_transitionDuration, ___3_layer, ___4_normalizedTime);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::PlayInFixedTimeInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_PlayInFixedTimeInternal_mC0683AD548C14DA24F82388F68150F174275E376 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_stateNameHash, int32_t ___2_layer, float ___3_fixedTime, const RuntimeMethod* method) 
{
	typedef void (*AnimatorControllerPlayable_PlayInFixedTimeInternal_mC0683AD548C14DA24F82388F68150F174275E376_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t, int32_t, float);
	static AnimatorControllerPlayable_PlayInFixedTimeInternal_mC0683AD548C14DA24F82388F68150F174275E376_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_PlayInFixedTimeInternal_mC0683AD548C14DA24F82388F68150F174275E376_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::PlayInFixedTimeInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Int32,System.Single)");
	_il2cpp_icall_func(___0_handle, ___1_stateNameHash, ___2_layer, ___3_fixedTime);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::PlayInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_PlayInternal_mD5A3AAC8CFE034C5D8FA9CC26AC9CAA364145524 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_stateNameHash, int32_t ___2_layer, float ___3_normalizedTime, const RuntimeMethod* method) 
{
	typedef void (*AnimatorControllerPlayable_PlayInternal_mD5A3AAC8CFE034C5D8FA9CC26AC9CAA364145524_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t, int32_t, float);
	static AnimatorControllerPlayable_PlayInternal_mD5A3AAC8CFE034C5D8FA9CC26AC9CAA364145524_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_PlayInternal_mD5A3AAC8CFE034C5D8FA9CC26AC9CAA364145524_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::PlayInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Int32,System.Single)");
	_il2cpp_icall_func(___0_handle, ___1_stateNameHash, ___2_layer, ___3_normalizedTime);
}
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::HasStateInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_HasStateInternal_m1D49854E9E6AFAC2DFE979DFF6911B6946B5555A (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, int32_t ___2_stateID, const RuntimeMethod* method) 
{
	typedef bool (*AnimatorControllerPlayable_HasStateInternal_m1D49854E9E6AFAC2DFE979DFF6911B6946B5555A_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t, int32_t);
	static AnimatorControllerPlayable_HasStateInternal_m1D49854E9E6AFAC2DFE979DFF6911B6946B5555A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_HasStateInternal_m1D49854E9E6AFAC2DFE979DFF6911B6946B5555A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::HasStateInternal(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Int32)");
	bool icallRetVal = _il2cpp_icall_func(___0_handle, ___1_layerIndex, ___2_stateID);
	return icallRetVal;
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetFloatString(UnityEngine.Playables.PlayableHandle&,System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetFloatString_m0F0870A5299A2CF4AFC6C65832D189A5D04D4FD5 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, String_t* ___1_name, float ___2_value, const RuntimeMethod* method) 
{
	typedef void (*AnimatorControllerPlayable_SetFloatString_m0F0870A5299A2CF4AFC6C65832D189A5D04D4FD5_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, String_t*, float);
	static AnimatorControllerPlayable_SetFloatString_m0F0870A5299A2CF4AFC6C65832D189A5D04D4FD5_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_SetFloatString_m0F0870A5299A2CF4AFC6C65832D189A5D04D4FD5_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::SetFloatString(UnityEngine.Playables.PlayableHandle&,System.String,System.Single)");
	_il2cpp_icall_func(___0_handle, ___1_name, ___2_value);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetFloatID(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetFloatID_m3BA4ADD5B318BFF0294EB9ACA58480A66168297A (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_id, float ___2_value, const RuntimeMethod* method) 
{
	typedef void (*AnimatorControllerPlayable_SetFloatID_m3BA4ADD5B318BFF0294EB9ACA58480A66168297A_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t, float);
	static AnimatorControllerPlayable_SetFloatID_m3BA4ADD5B318BFF0294EB9ACA58480A66168297A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_SetFloatID_m3BA4ADD5B318BFF0294EB9ACA58480A66168297A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::SetFloatID(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Single)");
	_il2cpp_icall_func(___0_handle, ___1_id, ___2_value);
}
// System.Single UnityEngine.Animations.AnimatorControllerPlayable::GetFloatString(UnityEngine.Playables.PlayableHandle&,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorControllerPlayable_GetFloatString_m1DADE177E526468221C892871355B7E0371DC7B5 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, String_t* ___1_name, const RuntimeMethod* method) 
{
	typedef float (*AnimatorControllerPlayable_GetFloatString_m1DADE177E526468221C892871355B7E0371DC7B5_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, String_t*);
	static AnimatorControllerPlayable_GetFloatString_m1DADE177E526468221C892871355B7E0371DC7B5_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_GetFloatString_m1DADE177E526468221C892871355B7E0371DC7B5_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::GetFloatString(UnityEngine.Playables.PlayableHandle&,System.String)");
	float icallRetVal = _il2cpp_icall_func(___0_handle, ___1_name);
	return icallRetVal;
}
// System.Single UnityEngine.Animations.AnimatorControllerPlayable::GetFloatID(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorControllerPlayable_GetFloatID_m4EDF8B5F43B2F67DDCF3A566C520E99AF92316E0 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_id, const RuntimeMethod* method) 
{
	typedef float (*AnimatorControllerPlayable_GetFloatID_m4EDF8B5F43B2F67DDCF3A566C520E99AF92316E0_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t);
	static AnimatorControllerPlayable_GetFloatID_m4EDF8B5F43B2F67DDCF3A566C520E99AF92316E0_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_GetFloatID_m4EDF8B5F43B2F67DDCF3A566C520E99AF92316E0_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::GetFloatID(UnityEngine.Playables.PlayableHandle&,System.Int32)");
	float icallRetVal = _il2cpp_icall_func(___0_handle, ___1_id);
	return icallRetVal;
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetBoolString(UnityEngine.Playables.PlayableHandle&,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetBoolString_m25BA69DB53D2B741C3A3816F52F2D8B8DB94A563 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, String_t* ___1_name, bool ___2_value, const RuntimeMethod* method) 
{
	typedef void (*AnimatorControllerPlayable_SetBoolString_m25BA69DB53D2B741C3A3816F52F2D8B8DB94A563_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, String_t*, bool);
	static AnimatorControllerPlayable_SetBoolString_m25BA69DB53D2B741C3A3816F52F2D8B8DB94A563_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_SetBoolString_m25BA69DB53D2B741C3A3816F52F2D8B8DB94A563_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::SetBoolString(UnityEngine.Playables.PlayableHandle&,System.String,System.Boolean)");
	_il2cpp_icall_func(___0_handle, ___1_name, ___2_value);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetBoolID(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetBoolID_m9D7D23783C516EBA887139E4F3C2089D4F6630C9 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_id, bool ___2_value, const RuntimeMethod* method) 
{
	typedef void (*AnimatorControllerPlayable_SetBoolID_m9D7D23783C516EBA887139E4F3C2089D4F6630C9_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t, bool);
	static AnimatorControllerPlayable_SetBoolID_m9D7D23783C516EBA887139E4F3C2089D4F6630C9_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_SetBoolID_m9D7D23783C516EBA887139E4F3C2089D4F6630C9_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::SetBoolID(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Boolean)");
	_il2cpp_icall_func(___0_handle, ___1_id, ___2_value);
}
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::GetBoolString(UnityEngine.Playables.PlayableHandle&,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_GetBoolString_mECF14FDF6E8B96688869FD00C1CC5F91C54EAB16 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, String_t* ___1_name, const RuntimeMethod* method) 
{
	typedef bool (*AnimatorControllerPlayable_GetBoolString_mECF14FDF6E8B96688869FD00C1CC5F91C54EAB16_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, String_t*);
	static AnimatorControllerPlayable_GetBoolString_mECF14FDF6E8B96688869FD00C1CC5F91C54EAB16_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_GetBoolString_mECF14FDF6E8B96688869FD00C1CC5F91C54EAB16_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::GetBoolString(UnityEngine.Playables.PlayableHandle&,System.String)");
	bool icallRetVal = _il2cpp_icall_func(___0_handle, ___1_name);
	return icallRetVal;
}
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::GetBoolID(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_GetBoolID_m7061D395F3200F2128DC6320515789ECB1350D4F (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_id, const RuntimeMethod* method) 
{
	typedef bool (*AnimatorControllerPlayable_GetBoolID_m7061D395F3200F2128DC6320515789ECB1350D4F_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t);
	static AnimatorControllerPlayable_GetBoolID_m7061D395F3200F2128DC6320515789ECB1350D4F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_GetBoolID_m7061D395F3200F2128DC6320515789ECB1350D4F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::GetBoolID(UnityEngine.Playables.PlayableHandle&,System.Int32)");
	bool icallRetVal = _il2cpp_icall_func(___0_handle, ___1_id);
	return icallRetVal;
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetIntegerString(UnityEngine.Playables.PlayableHandle&,System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetIntegerString_mDC746DB1E487E0A5FB8258FB1FB697D3FEB14579 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, String_t* ___1_name, int32_t ___2_value, const RuntimeMethod* method) 
{
	typedef void (*AnimatorControllerPlayable_SetIntegerString_mDC746DB1E487E0A5FB8258FB1FB697D3FEB14579_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, String_t*, int32_t);
	static AnimatorControllerPlayable_SetIntegerString_mDC746DB1E487E0A5FB8258FB1FB697D3FEB14579_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_SetIntegerString_mDC746DB1E487E0A5FB8258FB1FB697D3FEB14579_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::SetIntegerString(UnityEngine.Playables.PlayableHandle&,System.String,System.Int32)");
	_il2cpp_icall_func(___0_handle, ___1_name, ___2_value);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetIntegerID(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetIntegerID_m683204581C2F1791D94A53D8E9E81C8C4AA25860 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_id, int32_t ___2_value, const RuntimeMethod* method) 
{
	typedef void (*AnimatorControllerPlayable_SetIntegerID_m683204581C2F1791D94A53D8E9E81C8C4AA25860_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t, int32_t);
	static AnimatorControllerPlayable_SetIntegerID_m683204581C2F1791D94A53D8E9E81C8C4AA25860_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_SetIntegerID_m683204581C2F1791D94A53D8E9E81C8C4AA25860_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::SetIntegerID(UnityEngine.Playables.PlayableHandle&,System.Int32,System.Int32)");
	_il2cpp_icall_func(___0_handle, ___1_id, ___2_value);
}
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetIntegerString(UnityEngine.Playables.PlayableHandle&,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetIntegerString_mD0C70C8553191AD4B4367CA0C1C7892097157713 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, String_t* ___1_name, const RuntimeMethod* method) 
{
	typedef int32_t (*AnimatorControllerPlayable_GetIntegerString_mD0C70C8553191AD4B4367CA0C1C7892097157713_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, String_t*);
	static AnimatorControllerPlayable_GetIntegerString_mD0C70C8553191AD4B4367CA0C1C7892097157713_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_GetIntegerString_mD0C70C8553191AD4B4367CA0C1C7892097157713_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::GetIntegerString(UnityEngine.Playables.PlayableHandle&,System.String)");
	int32_t icallRetVal = _il2cpp_icall_func(___0_handle, ___1_name);
	return icallRetVal;
}
// System.Int32 UnityEngine.Animations.AnimatorControllerPlayable::GetIntegerID(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerPlayable_GetIntegerID_m364BCCFECB516503043592BCE6093B6E71573901 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_id, const RuntimeMethod* method) 
{
	typedef int32_t (*AnimatorControllerPlayable_GetIntegerID_m364BCCFECB516503043592BCE6093B6E71573901_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t);
	static AnimatorControllerPlayable_GetIntegerID_m364BCCFECB516503043592BCE6093B6E71573901_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_GetIntegerID_m364BCCFECB516503043592BCE6093B6E71573901_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::GetIntegerID(UnityEngine.Playables.PlayableHandle&,System.Int32)");
	int32_t icallRetVal = _il2cpp_icall_func(___0_handle, ___1_id);
	return icallRetVal;
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetTriggerString(UnityEngine.Playables.PlayableHandle&,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetTriggerString_m0EC136890F3D7FC3CCE31D7D97406AEC14BA96A2 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, String_t* ___1_name, const RuntimeMethod* method) 
{
	typedef void (*AnimatorControllerPlayable_SetTriggerString_m0EC136890F3D7FC3CCE31D7D97406AEC14BA96A2_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, String_t*);
	static AnimatorControllerPlayable_SetTriggerString_m0EC136890F3D7FC3CCE31D7D97406AEC14BA96A2_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_SetTriggerString_m0EC136890F3D7FC3CCE31D7D97406AEC14BA96A2_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::SetTriggerString(UnityEngine.Playables.PlayableHandle&,System.String)");
	_il2cpp_icall_func(___0_handle, ___1_name);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetTriggerID(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetTriggerID_mB0D1B0D7CFAEA440E8582C322215E5F8843BBFF3 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_id, const RuntimeMethod* method) 
{
	typedef void (*AnimatorControllerPlayable_SetTriggerID_mB0D1B0D7CFAEA440E8582C322215E5F8843BBFF3_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t);
	static AnimatorControllerPlayable_SetTriggerID_mB0D1B0D7CFAEA440E8582C322215E5F8843BBFF3_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_SetTriggerID_mB0D1B0D7CFAEA440E8582C322215E5F8843BBFF3_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::SetTriggerID(UnityEngine.Playables.PlayableHandle&,System.Int32)");
	_il2cpp_icall_func(___0_handle, ___1_id);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::ResetTriggerString(UnityEngine.Playables.PlayableHandle&,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_ResetTriggerString_mC531FDD220C61491E53D609F021DE45AB0A517E8 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, String_t* ___1_name, const RuntimeMethod* method) 
{
	typedef void (*AnimatorControllerPlayable_ResetTriggerString_mC531FDD220C61491E53D609F021DE45AB0A517E8_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, String_t*);
	static AnimatorControllerPlayable_ResetTriggerString_mC531FDD220C61491E53D609F021DE45AB0A517E8_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_ResetTriggerString_mC531FDD220C61491E53D609F021DE45AB0A517E8_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::ResetTriggerString(UnityEngine.Playables.PlayableHandle&,System.String)");
	_il2cpp_icall_func(___0_handle, ___1_name);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::ResetTriggerID(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_ResetTriggerID_m4FB3CD3245F90046AEBEB7DAC46F4ED8A17C2E70 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_id, const RuntimeMethod* method) 
{
	typedef void (*AnimatorControllerPlayable_ResetTriggerID_m4FB3CD3245F90046AEBEB7DAC46F4ED8A17C2E70_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t);
	static AnimatorControllerPlayable_ResetTriggerID_m4FB3CD3245F90046AEBEB7DAC46F4ED8A17C2E70_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_ResetTriggerID_m4FB3CD3245F90046AEBEB7DAC46F4ED8A17C2E70_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::ResetTriggerID(UnityEngine.Playables.PlayableHandle&,System.Int32)");
	_il2cpp_icall_func(___0_handle, ___1_id);
}
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::IsParameterControlledByCurveString(UnityEngine.Playables.PlayableHandle&,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_IsParameterControlledByCurveString_m9E408D31C0E277E3B81355622EA263D0A889FFBB (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, String_t* ___1_name, const RuntimeMethod* method) 
{
	typedef bool (*AnimatorControllerPlayable_IsParameterControlledByCurveString_m9E408D31C0E277E3B81355622EA263D0A889FFBB_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, String_t*);
	static AnimatorControllerPlayable_IsParameterControlledByCurveString_m9E408D31C0E277E3B81355622EA263D0A889FFBB_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_IsParameterControlledByCurveString_m9E408D31C0E277E3B81355622EA263D0A889FFBB_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::IsParameterControlledByCurveString(UnityEngine.Playables.PlayableHandle&,System.String)");
	bool icallRetVal = _il2cpp_icall_func(___0_handle, ___1_name);
	return icallRetVal;
}
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::IsParameterControlledByCurveID(UnityEngine.Playables.PlayableHandle&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_IsParameterControlledByCurveID_m485E73DF5945A41CBD21A8F9ABDFBE9CDD0C07E6 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_id, const RuntimeMethod* method) 
{
	typedef bool (*AnimatorControllerPlayable_IsParameterControlledByCurveID_m485E73DF5945A41CBD21A8F9ABDFBE9CDD0C07E6_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t);
	static AnimatorControllerPlayable_IsParameterControlledByCurveID_m485E73DF5945A41CBD21A8F9ABDFBE9CDD0C07E6_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_IsParameterControlledByCurveID_m485E73DF5945A41CBD21A8F9ABDFBE9CDD0C07E6_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::IsParameterControlledByCurveID(UnityEngine.Playables.PlayableHandle&,System.Int32)");
	bool icallRetVal = _il2cpp_icall_func(___0_handle, ___1_id);
	return icallRetVal;
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable__cctor_m88506D1B15D609B818DFDC6B2BCFF42ABB41B090 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A L_1;
		memset((&L_1), 0, sizeof(L_1));
		AnimatorControllerPlayable__ctor_mBCB9475E2740BE1AEB94C08BAD14D51333258BFE((&L_1), L_0, /*hidden argument*/NULL);
		((AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_StaticFields*)il2cpp_codegen_static_fields_for(AnimatorControllerPlayable_tADDCB301674D6243EFE1BD032E7D118FD091210A_il2cpp_TypeInfo_var))->___m_NullPlayable_1 = L_1;
		return;
	}
}
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.RuntimeAnimatorController,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_CreateHandleInternal_Injected_mCBD001EF18F0143DD0568A9D5FBAF157206ED21D (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, RuntimeAnimatorController_t6F7C753402B42EC23C163099CF935C5E0D7A7254* ___1_controller, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___2_handle, const RuntimeMethod* method) 
{
	typedef bool (*AnimatorControllerPlayable_CreateHandleInternal_Injected_mCBD001EF18F0143DD0568A9D5FBAF157206ED21D_ftn) (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E*, RuntimeAnimatorController_t6F7C753402B42EC23C163099CF935C5E0D7A7254*, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*);
	static AnimatorControllerPlayable_CreateHandleInternal_Injected_mCBD001EF18F0143DD0568A9D5FBAF157206ED21D_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_CreateHandleInternal_Injected_mCBD001EF18F0143DD0568A9D5FBAF157206ED21D_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.RuntimeAnimatorController,UnityEngine.Playables.PlayableHandle&)");
	bool icallRetVal = _il2cpp_icall_func(___0_graph, ___1_controller, ___2_handle);
	return icallRetVal;
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorStateInfoInternal_Injected(UnityEngine.Playables.PlayableHandle&,System.Int32,UnityEngine.AnimatorStateInfo&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_GetCurrentAnimatorStateInfoInternal_Injected_m7B608D6B42D37184F7C778E9DEBCD77B350923AD (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* ___2_ret, const RuntimeMethod* method) 
{
	typedef void (*AnimatorControllerPlayable_GetCurrentAnimatorStateInfoInternal_Injected_m7B608D6B42D37184F7C778E9DEBCD77B350923AD_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t, AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2*);
	static AnimatorControllerPlayable_GetCurrentAnimatorStateInfoInternal_Injected_m7B608D6B42D37184F7C778E9DEBCD77B350923AD_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_GetCurrentAnimatorStateInfoInternal_Injected_m7B608D6B42D37184F7C778E9DEBCD77B350923AD_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorStateInfoInternal_Injected(UnityEngine.Playables.PlayableHandle&,System.Int32,UnityEngine.AnimatorStateInfo&)");
	_il2cpp_icall_func(___0_handle, ___1_layerIndex, ___2_ret);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorStateInfoInternal_Injected(UnityEngine.Playables.PlayableHandle&,System.Int32,UnityEngine.AnimatorStateInfo&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_GetNextAnimatorStateInfoInternal_Injected_m6939850E0366960A04B5B3009220B1AAC6F77D0F (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* ___2_ret, const RuntimeMethod* method) 
{
	typedef void (*AnimatorControllerPlayable_GetNextAnimatorStateInfoInternal_Injected_m6939850E0366960A04B5B3009220B1AAC6F77D0F_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t, AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2*);
	static AnimatorControllerPlayable_GetNextAnimatorStateInfoInternal_Injected_m6939850E0366960A04B5B3009220B1AAC6F77D0F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_GetNextAnimatorStateInfoInternal_Injected_m6939850E0366960A04B5B3009220B1AAC6F77D0F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorStateInfoInternal_Injected(UnityEngine.Playables.PlayableHandle&,System.Int32,UnityEngine.AnimatorStateInfo&)");
	_il2cpp_icall_func(___0_handle, ___1_layerIndex, ___2_ret);
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorTransitionInfoInternal_Injected(UnityEngine.Playables.PlayableHandle&,System.Int32,UnityEngine.AnimatorTransitionInfo&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_GetAnimatorTransitionInfoInternal_Injected_m6CFF884FDBEF401BA13CAA1F9FA68EFC56B62870 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, int32_t ___1_layerIndex, AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD* ___2_ret, const RuntimeMethod* method) 
{
	typedef void (*AnimatorControllerPlayable_GetAnimatorTransitionInfoInternal_Injected_m6CFF884FDBEF401BA13CAA1F9FA68EFC56B62870_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, int32_t, AnimatorTransitionInfo_t44894D5EDEACB368CDBA07458F6EE5F01A1F34AD*);
	static AnimatorControllerPlayable_GetAnimatorTransitionInfoInternal_Injected_m6CFF884FDBEF401BA13CAA1F9FA68EFC56B62870_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorControllerPlayable_GetAnimatorTransitionInfoInternal_Injected_m6CFF884FDBEF401BA13CAA1F9FA68EFC56B62870_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorTransitionInfoInternal_Injected(UnityEngine.Playables.PlayableHandle&,System.Int32,UnityEngine.AnimatorTransitionInfo&)");
	_il2cpp_icall_func(___0_handle, ___1_layerIndex, ___2_ret);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Animations.AnimationOffsetPlayable UnityEngine.Animations.AnimationOffsetPlayable::Create(UnityEngine.Playables.PlayableGraph,UnityEngine.Vector3,UnityEngine.Quaternion,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4 AnimationOffsetPlayable_Create_mA5D6C2A6687EC937E35D758C88300F1F0056AB39 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_position, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___2_rotation, int32_t ___3_inputCount, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4 V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_0 = ___0_graph;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = ___1_position;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_2 = ___2_rotation;
		int32_t L_3 = ___3_inputCount;
		il2cpp_codegen_runtime_class_init_inline(AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_4;
		L_4 = AnimationOffsetPlayable_CreateHandle_m27C7AEF0B9D954591B9FB7A9EF4C92CE96037518(L_0, L_1, L_2, L_3, NULL);
		V_0 = L_4;
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_5 = V_0;
		AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4 L_6;
		memset((&L_6), 0, sizeof(L_6));
		AnimationOffsetPlayable__ctor_mBF3AC6493556DAAEF608B359BEBE8FA6D9F8DBFD((&L_6), L_5, /*hidden argument*/NULL);
		V_1 = L_6;
		goto IL_0014;
	}

IL_0014:
	{
		AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4 L_7 = V_1;
		return L_7;
	}
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationOffsetPlayable::CreateHandle(UnityEngine.Playables.PlayableGraph,UnityEngine.Vector3,UnityEngine.Quaternion,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationOffsetPlayable_CreateHandle_m27C7AEF0B9D954591B9FB7A9EF4C92CE96037518 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_position, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___2_rotation, int32_t ___3_inputCount, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	bool V_1 = false;
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_2;
	memset((&V_2), 0, sizeof(V_2));
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		V_0 = L_0;
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_1 = ___0_graph;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___1_position;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_3 = ___2_rotation;
		il2cpp_codegen_runtime_class_init_inline(AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4_il2cpp_TypeInfo_var);
		bool L_4;
		L_4 = AnimationOffsetPlayable_CreateHandleInternal_m877AC3B2ED395B0C0A7FC1E2C9E44BC7A776BABF(L_1, L_2, L_3, (&V_0), NULL);
		V_1 = (bool)((((int32_t)L_4) == ((int32_t)0))? 1 : 0);
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_0020;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_6;
		L_6 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		V_2 = L_6;
		goto IL_002d;
	}

IL_0020:
	{
		int32_t L_7 = ___3_inputCount;
		PlayableHandle_SetInputCount_m6067CD3616C428F777903FCBFD789060A2185DEE((&V_0), L_7, NULL);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_8 = V_0;
		V_2 = L_8;
		goto IL_002d;
	}

IL_002d:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_9 = V_2;
		return L_9;
	}
}
// System.Void UnityEngine.Animations.AnimationOffsetPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationOffsetPlayable__ctor_mBF3AC6493556DAAEF608B359BEBE8FA6D9F8DBFD (AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_IsPlayableOfType_TisAnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4_mB35755A4D179F4DA51A96FCB3C4A8DF105C2BB12_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		bool L_0;
		L_0 = PlayableHandle_IsValid_m07631D12846BAAF2CC302E69A28A44BFE9EB5098((&___0_handle), NULL);
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0027;
		}
	}
	{
		bool L_2;
		L_2 = PlayableHandle_IsPlayableOfType_TisAnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4_mB35755A4D179F4DA51A96FCB3C4A8DF105C2BB12((&___0_handle), PlayableHandle_IsPlayableOfType_TisAnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4_mB35755A4D179F4DA51A96FCB3C4A8DF105C2BB12_RuntimeMethod_var);
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0026;
		}
	}
	{
		InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E* L_4 = (InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E_il2cpp_TypeInfo_var)));
		NullCheck(L_4);
		InvalidCastException__ctor_mED3F9781E6CA47A92C602C896EDDF2F40ECB8644(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralA3C8FF345EC45846B2EE6801F84DD49340F0A9E1)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationOffsetPlayable__ctor_mBF3AC6493556DAAEF608B359BEBE8FA6D9F8DBFD_RuntimeMethod_var)));
	}

IL_0026:
	{
	}

IL_0027:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_5 = ___0_handle;
		__this->___m_Handle_0 = L_5;
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationOffsetPlayable__ctor_mBF3AC6493556DAAEF608B359BEBE8FA6D9F8DBFD_AdjustorThunk (RuntimeObject* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method)
{
	AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4*>(__this + _offset);
	AnimationOffsetPlayable__ctor_mBF3AC6493556DAAEF608B359BEBE8FA6D9F8DBFD(_thisAdjusted, ___0_handle, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationOffsetPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationOffsetPlayable_GetHandle_m769BEFF90379AEAB0C579F7800953458CE3EBA78 (AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4* __this, const RuntimeMethod* method) 
{
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0 = __this->___m_Handle_0;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationOffsetPlayable_GetHandle_m769BEFF90379AEAB0C579F7800953458CE3EBA78_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4*>(__this + _offset);
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 _returnValue;
	_returnValue = AnimationOffsetPlayable_GetHandle_m769BEFF90379AEAB0C579F7800953458CE3EBA78(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.Playables.Playable UnityEngine.Animations.AnimationOffsetPlayable::op_Implicit(UnityEngine.Animations.AnimationOffsetPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F AnimationOffsetPlayable_op_Implicit_m0718409D76954C4C3D1F02F8B55DD39C6BC66C0F (AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4 ___0_playable, const RuntimeMethod* method) 
{
	Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = AnimationOffsetPlayable_GetHandle_m769BEFF90379AEAB0C579F7800953458CE3EBA78((&___0_playable), NULL);
		Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F L_1;
		memset((&L_1), 0, sizeof(L_1));
		Playable__ctor_mD2EB35E024816AEED68795D0124EAB30E05BF6C4((&L_1), L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F L_2 = V_0;
		return L_2;
	}
}
// System.Boolean UnityEngine.Animations.AnimationOffsetPlayable::Equals(UnityEngine.Animations.AnimationOffsetPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationOffsetPlayable_Equals_mEC28392ADD4E9639EB9228D106D93E21B3587270 (AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4* __this, AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4 ___0_other, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = AnimationOffsetPlayable_GetHandle_m769BEFF90379AEAB0C579F7800953458CE3EBA78((&___0_other), NULL);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_1 = L_0;
		RuntimeObject* L_2 = Box(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var, &L_1);
		Il2CppFakeBox<AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4> L_3(AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4_il2cpp_TypeInfo_var, __this);
		bool L_4;
		L_4 = ValueType_Equals_mCA5344597A8055EC544855AD60A983B10E0EE67D((ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F*)(&L_3), L_2, NULL);
		V_0 = L_4;
		goto IL_001c;
	}

IL_001c:
	{
		bool L_5 = V_0;
		return L_5;
	}
}
IL2CPP_EXTERN_C  bool AnimationOffsetPlayable_Equals_mEC28392ADD4E9639EB9228D106D93E21B3587270_AdjustorThunk (RuntimeObject* __this, AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4 ___0_other, const RuntimeMethod* method)
{
	AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4*>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimationOffsetPlayable_Equals_mEC28392ADD4E9639EB9228D106D93E21B3587270(_thisAdjusted, ___0_other, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.AnimationOffsetPlayable::CreateHandleInternal(UnityEngine.Playables.PlayableGraph,UnityEngine.Vector3,UnityEngine.Quaternion,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationOffsetPlayable_CreateHandleInternal_m877AC3B2ED395B0C0A7FC1E2C9E44BC7A776BABF (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_position, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___2_rotation, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___3_handle, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = ___3_handle;
		il2cpp_codegen_runtime_class_init_inline(AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = AnimationOffsetPlayable_CreateHandleInternal_Injected_m39A68EF379AFC09A9E070474CA3E19859FB41F85((&___0_graph), (&___1_position), (&___2_rotation), L_0, NULL);
		return L_1;
	}
}
// System.Void UnityEngine.Animations.AnimationOffsetPlayable::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationOffsetPlayable__cctor_m6F50D35CE1FAF52BD587DD3B440CBDE34A76B096 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4 L_1;
		memset((&L_1), 0, sizeof(L_1));
		AnimationOffsetPlayable__ctor_mBF3AC6493556DAAEF608B359BEBE8FA6D9F8DBFD((&L_1), L_0, /*hidden argument*/NULL);
		((AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4_StaticFields*)il2cpp_codegen_static_fields_for(AnimationOffsetPlayable_t39A1B1103995D63650F606BA2EA4ABDF9484AFB4_il2cpp_TypeInfo_var))->___m_NullPlayable_1 = L_1;
		return;
	}
}
// System.Boolean UnityEngine.Animations.AnimationOffsetPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationOffsetPlayable_CreateHandleInternal_Injected_m39A68EF379AFC09A9E070474CA3E19859FB41F85 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___1_position, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974* ___2_rotation, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___3_handle, const RuntimeMethod* method) 
{
	typedef bool (*AnimationOffsetPlayable_CreateHandleInternal_Injected_m39A68EF379AFC09A9E070474CA3E19859FB41F85_ftn) (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974*, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*);
	static AnimationOffsetPlayable_CreateHandleInternal_Injected_m39A68EF379AFC09A9E070474CA3E19859FB41F85_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationOffsetPlayable_CreateHandleInternal_Injected_m39A68EF379AFC09A9E070474CA3E19859FB41F85_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationOffsetPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Playables.PlayableHandle&)");
	bool icallRetVal = _il2cpp_icall_func(___0_graph, ___1_position, ___2_rotation, ___3_handle);
	return icallRetVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Animations.AnimationPlayableExtensions::SetAnimatedPropertiesInternal(UnityEngine.Playables.PlayableHandle&,UnityEngine.AnimationClip)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationPlayableExtensions_SetAnimatedPropertiesInternal_m9038247416A38E252EF0DCBCCBFE990589F4C51F (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_playable, AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* ___1_animatedProperties, const RuntimeMethod* method) 
{
	typedef void (*AnimationPlayableExtensions_SetAnimatedPropertiesInternal_m9038247416A38E252EF0DCBCCBFE990589F4C51F_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712*);
	static AnimationPlayableExtensions_SetAnimatedPropertiesInternal_m9038247416A38E252EF0DCBCCBFE990589F4C51F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationPlayableExtensions_SetAnimatedPropertiesInternal_m9038247416A38E252EF0DCBCCBFE990589F4C51F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationPlayableExtensions::SetAnimatedPropertiesInternal(UnityEngine.Playables.PlayableHandle&,UnityEngine.AnimationClip)");
	_il2cpp_icall_func(___0_playable, ___1_animatedProperties);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Animations.AnimationPlayableGraphExtensions::SyncUpdateAndTimeMode(UnityEngine.Playables.PlayableGraph,UnityEngine.Animator)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationPlayableGraphExtensions_SyncUpdateAndTimeMode_mBF6173908DA7C04947C405230A1D66F108E7F493 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___1_animator, const RuntimeMethod* method) 
{
	{
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_0 = ___1_animator;
		AnimationPlayableGraphExtensions_InternalSyncUpdateAndTimeMode_m7C6C30F3FC2930979C825953394E8C9F6D35E3F3((&___0_graph), L_0, NULL);
		return;
	}
}
// System.Boolean UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalCreateAnimationOutput(UnityEngine.Playables.PlayableGraph&,System.String,UnityEngine.Playables.PlayableOutputHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationPlayableGraphExtensions_InternalCreateAnimationOutput_m2FBE35C9ADFA39052F34E49F46E39CEBD10F4B49 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, String_t* ___1_name, PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883* ___2_handle, const RuntimeMethod* method) 
{
	typedef bool (*AnimationPlayableGraphExtensions_InternalCreateAnimationOutput_m2FBE35C9ADFA39052F34E49F46E39CEBD10F4B49_ftn) (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E*, String_t*, PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883*);
	static AnimationPlayableGraphExtensions_InternalCreateAnimationOutput_m2FBE35C9ADFA39052F34E49F46E39CEBD10F4B49_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationPlayableGraphExtensions_InternalCreateAnimationOutput_m2FBE35C9ADFA39052F34E49F46E39CEBD10F4B49_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalCreateAnimationOutput(UnityEngine.Playables.PlayableGraph&,System.String,UnityEngine.Playables.PlayableOutputHandle&)");
	bool icallRetVal = _il2cpp_icall_func(___0_graph, ___1_name, ___2_handle);
	return icallRetVal;
}
// System.Void UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalSyncUpdateAndTimeMode(UnityEngine.Playables.PlayableGraph&,UnityEngine.Animator)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationPlayableGraphExtensions_InternalSyncUpdateAndTimeMode_m7C6C30F3FC2930979C825953394E8C9F6D35E3F3 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___1_animator, const RuntimeMethod* method) 
{
	typedef void (*AnimationPlayableGraphExtensions_InternalSyncUpdateAndTimeMode_m7C6C30F3FC2930979C825953394E8C9F6D35E3F3_ftn) (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E*, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*);
	static AnimationPlayableGraphExtensions_InternalSyncUpdateAndTimeMode_m7C6C30F3FC2930979C825953394E8C9F6D35E3F3_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationPlayableGraphExtensions_InternalSyncUpdateAndTimeMode_m7C6C30F3FC2930979C825953394E8C9F6D35E3F3_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalSyncUpdateAndTimeMode(UnityEngine.Playables.PlayableGraph&,UnityEngine.Animator)");
	_il2cpp_icall_func(___0_graph, ___1_animator);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Animations.LookAtConstraint::set_constraintActive(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LookAtConstraint_set_constraintActive_m00CCD8C06EE6B997DBDA4AE7D1785CE6DF7099C4 (LookAtConstraint_t2B4569F15EA2736FAC97AD3DE35B093AE8B5D919* __this, bool ___0_value, const RuntimeMethod* method) 
{
	typedef void (*LookAtConstraint_set_constraintActive_m00CCD8C06EE6B997DBDA4AE7D1785CE6DF7099C4_ftn) (LookAtConstraint_t2B4569F15EA2736FAC97AD3DE35B093AE8B5D919*, bool);
	static LookAtConstraint_set_constraintActive_m00CCD8C06EE6B997DBDA4AE7D1785CE6DF7099C4_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (LookAtConstraint_set_constraintActive_m00CCD8C06EE6B997DBDA4AE7D1785CE6DF7099C4_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.LookAtConstraint::set_constraintActive(System.Boolean)");
	_il2cpp_icall_func(__this, ___0_value);
}
// System.Void UnityEngine.Animations.LookAtConstraint::SetSources(System.Collections.Generic.List`1<UnityEngine.Animations.ConstraintSource>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LookAtConstraint_SetSources_m331DB216D4DD9A3D4506C302B3CF934559D75553 (LookAtConstraint_t2B4569F15EA2736FAC97AD3DE35B093AE8B5D919* __this, List_1_tF88FB42B55EA7DB2BFC546CB9573DFF2D6F0AECE* ___0_sources, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		List_1_tF88FB42B55EA7DB2BFC546CB9573DFF2D6F0AECE* L_0 = ___0_sources;
		V_0 = (bool)((((RuntimeObject*)(List_1_tF88FB42B55EA7DB2BFC546CB9573DFF2D6F0AECE*)L_0) == ((RuntimeObject*)(RuntimeObject*)NULL))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0014;
		}
	}
	{
		ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129* L_2 = (ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129_il2cpp_TypeInfo_var)));
		NullCheck(L_2);
		ArgumentNullException__ctor_m444AE141157E333844FC1A9500224C2F9FD24F4B(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralCE23A35A2628159F4561C7D26935D3658D22EA68)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&LookAtConstraint_SetSources_m331DB216D4DD9A3D4506C302B3CF934559D75553_RuntimeMethod_var)));
	}

IL_0014:
	{
		List_1_tF88FB42B55EA7DB2BFC546CB9573DFF2D6F0AECE* L_3 = ___0_sources;
		LookAtConstraint_SetSourcesInternal_mDDF9B75472D8E0EAD24D3AD670A8A585D304D29A(__this, L_3, NULL);
		return;
	}
}
// System.Void UnityEngine.Animations.LookAtConstraint::SetSourcesInternal(UnityEngine.Animations.LookAtConstraint,System.Collections.Generic.List`1<UnityEngine.Animations.ConstraintSource>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LookAtConstraint_SetSourcesInternal_mDDF9B75472D8E0EAD24D3AD670A8A585D304D29A (LookAtConstraint_t2B4569F15EA2736FAC97AD3DE35B093AE8B5D919* ___0_self, List_1_tF88FB42B55EA7DB2BFC546CB9573DFF2D6F0AECE* ___1_sources, const RuntimeMethod* method) 
{
	typedef void (*LookAtConstraint_SetSourcesInternal_mDDF9B75472D8E0EAD24D3AD670A8A585D304D29A_ftn) (LookAtConstraint_t2B4569F15EA2736FAC97AD3DE35B093AE8B5D919*, List_1_tF88FB42B55EA7DB2BFC546CB9573DFF2D6F0AECE*);
	static LookAtConstraint_SetSourcesInternal_mDDF9B75472D8E0EAD24D3AD670A8A585D304D29A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (LookAtConstraint_SetSourcesInternal_mDDF9B75472D8E0EAD24D3AD670A8A585D304D29A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.LookAtConstraint::SetSourcesInternal(UnityEngine.Animations.LookAtConstraint,System.Collections.Generic.List`1<UnityEngine.Animations.ConstraintSource>)");
	_il2cpp_icall_func(___0_self, ___1_sources);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Animations.AnimationScriptPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationScriptPlayable__ctor_m6DEFD72735E79009FC1484AA2A7A82E6CE601247 (AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_IsPlayableOfType_TisAnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127_m4F637AD893630043482383791FA7A0285EB16F6E_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		bool L_0;
		L_0 = PlayableHandle_IsValid_m07631D12846BAAF2CC302E69A28A44BFE9EB5098((&___0_handle), NULL);
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0027;
		}
	}
	{
		bool L_2;
		L_2 = PlayableHandle_IsPlayableOfType_TisAnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127_m4F637AD893630043482383791FA7A0285EB16F6E((&___0_handle), PlayableHandle_IsPlayableOfType_TisAnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127_m4F637AD893630043482383791FA7A0285EB16F6E_RuntimeMethod_var);
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0026;
		}
	}
	{
		InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E* L_4 = (InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E_il2cpp_TypeInfo_var)));
		NullCheck(L_4);
		InvalidCastException__ctor_mED3F9781E6CA47A92C602C896EDDF2F40ECB8644(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral860B9EA7CDAB02A8A4B38336805EAE2FBA31F09C)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationScriptPlayable__ctor_m6DEFD72735E79009FC1484AA2A7A82E6CE601247_RuntimeMethod_var)));
	}

IL_0026:
	{
	}

IL_0027:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_5 = ___0_handle;
		__this->___m_Handle_0 = L_5;
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationScriptPlayable__ctor_m6DEFD72735E79009FC1484AA2A7A82E6CE601247_AdjustorThunk (RuntimeObject* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method)
{
	AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127*>(__this + _offset);
	AnimationScriptPlayable__ctor_m6DEFD72735E79009FC1484AA2A7A82E6CE601247(_thisAdjusted, ___0_handle, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationScriptPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationScriptPlayable_GetHandle_m30355B6EE1AA3BA36D628251FB4291386D223646 (AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127* __this, const RuntimeMethod* method) 
{
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0 = __this->___m_Handle_0;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationScriptPlayable_GetHandle_m30355B6EE1AA3BA36D628251FB4291386D223646_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127*>(__this + _offset);
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 _returnValue;
	_returnValue = AnimationScriptPlayable_GetHandle_m30355B6EE1AA3BA36D628251FB4291386D223646(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.Playables.Playable UnityEngine.Animations.AnimationScriptPlayable::op_Implicit(UnityEngine.Animations.AnimationScriptPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F AnimationScriptPlayable_op_Implicit_mBF02678AFA7A679981EED33224D5B2E3AEB215C0 (AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127 ___0_playable, const RuntimeMethod* method) 
{
	Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = AnimationScriptPlayable_GetHandle_m30355B6EE1AA3BA36D628251FB4291386D223646((&___0_playable), NULL);
		Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F L_1;
		memset((&L_1), 0, sizeof(L_1));
		Playable__ctor_mD2EB35E024816AEED68795D0124EAB30E05BF6C4((&L_1), L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F L_2 = V_0;
		return L_2;
	}
}
// UnityEngine.Animations.AnimationScriptPlayable UnityEngine.Animations.AnimationScriptPlayable::op_Explicit(UnityEngine.Playables.Playable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127 AnimationScriptPlayable_op_Explicit_mD74C3B99C11B5A3421E1240186EF49E475EA279D (Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F ___0_playable, const RuntimeMethod* method) 
{
	AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = Playable_GetHandle_m39356D23E849DC5428B262092657662C064E04F8((&___0_playable), NULL);
		AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127 L_1;
		memset((&L_1), 0, sizeof(L_1));
		AnimationScriptPlayable__ctor_m6DEFD72735E79009FC1484AA2A7A82E6CE601247((&L_1), L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127 L_2 = V_0;
		return L_2;
	}
}
// System.Boolean UnityEngine.Animations.AnimationScriptPlayable::Equals(UnityEngine.Animations.AnimationScriptPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationScriptPlayable_Equals_mAD02E40704CBE4AB188DE0569052F8EA9864F4E4 (AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127* __this, AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127 ___0_other, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = AnimationScriptPlayable_GetHandle_m30355B6EE1AA3BA36D628251FB4291386D223646(__this, NULL);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_1;
		L_1 = AnimationScriptPlayable_GetHandle_m30355B6EE1AA3BA36D628251FB4291386D223646((&___0_other), NULL);
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = PlayableHandle_op_Equality_m0E6C48A28F75A870AC22ADE3BD42F7F70A43C99C(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0016;
	}

IL_0016:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool AnimationScriptPlayable_Equals_mAD02E40704CBE4AB188DE0569052F8EA9864F4E4_AdjustorThunk (RuntimeObject* __this, AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127 ___0_other, const RuntimeMethod* method)
{
	AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127*>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimationScriptPlayable_Equals_mAD02E40704CBE4AB188DE0569052F8EA9864F4E4(_thisAdjusted, ___0_other, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimationScriptPlayable::SetProcessInputs(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationScriptPlayable_SetProcessInputs_mF7DE3561731A6513E8FE0F0A85B0C38959621839 (AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127* __this, bool ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = AnimationScriptPlayable_GetHandle_m30355B6EE1AA3BA36D628251FB4291386D223646(__this, NULL);
		bool L_1 = ___0_value;
		il2cpp_codegen_runtime_class_init_inline(AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127_il2cpp_TypeInfo_var);
		AnimationScriptPlayable_SetProcessInputsInternal_m2ACAC5C02655BBBF15A32B06F5CF1BAFC0775D9A(L_0, L_1, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationScriptPlayable_SetProcessInputs_mF7DE3561731A6513E8FE0F0A85B0C38959621839_AdjustorThunk (RuntimeObject* __this, bool ___0_value, const RuntimeMethod* method)
{
	AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127*>(__this + _offset);
	AnimationScriptPlayable_SetProcessInputs_mF7DE3561731A6513E8FE0F0A85B0C38959621839(_thisAdjusted, ___0_value, method);
}
// System.Boolean UnityEngine.Animations.AnimationScriptPlayable::CreateHandleInternal(UnityEngine.Playables.PlayableGraph,UnityEngine.Playables.PlayableHandle&,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationScriptPlayable_CreateHandleInternal_m0E0B65982F224BCD21CAD27DF8758C67A65296EC (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___1_handle, intptr_t ___2_jobReflectionData, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = ___1_handle;
		intptr_t L_1 = ___2_jobReflectionData;
		il2cpp_codegen_runtime_class_init_inline(AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = AnimationScriptPlayable_CreateHandleInternal_Injected_m6DD2A68DB5A0F7A25529B1899FB308F248C557E3((&___0_graph), L_0, L_1, NULL);
		return L_2;
	}
}
// System.Void UnityEngine.Animations.AnimationScriptPlayable::SetProcessInputsInternal(UnityEngine.Playables.PlayableHandle,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationScriptPlayable_SetProcessInputsInternal_m2ACAC5C02655BBBF15A32B06F5CF1BAFC0775D9A (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, bool ___1_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		bool L_0 = ___1_value;
		il2cpp_codegen_runtime_class_init_inline(AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127_il2cpp_TypeInfo_var);
		AnimationScriptPlayable_SetProcessInputsInternal_Injected_mD82651E462942B43F51D5C4456ABD600F159FD15((&___0_handle), L_0, NULL);
		return;
	}
}
// System.Void UnityEngine.Animations.AnimationScriptPlayable::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationScriptPlayable__cctor_m5ED4D3FC06BC7A51D3A48B5611F759CB00F7CF54 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127 L_1;
		memset((&L_1), 0, sizeof(L_1));
		AnimationScriptPlayable__ctor_m6DEFD72735E79009FC1484AA2A7A82E6CE601247((&L_1), L_0, /*hidden argument*/NULL);
		((AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127_StaticFields*)il2cpp_codegen_static_fields_for(AnimationScriptPlayable_t1326433F6848D93D7D90BC54B4AB6649A5D59127_il2cpp_TypeInfo_var))->___m_NullPlayable_1 = L_1;
		return;
	}
}
// System.Boolean UnityEngine.Animations.AnimationScriptPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Playables.PlayableHandle&,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationScriptPlayable_CreateHandleInternal_Injected_m6DD2A68DB5A0F7A25529B1899FB308F248C557E3 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___1_handle, intptr_t ___2_jobReflectionData, const RuntimeMethod* method) 
{
	typedef bool (*AnimationScriptPlayable_CreateHandleInternal_Injected_m6DD2A68DB5A0F7A25529B1899FB308F248C557E3_ftn) (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E*, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, intptr_t);
	static AnimationScriptPlayable_CreateHandleInternal_Injected_m6DD2A68DB5A0F7A25529B1899FB308F248C557E3_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationScriptPlayable_CreateHandleInternal_Injected_m6DD2A68DB5A0F7A25529B1899FB308F248C557E3_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationScriptPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Playables.PlayableHandle&,System.IntPtr)");
	bool icallRetVal = _il2cpp_icall_func(___0_graph, ___1_handle, ___2_jobReflectionData);
	return icallRetVal;
}
// System.Void UnityEngine.Animations.AnimationScriptPlayable::SetProcessInputsInternal_Injected(UnityEngine.Playables.PlayableHandle&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationScriptPlayable_SetProcessInputsInternal_Injected_mD82651E462942B43F51D5C4456ABD600F159FD15 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, bool ___1_value, const RuntimeMethod* method) 
{
	typedef void (*AnimationScriptPlayable_SetProcessInputsInternal_Injected_mD82651E462942B43F51D5C4456ABD600F159FD15_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, bool);
	static AnimationScriptPlayable_SetProcessInputsInternal_Injected_mD82651E462942B43F51D5C4456ABD600F159FD15_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationScriptPlayable_SetProcessInputsInternal_Injected_mD82651E462942B43F51D5C4456ABD600F159FD15_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationScriptPlayable::SetProcessInputsInternal_Injected(UnityEngine.Playables.PlayableHandle&,System.Boolean)");
	_il2cpp_icall_func(___0_handle, ___1_value);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Animations.AnimationLayerMixerPlayable UnityEngine.Animations.AnimationLayerMixerPlayable::Create(UnityEngine.Playables.PlayableGraph,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D AnimationLayerMixerPlayable_Create_m572693A593412F4C58DDB479B346D14AB8D8AA48 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, int32_t ___1_inputCount, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_0 = ___0_graph;
		int32_t L_1 = ___1_inputCount;
		il2cpp_codegen_runtime_class_init_inline(AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_il2cpp_TypeInfo_var);
		AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D L_2;
		L_2 = AnimationLayerMixerPlayable_Create_mB080375BE13D2A1159D6AD4AB45FB10C36E389FF(L_0, L_1, (bool)1, NULL);
		V_0 = L_2;
		goto IL_000c;
	}

IL_000c:
	{
		AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D L_3 = V_0;
		return L_3;
	}
}
// UnityEngine.Animations.AnimationLayerMixerPlayable UnityEngine.Animations.AnimationLayerMixerPlayable::Create(UnityEngine.Playables.PlayableGraph,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D AnimationLayerMixerPlayable_Create_mB080375BE13D2A1159D6AD4AB45FB10C36E389FF (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, int32_t ___1_inputCount, bool ___2_singleLayerOptimization, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D V_1;
	memset((&V_1), 0, sizeof(V_1));
	AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D V_2;
	memset((&V_2), 0, sizeof(V_2));
	{
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_0 = ___0_graph;
		int32_t L_1 = ___1_inputCount;
		il2cpp_codegen_runtime_class_init_inline(AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_2;
		L_2 = AnimationLayerMixerPlayable_CreateHandle_m74B2930D89DABE9160B08D8C92D6EA6622D88A1D(L_0, L_1, NULL);
		V_0 = L_2;
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_3 = V_0;
		bool L_4 = ___2_singleLayerOptimization;
		AnimationLayerMixerPlayable__ctor_m28884B8B9F7E057DF947E3B43ED78EA107368BD6((&V_1), L_3, L_4, NULL);
		AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D L_5 = V_1;
		V_2 = L_5;
		goto IL_0016;
	}

IL_0016:
	{
		AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D L_6 = V_2;
		return L_6;
	}
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationLayerMixerPlayable::CreateHandle(UnityEngine.Playables.PlayableGraph,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationLayerMixerPlayable_CreateHandle_m74B2930D89DABE9160B08D8C92D6EA6622D88A1D (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, int32_t ___1_inputCount, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	bool V_1 = false;
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_2;
	memset((&V_2), 0, sizeof(V_2));
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		V_0 = L_0;
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_1 = ___0_graph;
		il2cpp_codegen_runtime_class_init_inline(AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = AnimationLayerMixerPlayable_CreateHandleInternal_mEEEEBA10E6AD409C8CAF16BDF7F0E89E47A91FC8(L_1, (&V_0), NULL);
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_001e;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_4;
		L_4 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		V_2 = L_4;
		goto IL_002b;
	}

IL_001e:
	{
		int32_t L_5 = ___1_inputCount;
		PlayableHandle_SetInputCount_m6067CD3616C428F777903FCBFD789060A2185DEE((&V_0), L_5, NULL);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_6 = V_0;
		V_2 = L_6;
		goto IL_002b;
	}

IL_002b:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_7 = V_2;
		return L_7;
	}
}
// System.Void UnityEngine.Animations.AnimationLayerMixerPlayable::.ctor(UnityEngine.Playables.PlayableHandle,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationLayerMixerPlayable__ctor_m28884B8B9F7E057DF947E3B43ED78EA107368BD6 (AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, bool ___1_singleLayerOptimization, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_IsPlayableOfType_TisAnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_m23764EE36FE7A81A245C7146FF1E9DF6530DA321_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		bool L_0;
		L_0 = PlayableHandle_IsValid_m07631D12846BAAF2CC302E69A28A44BFE9EB5098((&___0_handle), NULL);
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0030;
		}
	}
	{
		bool L_2;
		L_2 = PlayableHandle_IsPlayableOfType_TisAnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_m23764EE36FE7A81A245C7146FF1E9DF6530DA321((&___0_handle), PlayableHandle_IsPlayableOfType_TisAnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_m23764EE36FE7A81A245C7146FF1E9DF6530DA321_RuntimeMethod_var);
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0026;
		}
	}
	{
		InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E* L_4 = (InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E_il2cpp_TypeInfo_var)));
		NullCheck(L_4);
		InvalidCastException__ctor_mED3F9781E6CA47A92C602C896EDDF2F40ECB8644(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralD2435BFAEB0372E848D9BE812E3B06AB862CC3D1)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationLayerMixerPlayable__ctor_m28884B8B9F7E057DF947E3B43ED78EA107368BD6_RuntimeMethod_var)));
	}

IL_0026:
	{
		bool L_5 = ___1_singleLayerOptimization;
		il2cpp_codegen_runtime_class_init_inline(AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_il2cpp_TypeInfo_var);
		AnimationLayerMixerPlayable_SetSingleLayerOptimizationInternal_mF1EC1B461F2CCB8D7E01799875DDB5FC8FE4BBDB((&___0_handle), L_5, NULL);
	}

IL_0030:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_6 = ___0_handle;
		__this->___m_Handle_0 = L_6;
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationLayerMixerPlayable__ctor_m28884B8B9F7E057DF947E3B43ED78EA107368BD6_AdjustorThunk (RuntimeObject* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, bool ___1_singleLayerOptimization, const RuntimeMethod* method)
{
	AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D*>(__this + _offset);
	AnimationLayerMixerPlayable__ctor_m28884B8B9F7E057DF947E3B43ED78EA107368BD6(_thisAdjusted, ___0_handle, ___1_singleLayerOptimization, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationLayerMixerPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationLayerMixerPlayable_GetHandle_m324A98D0B0BFC0441377D65CAE93C914F828721F (AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D* __this, const RuntimeMethod* method) 
{
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0 = __this->___m_Handle_0;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationLayerMixerPlayable_GetHandle_m324A98D0B0BFC0441377D65CAE93C914F828721F_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D*>(__this + _offset);
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 _returnValue;
	_returnValue = AnimationLayerMixerPlayable_GetHandle_m324A98D0B0BFC0441377D65CAE93C914F828721F(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.Playables.Playable UnityEngine.Animations.AnimationLayerMixerPlayable::op_Implicit(UnityEngine.Animations.AnimationLayerMixerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F AnimationLayerMixerPlayable_op_Implicit_m50234C22795358D76242C022AF5CC90DF7C0141B (AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D ___0_playable, const RuntimeMethod* method) 
{
	Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = AnimationLayerMixerPlayable_GetHandle_m324A98D0B0BFC0441377D65CAE93C914F828721F((&___0_playable), NULL);
		Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F L_1;
		memset((&L_1), 0, sizeof(L_1));
		Playable__ctor_mD2EB35E024816AEED68795D0124EAB30E05BF6C4((&L_1), L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F L_2 = V_0;
		return L_2;
	}
}
// System.Boolean UnityEngine.Animations.AnimationLayerMixerPlayable::Equals(UnityEngine.Animations.AnimationLayerMixerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationLayerMixerPlayable_Equals_mA5D24E61E2DE1140B409F3B569DBA3C185751970 (AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D* __this, AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D ___0_other, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = AnimationLayerMixerPlayable_GetHandle_m324A98D0B0BFC0441377D65CAE93C914F828721F(__this, NULL);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_1;
		L_1 = AnimationLayerMixerPlayable_GetHandle_m324A98D0B0BFC0441377D65CAE93C914F828721F((&___0_other), NULL);
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = PlayableHandle_op_Equality_m0E6C48A28F75A870AC22ADE3BD42F7F70A43C99C(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0016;
	}

IL_0016:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool AnimationLayerMixerPlayable_Equals_mA5D24E61E2DE1140B409F3B569DBA3C185751970_AdjustorThunk (RuntimeObject* __this, AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D ___0_other, const RuntimeMethod* method)
{
	AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D*>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimationLayerMixerPlayable_Equals_mA5D24E61E2DE1140B409F3B569DBA3C185751970(_thisAdjusted, ___0_other, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.AnimationLayerMixerPlayable::IsLayerAdditive(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationLayerMixerPlayable_IsLayerAdditive_m379268A18CFAD74371F6D4E0467072761BF84713 (AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D* __this, uint32_t ___0_layerIndex, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		uint32_t L_0 = ___0_layerIndex;
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_1 = (&__this->___m_Handle_0);
		int32_t L_2;
		L_2 = PlayableHandle_GetInputCount_m7FE60883E4B7C9AF7D39F28A044924ADBD5E5121(L_1, NULL);
		V_0 = (bool)((((int32_t)((((int64_t)((int64_t)(uint64_t)L_0)) < ((int64_t)((int64_t)L_2)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_0;
		if (!L_3)
		{
			goto IL_0045;
		}
	}
	{
		uint32_t L_4 = ___0_layerIndex;
		uint32_t L_5 = L_4;
		RuntimeObject* L_6 = Box(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&UInt32_t1833D51FFA667B18A5AA4B8D34DE284F8495D29B_il2cpp_TypeInfo_var)), &L_5);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_7 = (&__this->___m_Handle_0);
		int32_t L_8;
		L_8 = PlayableHandle_GetInputCount_m7FE60883E4B7C9AF7D39F28A044924ADBD5E5121(L_7, NULL);
		int32_t L_9 = ((int32_t)il2cpp_codegen_subtract(L_8, 1));
		RuntimeObject* L_10 = Box(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var)), &L_9);
		String_t* L_11;
		L_11 = String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral35525FB236D9CB0ADE03D4D22EC8AB05BBCACEA3)), L_6, L_10, NULL);
		ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F* L_12 = (ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F_il2cpp_TypeInfo_var)));
		NullCheck(L_12);
		ArgumentOutOfRangeException__ctor_mE5B2755F0BEA043CACF915D5CE140859EE58FA66(L_12, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51A170FF50F6F987DB39394B76A00962DAAC1D32)), L_11, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_12, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationLayerMixerPlayable_IsLayerAdditive_m379268A18CFAD74371F6D4E0467072761BF84713_RuntimeMethod_var)));
	}

IL_0045:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_13 = (&__this->___m_Handle_0);
		uint32_t L_14 = ___0_layerIndex;
		il2cpp_codegen_runtime_class_init_inline(AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_il2cpp_TypeInfo_var);
		bool L_15;
		L_15 = AnimationLayerMixerPlayable_IsLayerAdditiveInternal_m576416565697C3E26266D7577C4AB03041B975AE(L_13, L_14, NULL);
		V_1 = L_15;
		goto IL_0054;
	}

IL_0054:
	{
		bool L_16 = V_1;
		return L_16;
	}
}
IL2CPP_EXTERN_C  bool AnimationLayerMixerPlayable_IsLayerAdditive_m379268A18CFAD74371F6D4E0467072761BF84713_AdjustorThunk (RuntimeObject* __this, uint32_t ___0_layerIndex, const RuntimeMethod* method)
{
	AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D*>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimationLayerMixerPlayable_IsLayerAdditive_m379268A18CFAD74371F6D4E0467072761BF84713(_thisAdjusted, ___0_layerIndex, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimationLayerMixerPlayable::SetLayerAdditive(System.UInt32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationLayerMixerPlayable_SetLayerAdditive_m3B35E03C224B118E3F3D9E8A7B697AF570FBFB6E (AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D* __this, uint32_t ___0_layerIndex, bool ___1_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		uint32_t L_0 = ___0_layerIndex;
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_1 = (&__this->___m_Handle_0);
		int32_t L_2;
		L_2 = PlayableHandle_GetInputCount_m7FE60883E4B7C9AF7D39F28A044924ADBD5E5121(L_1, NULL);
		V_0 = (bool)((((int32_t)((((int64_t)((int64_t)(uint64_t)L_0)) < ((int64_t)((int64_t)L_2)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_0;
		if (!L_3)
		{
			goto IL_0045;
		}
	}
	{
		uint32_t L_4 = ___0_layerIndex;
		uint32_t L_5 = L_4;
		RuntimeObject* L_6 = Box(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&UInt32_t1833D51FFA667B18A5AA4B8D34DE284F8495D29B_il2cpp_TypeInfo_var)), &L_5);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_7 = (&__this->___m_Handle_0);
		int32_t L_8;
		L_8 = PlayableHandle_GetInputCount_m7FE60883E4B7C9AF7D39F28A044924ADBD5E5121(L_7, NULL);
		int32_t L_9 = ((int32_t)il2cpp_codegen_subtract(L_8, 1));
		RuntimeObject* L_10 = Box(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var)), &L_9);
		String_t* L_11;
		L_11 = String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral35525FB236D9CB0ADE03D4D22EC8AB05BBCACEA3)), L_6, L_10, NULL);
		ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F* L_12 = (ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F_il2cpp_TypeInfo_var)));
		NullCheck(L_12);
		ArgumentOutOfRangeException__ctor_mE5B2755F0BEA043CACF915D5CE140859EE58FA66(L_12, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51A170FF50F6F987DB39394B76A00962DAAC1D32)), L_11, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_12, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationLayerMixerPlayable_SetLayerAdditive_m3B35E03C224B118E3F3D9E8A7B697AF570FBFB6E_RuntimeMethod_var)));
	}

IL_0045:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_13 = (&__this->___m_Handle_0);
		uint32_t L_14 = ___0_layerIndex;
		bool L_15 = ___1_value;
		il2cpp_codegen_runtime_class_init_inline(AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_il2cpp_TypeInfo_var);
		AnimationLayerMixerPlayable_SetLayerAdditiveInternal_m0B39FA66BEF309D1E1FDBAA4CF1E20DA7338ADCF(L_13, L_14, L_15, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationLayerMixerPlayable_SetLayerAdditive_m3B35E03C224B118E3F3D9E8A7B697AF570FBFB6E_AdjustorThunk (RuntimeObject* __this, uint32_t ___0_layerIndex, bool ___1_value, const RuntimeMethod* method)
{
	AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D*>(__this + _offset);
	AnimationLayerMixerPlayable_SetLayerAdditive_m3B35E03C224B118E3F3D9E8A7B697AF570FBFB6E(_thisAdjusted, ___0_layerIndex, ___1_value, method);
}
// System.Void UnityEngine.Animations.AnimationLayerMixerPlayable::SetLayerMaskFromAvatarMask(System.UInt32,UnityEngine.AvatarMask)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationLayerMixerPlayable_SetLayerMaskFromAvatarMask_mC4BDE2B476AC13C31053100085FAF6BC86000280 (AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D* __this, uint32_t ___0_layerIndex, AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF* ___1_mask, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		uint32_t L_0 = ___0_layerIndex;
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_1 = (&__this->___m_Handle_0);
		int32_t L_2;
		L_2 = PlayableHandle_GetInputCount_m7FE60883E4B7C9AF7D39F28A044924ADBD5E5121(L_1, NULL);
		V_0 = (bool)((((int32_t)((((int64_t)((int64_t)(uint64_t)L_0)) < ((int64_t)((int64_t)L_2)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_0;
		if (!L_3)
		{
			goto IL_0045;
		}
	}
	{
		uint32_t L_4 = ___0_layerIndex;
		uint32_t L_5 = L_4;
		RuntimeObject* L_6 = Box(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&UInt32_t1833D51FFA667B18A5AA4B8D34DE284F8495D29B_il2cpp_TypeInfo_var)), &L_5);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_7 = (&__this->___m_Handle_0);
		int32_t L_8;
		L_8 = PlayableHandle_GetInputCount_m7FE60883E4B7C9AF7D39F28A044924ADBD5E5121(L_7, NULL);
		int32_t L_9 = ((int32_t)il2cpp_codegen_subtract(L_8, 1));
		RuntimeObject* L_10 = Box(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var)), &L_9);
		String_t* L_11;
		L_11 = String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral35525FB236D9CB0ADE03D4D22EC8AB05BBCACEA3)), L_6, L_10, NULL);
		ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F* L_12 = (ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F_il2cpp_TypeInfo_var)));
		NullCheck(L_12);
		ArgumentOutOfRangeException__ctor_mE5B2755F0BEA043CACF915D5CE140859EE58FA66(L_12, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51A170FF50F6F987DB39394B76A00962DAAC1D32)), L_11, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_12, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationLayerMixerPlayable_SetLayerMaskFromAvatarMask_mC4BDE2B476AC13C31053100085FAF6BC86000280_RuntimeMethod_var)));
	}

IL_0045:
	{
		AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF* L_13 = ___1_mask;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_14;
		L_14 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_13, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		V_1 = L_14;
		bool L_15 = V_1;
		if (!L_15)
		{
			goto IL_005b;
		}
	}
	{
		ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129* L_16 = (ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129_il2cpp_TypeInfo_var)));
		NullCheck(L_16);
		ArgumentNullException__ctor_m444AE141157E333844FC1A9500224C2F9FD24F4B(L_16, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral2ED8CAF6321ED9631D3CB63C8A7096F3AB335255)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_16, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationLayerMixerPlayable_SetLayerMaskFromAvatarMask_mC4BDE2B476AC13C31053100085FAF6BC86000280_RuntimeMethod_var)));
	}

IL_005b:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_17 = (&__this->___m_Handle_0);
		uint32_t L_18 = ___0_layerIndex;
		AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF* L_19 = ___1_mask;
		il2cpp_codegen_runtime_class_init_inline(AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_il2cpp_TypeInfo_var);
		AnimationLayerMixerPlayable_SetLayerMaskFromAvatarMaskInternal_mDA82665D20D53C1638037283DDCFE7BB2B2DD035(L_17, L_18, L_19, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationLayerMixerPlayable_SetLayerMaskFromAvatarMask_mC4BDE2B476AC13C31053100085FAF6BC86000280_AdjustorThunk (RuntimeObject* __this, uint32_t ___0_layerIndex, AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF* ___1_mask, const RuntimeMethod* method)
{
	AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D*>(__this + _offset);
	AnimationLayerMixerPlayable_SetLayerMaskFromAvatarMask_mC4BDE2B476AC13C31053100085FAF6BC86000280(_thisAdjusted, ___0_layerIndex, ___1_mask, method);
}
// System.Boolean UnityEngine.Animations.AnimationLayerMixerPlayable::CreateHandleInternal(UnityEngine.Playables.PlayableGraph,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationLayerMixerPlayable_CreateHandleInternal_mEEEEBA10E6AD409C8CAF16BDF7F0E89E47A91FC8 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___1_handle, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = ___1_handle;
		il2cpp_codegen_runtime_class_init_inline(AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = AnimationLayerMixerPlayable_CreateHandleInternal_Injected_m052C3DAAC09B1BADE847FB348E0FFFB228B17C26((&___0_graph), L_0, NULL);
		return L_1;
	}
}
// System.Boolean UnityEngine.Animations.AnimationLayerMixerPlayable::IsLayerAdditiveInternal(UnityEngine.Playables.PlayableHandle&,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationLayerMixerPlayable_IsLayerAdditiveInternal_m576416565697C3E26266D7577C4AB03041B975AE (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, uint32_t ___1_layerIndex, const RuntimeMethod* method) 
{
	typedef bool (*AnimationLayerMixerPlayable_IsLayerAdditiveInternal_m576416565697C3E26266D7577C4AB03041B975AE_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, uint32_t);
	static AnimationLayerMixerPlayable_IsLayerAdditiveInternal_m576416565697C3E26266D7577C4AB03041B975AE_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationLayerMixerPlayable_IsLayerAdditiveInternal_m576416565697C3E26266D7577C4AB03041B975AE_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationLayerMixerPlayable::IsLayerAdditiveInternal(UnityEngine.Playables.PlayableHandle&,System.UInt32)");
	bool icallRetVal = _il2cpp_icall_func(___0_handle, ___1_layerIndex);
	return icallRetVal;
}
// System.Void UnityEngine.Animations.AnimationLayerMixerPlayable::SetLayerAdditiveInternal(UnityEngine.Playables.PlayableHandle&,System.UInt32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationLayerMixerPlayable_SetLayerAdditiveInternal_m0B39FA66BEF309D1E1FDBAA4CF1E20DA7338ADCF (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, uint32_t ___1_layerIndex, bool ___2_value, const RuntimeMethod* method) 
{
	typedef void (*AnimationLayerMixerPlayable_SetLayerAdditiveInternal_m0B39FA66BEF309D1E1FDBAA4CF1E20DA7338ADCF_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, uint32_t, bool);
	static AnimationLayerMixerPlayable_SetLayerAdditiveInternal_m0B39FA66BEF309D1E1FDBAA4CF1E20DA7338ADCF_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationLayerMixerPlayable_SetLayerAdditiveInternal_m0B39FA66BEF309D1E1FDBAA4CF1E20DA7338ADCF_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationLayerMixerPlayable::SetLayerAdditiveInternal(UnityEngine.Playables.PlayableHandle&,System.UInt32,System.Boolean)");
	_il2cpp_icall_func(___0_handle, ___1_layerIndex, ___2_value);
}
// System.Void UnityEngine.Animations.AnimationLayerMixerPlayable::SetSingleLayerOptimizationInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationLayerMixerPlayable_SetSingleLayerOptimizationInternal_mF1EC1B461F2CCB8D7E01799875DDB5FC8FE4BBDB (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, bool ___1_value, const RuntimeMethod* method) 
{
	typedef void (*AnimationLayerMixerPlayable_SetSingleLayerOptimizationInternal_mF1EC1B461F2CCB8D7E01799875DDB5FC8FE4BBDB_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, bool);
	static AnimationLayerMixerPlayable_SetSingleLayerOptimizationInternal_mF1EC1B461F2CCB8D7E01799875DDB5FC8FE4BBDB_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationLayerMixerPlayable_SetSingleLayerOptimizationInternal_mF1EC1B461F2CCB8D7E01799875DDB5FC8FE4BBDB_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationLayerMixerPlayable::SetSingleLayerOptimizationInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)");
	_il2cpp_icall_func(___0_handle, ___1_value);
}
// System.Void UnityEngine.Animations.AnimationLayerMixerPlayable::SetLayerMaskFromAvatarMaskInternal(UnityEngine.Playables.PlayableHandle&,System.UInt32,UnityEngine.AvatarMask)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationLayerMixerPlayable_SetLayerMaskFromAvatarMaskInternal_mDA82665D20D53C1638037283DDCFE7BB2B2DD035 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, uint32_t ___1_layerIndex, AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF* ___2_mask, const RuntimeMethod* method) 
{
	typedef void (*AnimationLayerMixerPlayable_SetLayerMaskFromAvatarMaskInternal_mDA82665D20D53C1638037283DDCFE7BB2B2DD035_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, uint32_t, AvatarMask_tC1D777FFB77C952502ECF6D80FAFAD16B27B02AF*);
	static AnimationLayerMixerPlayable_SetLayerMaskFromAvatarMaskInternal_mDA82665D20D53C1638037283DDCFE7BB2B2DD035_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationLayerMixerPlayable_SetLayerMaskFromAvatarMaskInternal_mDA82665D20D53C1638037283DDCFE7BB2B2DD035_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationLayerMixerPlayable::SetLayerMaskFromAvatarMaskInternal(UnityEngine.Playables.PlayableHandle&,System.UInt32,UnityEngine.AvatarMask)");
	_il2cpp_icall_func(___0_handle, ___1_layerIndex, ___2_mask);
}
// System.Void UnityEngine.Animations.AnimationLayerMixerPlayable::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationLayerMixerPlayable__cctor_m27A78F2EB8840FFCC84901AB4E916ACCE8D8E49B (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D L_1;
		memset((&L_1), 0, sizeof(L_1));
		AnimationLayerMixerPlayable__ctor_m28884B8B9F7E057DF947E3B43ED78EA107368BD6((&L_1), L_0, (bool)1, /*hidden argument*/NULL);
		((AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_StaticFields*)il2cpp_codegen_static_fields_for(AnimationLayerMixerPlayable_tAD8D28A1E2FB76567E9748CDD11699AEF0B4317D_il2cpp_TypeInfo_var))->___m_NullPlayable_1 = L_1;
		return;
	}
}
// System.Boolean UnityEngine.Animations.AnimationLayerMixerPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationLayerMixerPlayable_CreateHandleInternal_Injected_m052C3DAAC09B1BADE847FB348E0FFFB228B17C26 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___1_handle, const RuntimeMethod* method) 
{
	typedef bool (*AnimationLayerMixerPlayable_CreateHandleInternal_Injected_m052C3DAAC09B1BADE847FB348E0FFFB228B17C26_ftn) (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E*, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*);
	static AnimationLayerMixerPlayable_CreateHandleInternal_Injected_m052C3DAAC09B1BADE847FB348E0FFFB228B17C26_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationLayerMixerPlayable_CreateHandleInternal_Injected_m052C3DAAC09B1BADE847FB348E0FFFB228B17C26_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationLayerMixerPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Playables.PlayableHandle&)");
	bool icallRetVal = _il2cpp_icall_func(___0_graph, ___1_handle);
	return icallRetVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Boolean UnityEngine.Animations.TransformStreamHandle::IsValidInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransformStreamHandle_IsValidInternal_mBF1602E33ABCA25121C7CF70173D29C5291354CC (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) 
{
	bool V_0 = false;
	int32_t G_B4_0 = 0;
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_0 = ___0_stream;
		bool L_1;
		L_1 = AnimationStream_get_isValid_mE1F032BDA653D5A903DCD427F4677A6C9C4C227A(L_0, NULL);
		if (!L_1)
		{
			goto IL_0019;
		}
	}
	{
		bool L_2;
		L_2 = TransformStreamHandle_get_createdByNative_mCC27504004588C367456D55E8295B745BE2431AC(__this, NULL);
		if (!L_2)
		{
			goto IL_0019;
		}
	}
	{
		bool L_3;
		L_3 = TransformStreamHandle_get_hasHandleIndex_m164F6D37B1A6B74214B09E1E6798C275C71716D1(__this, NULL);
		G_B4_0 = ((int32_t)(L_3));
		goto IL_001a;
	}

IL_0019:
	{
		G_B4_0 = 0;
	}

IL_001a:
	{
		V_0 = (bool)G_B4_0;
		goto IL_001d;
	}

IL_001d:
	{
		bool L_4 = V_0;
		return L_4;
	}
}
IL2CPP_EXTERN_C  bool TransformStreamHandle_IsValidInternal_mBF1602E33ABCA25121C7CF70173D29C5291354CC_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method)
{
	TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*>(__this + _offset);
	bool _returnValue;
	_returnValue = TransformStreamHandle_IsValidInternal_mBF1602E33ABCA25121C7CF70173D29C5291354CC(_thisAdjusted, ___0_stream, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.TransformStreamHandle::get_createdByNative()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransformStreamHandle_get_createdByNative_mCC27504004588C367456D55E8295B745BE2431AC (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		uint32_t L_0;
		L_0 = TransformStreamHandle_get_animatorBindingsVersion_mD044F88843A162A554BA7EF191E52B58F9F0AFF8(__this, NULL);
		V_0 = (bool)((!(((uint32_t)L_0) <= ((uint32_t)0)))? 1 : 0);
		goto IL_000d;
	}

IL_000d:
	{
		bool L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  bool TransformStreamHandle_get_createdByNative_mCC27504004588C367456D55E8295B745BE2431AC_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*>(__this + _offset);
	bool _returnValue;
	_returnValue = TransformStreamHandle_get_createdByNative_mCC27504004588C367456D55E8295B745BE2431AC(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.TransformStreamHandle::IsSameVersionAsStream(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransformStreamHandle_IsSameVersionAsStream_m31E41B516413440AC8F4D5F9F233623A6DE71365 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		uint32_t L_0;
		L_0 = TransformStreamHandle_get_animatorBindingsVersion_mD044F88843A162A554BA7EF191E52B58F9F0AFF8(__this, NULL);
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_1 = ___0_stream;
		uint32_t L_2;
		L_2 = AnimationStream_get_animatorBindingsVersion_mD7D19DCE96F93CE4DC36457F974C5B8562A3B5E4(L_1, NULL);
		V_0 = (bool)((((int32_t)L_0) == ((int32_t)L_2))? 1 : 0);
		goto IL_0012;
	}

IL_0012:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool TransformStreamHandle_IsSameVersionAsStream_m31E41B516413440AC8F4D5F9F233623A6DE71365_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method)
{
	TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*>(__this + _offset);
	bool _returnValue;
	_returnValue = TransformStreamHandle_IsSameVersionAsStream_m31E41B516413440AC8F4D5F9F233623A6DE71365(_thisAdjusted, ___0_stream, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.TransformStreamHandle::get_hasHandleIndex()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransformStreamHandle_get_hasHandleIndex_m164F6D37B1A6B74214B09E1E6798C275C71716D1 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		int32_t L_0 = __this->___handleIndex_1;
		V_0 = (bool)((((int32_t)((((int32_t)L_0) == ((int32_t)(-1)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_0010;
	}

IL_0010:
	{
		bool L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  bool TransformStreamHandle_get_hasHandleIndex_m164F6D37B1A6B74214B09E1E6798C275C71716D1_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*>(__this + _offset);
	bool _returnValue;
	_returnValue = TransformStreamHandle_get_hasHandleIndex_m164F6D37B1A6B74214B09E1E6798C275C71716D1(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.TransformStreamHandle::get_hasSkeletonIndex()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransformStreamHandle_get_hasSkeletonIndex_m8B9589FACB6810B0EFD84033D30057ADFBC4B75F (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		int32_t L_0 = __this->___skeletonIndex_2;
		V_0 = (bool)((((int32_t)((((int32_t)L_0) == ((int32_t)(-1)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_0010;
	}

IL_0010:
	{
		bool L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  bool TransformStreamHandle_get_hasSkeletonIndex_m8B9589FACB6810B0EFD84033D30057ADFBC4B75F_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*>(__this + _offset);
	bool _returnValue;
	_returnValue = TransformStreamHandle_get_hasSkeletonIndex_m8B9589FACB6810B0EFD84033D30057ADFBC4B75F(_thisAdjusted, method);
	return _returnValue;
}
// System.UInt32 UnityEngine.Animations.TransformStreamHandle::get_animatorBindingsVersion()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t TransformStreamHandle_get_animatorBindingsVersion_mD044F88843A162A554BA7EF191E52B58F9F0AFF8 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, const RuntimeMethod* method) 
{
	uint32_t V_0 = 0;
	{
		uint32_t L_0 = __this->___m_AnimatorBindingsVersion_0;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		uint32_t L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  uint32_t TransformStreamHandle_get_animatorBindingsVersion_mD044F88843A162A554BA7EF191E52B58F9F0AFF8_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*>(__this + _offset);
	uint32_t _returnValue;
	_returnValue = TransformStreamHandle_get_animatorBindingsVersion_mD044F88843A162A554BA7EF191E52B58F9F0AFF8(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.TransformStreamHandle::IsResolvedInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransformStreamHandle_IsResolvedInternal_m83781A03679DF4C678FE963CF21F5A2203471585 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) 
{
	bool V_0 = false;
	int32_t G_B4_0 = 0;
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_0 = ___0_stream;
		bool L_1;
		L_1 = TransformStreamHandle_IsValidInternal_mBF1602E33ABCA25121C7CF70173D29C5291354CC(__this, L_0, NULL);
		if (!L_1)
		{
			goto IL_001b;
		}
	}
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_2 = ___0_stream;
		bool L_3;
		L_3 = TransformStreamHandle_IsSameVersionAsStream_m31E41B516413440AC8F4D5F9F233623A6DE71365(__this, L_2, NULL);
		if (!L_3)
		{
			goto IL_001b;
		}
	}
	{
		bool L_4;
		L_4 = TransformStreamHandle_get_hasSkeletonIndex_m8B9589FACB6810B0EFD84033D30057ADFBC4B75F(__this, NULL);
		G_B4_0 = ((int32_t)(L_4));
		goto IL_001c;
	}

IL_001b:
	{
		G_B4_0 = 0;
	}

IL_001c:
	{
		V_0 = (bool)G_B4_0;
		goto IL_001f;
	}

IL_001f:
	{
		bool L_5 = V_0;
		return L_5;
	}
}
IL2CPP_EXTERN_C  bool TransformStreamHandle_IsResolvedInternal_m83781A03679DF4C678FE963CF21F5A2203471585_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method)
{
	TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*>(__this + _offset);
	bool _returnValue;
	_returnValue = TransformStreamHandle_IsResolvedInternal_m83781A03679DF4C678FE963CF21F5A2203471585(_thisAdjusted, ___0_stream, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.TransformStreamHandle::CheckIsValidAndResolve(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_CheckIsValidAndResolve_m7602706A5D46D99268DB6C698A6752C96A0525F6 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) 
{
	bool V_0 = false;
	bool V_1 = false;
	bool V_2 = false;
	bool V_3 = false;
	int32_t G_B5_0 = 0;
	int32_t G_B11_0 = 0;
	int32_t G_B13_0 = 0;
	int32_t G_B18_0 = 0;
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_0 = ___0_stream;
		AnimationStream_CheckIsValid_m6C46800E1A5A4BE27FF761A93F72BC3CD751174C(L_0, NULL);
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_1 = ___0_stream;
		bool L_2;
		L_2 = TransformStreamHandle_IsResolvedInternal_m83781A03679DF4C678FE963CF21F5A2203471585(__this, L_1, NULL);
		V_0 = L_2;
		bool L_3 = V_0;
		if (!L_3)
		{
			goto IL_0015;
		}
	}
	{
		goto IL_0089;
	}

IL_0015:
	{
		bool L_4;
		L_4 = TransformStreamHandle_get_createdByNative_mCC27504004588C367456D55E8295B745BE2431AC(__this, NULL);
		if (!L_4)
		{
			goto IL_0028;
		}
	}
	{
		bool L_5;
		L_5 = TransformStreamHandle_get_hasHandleIndex_m164F6D37B1A6B74214B09E1E6798C275C71716D1(__this, NULL);
		G_B5_0 = ((((int32_t)L_5) == ((int32_t)0))? 1 : 0);
		goto IL_0029;
	}

IL_0028:
	{
		G_B5_0 = 1;
	}

IL_0029:
	{
		V_1 = (bool)G_B5_0;
		bool L_6 = V_1;
		if (!L_6)
		{
			goto IL_0038;
		}
	}
	{
		InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB* L_7 = (InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB_il2cpp_TypeInfo_var)));
		NullCheck(L_7);
		InvalidOperationException__ctor_mE4CB6F4712AB6D99A2358FBAE2E052B3EE976162(L_7, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral00974C5D0A39E4A027B0EB44FE85C731384945B0)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_7, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&TransformStreamHandle_CheckIsValidAndResolve_m7602706A5D46D99268DB6C698A6752C96A0525F6_RuntimeMethod_var)));
	}

IL_0038:
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_8 = ___0_stream;
		bool L_9;
		L_9 = TransformStreamHandle_IsSameVersionAsStream_m31E41B516413440AC8F4D5F9F233623A6DE71365(__this, L_8, NULL);
		if (!L_9)
		{
			goto IL_0057;
		}
	}
	{
		bool L_10;
		L_10 = TransformStreamHandle_get_hasHandleIndex_m164F6D37B1A6B74214B09E1E6798C275C71716D1(__this, NULL);
		if (!L_10)
		{
			goto IL_0054;
		}
	}
	{
		bool L_11;
		L_11 = TransformStreamHandle_get_hasSkeletonIndex_m8B9589FACB6810B0EFD84033D30057ADFBC4B75F(__this, NULL);
		G_B11_0 = ((((int32_t)L_11) == ((int32_t)0))? 1 : 0);
		goto IL_0055;
	}

IL_0054:
	{
		G_B11_0 = 0;
	}

IL_0055:
	{
		G_B13_0 = G_B11_0;
		goto IL_0058;
	}

IL_0057:
	{
		G_B13_0 = 1;
	}

IL_0058:
	{
		V_2 = (bool)G_B13_0;
		bool L_12 = V_2;
		if (!L_12)
		{
			goto IL_0066;
		}
	}
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_13 = ___0_stream;
		TransformStreamHandle_ResolveInternal_m0008C8228981E9247DA8B0C7739DD1BF1C70EAEA(__this, L_13, NULL);
	}

IL_0066:
	{
		bool L_14;
		L_14 = TransformStreamHandle_get_hasHandleIndex_m164F6D37B1A6B74214B09E1E6798C275C71716D1(__this, NULL);
		if (!L_14)
		{
			goto IL_0079;
		}
	}
	{
		bool L_15;
		L_15 = TransformStreamHandle_get_hasSkeletonIndex_m8B9589FACB6810B0EFD84033D30057ADFBC4B75F(__this, NULL);
		G_B18_0 = ((((int32_t)L_15) == ((int32_t)0))? 1 : 0);
		goto IL_007a;
	}

IL_0079:
	{
		G_B18_0 = 0;
	}

IL_007a:
	{
		V_3 = (bool)G_B18_0;
		bool L_16 = V_3;
		if (!L_16)
		{
			goto IL_0089;
		}
	}
	{
		InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB* L_17 = (InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB_il2cpp_TypeInfo_var)));
		NullCheck(L_17);
		InvalidOperationException__ctor_mE4CB6F4712AB6D99A2358FBAE2E052B3EE976162(L_17, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral82132A808F0B9E6946BE41B8C7B1FDD0D99D773C)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_17, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&TransformStreamHandle_CheckIsValidAndResolve_m7602706A5D46D99268DB6C698A6752C96A0525F6_RuntimeMethod_var)));
	}

IL_0089:
	{
		return;
	}
}
IL2CPP_EXTERN_C  void TransformStreamHandle_CheckIsValidAndResolve_m7602706A5D46D99268DB6C698A6752C96A0525F6_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method)
{
	TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*>(__this + _offset);
	TransformStreamHandle_CheckIsValidAndResolve_m7602706A5D46D99268DB6C698A6752C96A0525F6(_thisAdjusted, ___0_stream, method);
}
// UnityEngine.Vector3 UnityEngine.Animations.TransformStreamHandle::GetPosition(UnityEngine.Animations.AnimationStream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 TransformStreamHandle_GetPosition_m8980B6C6185653E9B962625D030C3BB1994C8B89 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		TransformStreamHandle_CheckIsValidAndResolve_m7602706A5D46D99268DB6C698A6752C96A0525F6(__this, (&___0_stream), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0;
		L_0 = TransformStreamHandle_GetPositionInternal_m4D0EA1C47F1AAB4723411247DBA15135BA6A9D4C(__this, (&___0_stream), NULL);
		V_0 = L_0;
		goto IL_0015;
	}

IL_0015:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 TransformStreamHandle_GetPosition_m8980B6C6185653E9B962625D030C3BB1994C8B89_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, const RuntimeMethod* method)
{
	TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*>(__this + _offset);
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 _returnValue;
	_returnValue = TransformStreamHandle_GetPosition_m8980B6C6185653E9B962625D030C3BB1994C8B89(_thisAdjusted, ___0_stream, method);
	return _returnValue;
}
// UnityEngine.Quaternion UnityEngine.Animations.TransformStreamHandle::GetRotation(UnityEngine.Animations.AnimationStream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 TransformStreamHandle_GetRotation_m02E0CE9B403FB4138605190A48A19767D6B0C42A (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, const RuntimeMethod* method) 
{
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		TransformStreamHandle_CheckIsValidAndResolve_m7602706A5D46D99268DB6C698A6752C96A0525F6(__this, (&___0_stream), NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_0;
		L_0 = TransformStreamHandle_GetRotationInternal_m53A7E32CE6B63F588F44CAE8FCBF23C32E8393C7(__this, (&___0_stream), NULL);
		V_0 = L_0;
		goto IL_0015;
	}

IL_0015:
	{
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 TransformStreamHandle_GetRotation_m02E0CE9B403FB4138605190A48A19767D6B0C42A_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, const RuntimeMethod* method)
{
	TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*>(__this + _offset);
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 _returnValue;
	_returnValue = TransformStreamHandle_GetRotation_m02E0CE9B403FB4138605190A48A19767D6B0C42A(_thisAdjusted, ___0_stream, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.TransformStreamHandle::SetRotation(UnityEngine.Animations.AnimationStream,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_SetRotation_mA159153895AFFB08B30B8287304A720215C364D1 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___1_rotation, const RuntimeMethod* method) 
{
	{
		TransformStreamHandle_CheckIsValidAndResolve_m7602706A5D46D99268DB6C698A6752C96A0525F6(__this, (&___0_stream), NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_0 = ___1_rotation;
		TransformStreamHandle_SetRotationInternal_mE7AB735A2303DC923A69B19537FDE60B5F39CE5A(__this, (&___0_stream), L_0, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void TransformStreamHandle_SetRotation_mA159153895AFFB08B30B8287304A720215C364D1_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___1_rotation, const RuntimeMethod* method)
{
	TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*>(__this + _offset);
	TransformStreamHandle_SetRotation_mA159153895AFFB08B30B8287304A720215C364D1(_thisAdjusted, ___0_stream, ___1_rotation, method);
}
// System.Void UnityEngine.Animations.TransformStreamHandle::SetLocalRotation(UnityEngine.Animations.AnimationStream,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_SetLocalRotation_m68B0586FA34978971ECDC909A44E1E0C13443C6A (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___1_rotation, const RuntimeMethod* method) 
{
	{
		TransformStreamHandle_CheckIsValidAndResolve_m7602706A5D46D99268DB6C698A6752C96A0525F6(__this, (&___0_stream), NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_0 = ___1_rotation;
		TransformStreamHandle_SetLocalRotationInternal_mDE8F5BF1C73A90573EF3918F1C88ABB73BC10778(__this, (&___0_stream), L_0, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void TransformStreamHandle_SetLocalRotation_m68B0586FA34978971ECDC909A44E1E0C13443C6A_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___1_rotation, const RuntimeMethod* method)
{
	TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*>(__this + _offset);
	TransformStreamHandle_SetLocalRotation_m68B0586FA34978971ECDC909A44E1E0C13443C6A(_thisAdjusted, ___0_stream, ___1_rotation, method);
}
// System.Void UnityEngine.Animations.TransformStreamHandle::ResolveInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_ResolveInternal_m0008C8228981E9247DA8B0C7739DD1BF1C70EAEA (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) 
{
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_0 = ___0_stream;
		TransformStreamHandle_ResolveInternal_Injected_m3C2F5E0470031F9C0D33DD5C7C392F8B671B9CED(__this, L_0, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void TransformStreamHandle_ResolveInternal_m0008C8228981E9247DA8B0C7739DD1BF1C70EAEA_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method)
{
	TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*>(__this + _offset);
	TransformStreamHandle_ResolveInternal_m0008C8228981E9247DA8B0C7739DD1BF1C70EAEA(_thisAdjusted, ___0_stream, method);
}
// UnityEngine.Vector3 UnityEngine.Animations.TransformStreamHandle::GetPositionInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 TransformStreamHandle_GetPositionInternal_m4D0EA1C47F1AAB4723411247DBA15135BA6A9D4C (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_0 = ___0_stream;
		TransformStreamHandle_GetPositionInternal_Injected_m3C3917F08A68CD4E24653CB78AEEA3577E043462(__this, L_0, (&V_0), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 TransformStreamHandle_GetPositionInternal_m4D0EA1C47F1AAB4723411247DBA15135BA6A9D4C_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method)
{
	TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*>(__this + _offset);
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 _returnValue;
	_returnValue = TransformStreamHandle_GetPositionInternal_m4D0EA1C47F1AAB4723411247DBA15135BA6A9D4C(_thisAdjusted, ___0_stream, method);
	return _returnValue;
}
// UnityEngine.Quaternion UnityEngine.Animations.TransformStreamHandle::GetRotationInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 TransformStreamHandle_GetRotationInternal_m53A7E32CE6B63F588F44CAE8FCBF23C32E8393C7 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) 
{
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_0 = ___0_stream;
		TransformStreamHandle_GetRotationInternal_Injected_m4863F14E289B9627C1ACADB750B56CD81ED6F857(__this, L_0, (&V_0), NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 TransformStreamHandle_GetRotationInternal_m53A7E32CE6B63F588F44CAE8FCBF23C32E8393C7_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method)
{
	TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*>(__this + _offset);
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 _returnValue;
	_returnValue = TransformStreamHandle_GetRotationInternal_m53A7E32CE6B63F588F44CAE8FCBF23C32E8393C7(_thisAdjusted, ___0_stream, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.TransformStreamHandle::SetRotationInternal(UnityEngine.Animations.AnimationStream&,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_SetRotationInternal_mE7AB735A2303DC923A69B19537FDE60B5F39CE5A (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___1_rotation, const RuntimeMethod* method) 
{
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_0 = ___0_stream;
		TransformStreamHandle_SetRotationInternal_Injected_m181A24DB2A658E488E3F0BC684A424547A6A7683(__this, L_0, (&___1_rotation), NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void TransformStreamHandle_SetRotationInternal_mE7AB735A2303DC923A69B19537FDE60B5F39CE5A_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___1_rotation, const RuntimeMethod* method)
{
	TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*>(__this + _offset);
	TransformStreamHandle_SetRotationInternal_mE7AB735A2303DC923A69B19537FDE60B5F39CE5A(_thisAdjusted, ___0_stream, ___1_rotation, method);
}
// System.Void UnityEngine.Animations.TransformStreamHandle::SetLocalRotationInternal(UnityEngine.Animations.AnimationStream&,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_SetLocalRotationInternal_mDE8F5BF1C73A90573EF3918F1C88ABB73BC10778 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___1_rotation, const RuntimeMethod* method) 
{
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_0 = ___0_stream;
		TransformStreamHandle_SetLocalRotationInternal_Injected_m58D671FC665AF45BE7B6753A65C3F27BDCD89EA3(__this, L_0, (&___1_rotation), NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void TransformStreamHandle_SetLocalRotationInternal_mDE8F5BF1C73A90573EF3918F1C88ABB73BC10778_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___1_rotation, const RuntimeMethod* method)
{
	TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*>(__this + _offset);
	TransformStreamHandle_SetLocalRotationInternal_mDE8F5BF1C73A90573EF3918F1C88ABB73BC10778(_thisAdjusted, ___0_stream, ___1_rotation, method);
}
// System.Void UnityEngine.Animations.TransformStreamHandle::ResolveInternal_Injected(UnityEngine.Animations.TransformStreamHandle&,UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_ResolveInternal_Injected_m3C2F5E0470031F9C0D33DD5C7C392F8B671B9CED (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, const RuntimeMethod* method) 
{
	typedef void (*TransformStreamHandle_ResolveInternal_Injected_m3C2F5E0470031F9C0D33DD5C7C392F8B671B9CED_ftn) (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A*);
	static TransformStreamHandle_ResolveInternal_Injected_m3C2F5E0470031F9C0D33DD5C7C392F8B671B9CED_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (TransformStreamHandle_ResolveInternal_Injected_m3C2F5E0470031F9C0D33DD5C7C392F8B671B9CED_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.TransformStreamHandle::ResolveInternal_Injected(UnityEngine.Animations.TransformStreamHandle&,UnityEngine.Animations.AnimationStream&)");
	_il2cpp_icall_func(___0__unity_self, ___1_stream);
}
// System.Void UnityEngine.Animations.TransformStreamHandle::GetPositionInternal_Injected(UnityEngine.Animations.TransformStreamHandle&,UnityEngine.Animations.AnimationStream&,UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_GetPositionInternal_Injected_m3C3917F08A68CD4E24653CB78AEEA3577E043462 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___2_ret, const RuntimeMethod* method) 
{
	typedef void (*TransformStreamHandle_GetPositionInternal_Injected_m3C3917F08A68CD4E24653CB78AEEA3577E043462_ftn) (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*);
	static TransformStreamHandle_GetPositionInternal_Injected_m3C3917F08A68CD4E24653CB78AEEA3577E043462_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (TransformStreamHandle_GetPositionInternal_Injected_m3C3917F08A68CD4E24653CB78AEEA3577E043462_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.TransformStreamHandle::GetPositionInternal_Injected(UnityEngine.Animations.TransformStreamHandle&,UnityEngine.Animations.AnimationStream&,UnityEngine.Vector3&)");
	_il2cpp_icall_func(___0__unity_self, ___1_stream, ___2_ret);
}
// System.Void UnityEngine.Animations.TransformStreamHandle::GetRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle&,UnityEngine.Animations.AnimationStream&,UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_GetRotationInternal_Injected_m4863F14E289B9627C1ACADB750B56CD81ED6F857 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974* ___2_ret, const RuntimeMethod* method) 
{
	typedef void (*TransformStreamHandle_GetRotationInternal_Injected_m4863F14E289B9627C1ACADB750B56CD81ED6F857_ftn) (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A*, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974*);
	static TransformStreamHandle_GetRotationInternal_Injected_m4863F14E289B9627C1ACADB750B56CD81ED6F857_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (TransformStreamHandle_GetRotationInternal_Injected_m4863F14E289B9627C1ACADB750B56CD81ED6F857_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.TransformStreamHandle::GetRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle&,UnityEngine.Animations.AnimationStream&,UnityEngine.Quaternion&)");
	_il2cpp_icall_func(___0__unity_self, ___1_stream, ___2_ret);
}
// System.Void UnityEngine.Animations.TransformStreamHandle::SetRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle&,UnityEngine.Animations.AnimationStream&,UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_SetRotationInternal_Injected_m181A24DB2A658E488E3F0BC684A424547A6A7683 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974* ___2_rotation, const RuntimeMethod* method) 
{
	typedef void (*TransformStreamHandle_SetRotationInternal_Injected_m181A24DB2A658E488E3F0BC684A424547A6A7683_ftn) (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A*, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974*);
	static TransformStreamHandle_SetRotationInternal_Injected_m181A24DB2A658E488E3F0BC684A424547A6A7683_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (TransformStreamHandle_SetRotationInternal_Injected_m181A24DB2A658E488E3F0BC684A424547A6A7683_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.TransformStreamHandle::SetRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle&,UnityEngine.Animations.AnimationStream&,UnityEngine.Quaternion&)");
	_il2cpp_icall_func(___0__unity_self, ___1_stream, ___2_rotation);
}
// System.Void UnityEngine.Animations.TransformStreamHandle::SetLocalRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle&,UnityEngine.Animations.AnimationStream&,UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformStreamHandle_SetLocalRotationInternal_Injected_m58D671FC665AF45BE7B6753A65C3F27BDCD89EA3 (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974* ___2_rotation, const RuntimeMethod* method) 
{
	typedef void (*TransformStreamHandle_SetLocalRotationInternal_Injected_m58D671FC665AF45BE7B6753A65C3F27BDCD89EA3_ftn) (TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A*, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974*);
	static TransformStreamHandle_SetLocalRotationInternal_Injected_m58D671FC665AF45BE7B6753A65C3F27BDCD89EA3_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (TransformStreamHandle_SetLocalRotationInternal_Injected_m58D671FC665AF45BE7B6753A65C3F27BDCD89EA3_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.TransformStreamHandle::SetLocalRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle&,UnityEngine.Animations.AnimationStream&,UnityEngine.Quaternion&)");
	_il2cpp_icall_func(___0__unity_self, ___1_stream, ___2_rotation);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Boolean UnityEngine.Animations.PropertyStreamHandle::IsValidInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PropertyStreamHandle_IsValidInternal_mFE619567B465984FC8E00F07CC24D489802BB51B (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) 
{
	bool V_0 = false;
	int32_t G_B5_0 = 0;
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_0 = ___0_stream;
		bool L_1;
		L_1 = AnimationStream_get_isValid_mE1F032BDA653D5A903DCD427F4677A6C9C4C227A(L_0, NULL);
		if (!L_1)
		{
			goto IL_0021;
		}
	}
	{
		bool L_2;
		L_2 = PropertyStreamHandle_get_createdByNative_m2610F75D942E639F8D9919D9A8A8E2210503292A(__this, NULL);
		if (!L_2)
		{
			goto IL_0021;
		}
	}
	{
		bool L_3;
		L_3 = PropertyStreamHandle_get_hasHandleIndex_m296B641953CA1478332DE8D4E3616EDDE67F4415(__this, NULL);
		if (!L_3)
		{
			goto IL_0021;
		}
	}
	{
		bool L_4;
		L_4 = PropertyStreamHandle_get_hasBindType_mF482FD67DC2BBB8AF20A959C846430577FCC51B3(__this, NULL);
		G_B5_0 = ((int32_t)(L_4));
		goto IL_0022;
	}

IL_0021:
	{
		G_B5_0 = 0;
	}

IL_0022:
	{
		V_0 = (bool)G_B5_0;
		goto IL_0025;
	}

IL_0025:
	{
		bool L_5 = V_0;
		return L_5;
	}
}
IL2CPP_EXTERN_C  bool PropertyStreamHandle_IsValidInternal_mFE619567B465984FC8E00F07CC24D489802BB51B_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method)
{
	PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3*>(__this + _offset);
	bool _returnValue;
	_returnValue = PropertyStreamHandle_IsValidInternal_mFE619567B465984FC8E00F07CC24D489802BB51B(_thisAdjusted, ___0_stream, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.PropertyStreamHandle::get_createdByNative()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PropertyStreamHandle_get_createdByNative_m2610F75D942E639F8D9919D9A8A8E2210503292A (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		uint32_t L_0;
		L_0 = PropertyStreamHandle_get_animatorBindingsVersion_mAF352761E16C2BC5658A2B37C77EFC88173EA4C0(__this, NULL);
		V_0 = (bool)((!(((uint32_t)L_0) <= ((uint32_t)0)))? 1 : 0);
		goto IL_000d;
	}

IL_000d:
	{
		bool L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  bool PropertyStreamHandle_get_createdByNative_m2610F75D942E639F8D9919D9A8A8E2210503292A_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3*>(__this + _offset);
	bool _returnValue;
	_returnValue = PropertyStreamHandle_get_createdByNative_m2610F75D942E639F8D9919D9A8A8E2210503292A(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.PropertyStreamHandle::IsSameVersionAsStream(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PropertyStreamHandle_IsSameVersionAsStream_m105BA0425054D86214E70C3D0746517A0BBD5305 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		uint32_t L_0;
		L_0 = PropertyStreamHandle_get_animatorBindingsVersion_mAF352761E16C2BC5658A2B37C77EFC88173EA4C0(__this, NULL);
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_1 = ___0_stream;
		uint32_t L_2;
		L_2 = AnimationStream_get_animatorBindingsVersion_mD7D19DCE96F93CE4DC36457F974C5B8562A3B5E4(L_1, NULL);
		V_0 = (bool)((((int32_t)L_0) == ((int32_t)L_2))? 1 : 0);
		goto IL_0012;
	}

IL_0012:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool PropertyStreamHandle_IsSameVersionAsStream_m105BA0425054D86214E70C3D0746517A0BBD5305_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method)
{
	PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3*>(__this + _offset);
	bool _returnValue;
	_returnValue = PropertyStreamHandle_IsSameVersionAsStream_m105BA0425054D86214E70C3D0746517A0BBD5305(_thisAdjusted, ___0_stream, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.PropertyStreamHandle::get_hasHandleIndex()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PropertyStreamHandle_get_hasHandleIndex_m296B641953CA1478332DE8D4E3616EDDE67F4415 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		int32_t L_0 = __this->___handleIndex_1;
		V_0 = (bool)((((int32_t)((((int32_t)L_0) == ((int32_t)(-1)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_0010;
	}

IL_0010:
	{
		bool L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  bool PropertyStreamHandle_get_hasHandleIndex_m296B641953CA1478332DE8D4E3616EDDE67F4415_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3*>(__this + _offset);
	bool _returnValue;
	_returnValue = PropertyStreamHandle_get_hasHandleIndex_m296B641953CA1478332DE8D4E3616EDDE67F4415(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.PropertyStreamHandle::get_hasValueArrayIndex()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PropertyStreamHandle_get_hasValueArrayIndex_m6BFF272278DB968E4732EE7BAA990F18258DC610 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		int32_t L_0 = __this->___valueArrayIndex_2;
		V_0 = (bool)((((int32_t)((((int32_t)L_0) == ((int32_t)(-1)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_0010;
	}

IL_0010:
	{
		bool L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  bool PropertyStreamHandle_get_hasValueArrayIndex_m6BFF272278DB968E4732EE7BAA990F18258DC610_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3*>(__this + _offset);
	bool _returnValue;
	_returnValue = PropertyStreamHandle_get_hasValueArrayIndex_m6BFF272278DB968E4732EE7BAA990F18258DC610(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.PropertyStreamHandle::get_hasBindType()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PropertyStreamHandle_get_hasBindType_mF482FD67DC2BBB8AF20A959C846430577FCC51B3 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		int32_t L_0 = __this->___bindType_3;
		V_0 = (bool)((!(((uint32_t)L_0) <= ((uint32_t)0)))? 1 : 0);
		goto IL_000d;
	}

IL_000d:
	{
		bool L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  bool PropertyStreamHandle_get_hasBindType_mF482FD67DC2BBB8AF20A959C846430577FCC51B3_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3*>(__this + _offset);
	bool _returnValue;
	_returnValue = PropertyStreamHandle_get_hasBindType_mF482FD67DC2BBB8AF20A959C846430577FCC51B3(_thisAdjusted, method);
	return _returnValue;
}
// System.UInt32 UnityEngine.Animations.PropertyStreamHandle::get_animatorBindingsVersion()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t PropertyStreamHandle_get_animatorBindingsVersion_mAF352761E16C2BC5658A2B37C77EFC88173EA4C0 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, const RuntimeMethod* method) 
{
	uint32_t V_0 = 0;
	{
		uint32_t L_0 = __this->___m_AnimatorBindingsVersion_0;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		uint32_t L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  uint32_t PropertyStreamHandle_get_animatorBindingsVersion_mAF352761E16C2BC5658A2B37C77EFC88173EA4C0_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3*>(__this + _offset);
	uint32_t _returnValue;
	_returnValue = PropertyStreamHandle_get_animatorBindingsVersion_mAF352761E16C2BC5658A2B37C77EFC88173EA4C0(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.PropertyStreamHandle::IsResolvedInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PropertyStreamHandle_IsResolvedInternal_m7B96232330AB117B2050D16FE135103D6ED97DFA (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) 
{
	bool V_0 = false;
	int32_t G_B4_0 = 0;
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_0 = ___0_stream;
		bool L_1;
		L_1 = PropertyStreamHandle_IsValidInternal_mFE619567B465984FC8E00F07CC24D489802BB51B(__this, L_0, NULL);
		if (!L_1)
		{
			goto IL_001b;
		}
	}
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_2 = ___0_stream;
		bool L_3;
		L_3 = PropertyStreamHandle_IsSameVersionAsStream_m105BA0425054D86214E70C3D0746517A0BBD5305(__this, L_2, NULL);
		if (!L_3)
		{
			goto IL_001b;
		}
	}
	{
		bool L_4;
		L_4 = PropertyStreamHandle_get_hasValueArrayIndex_m6BFF272278DB968E4732EE7BAA990F18258DC610(__this, NULL);
		G_B4_0 = ((int32_t)(L_4));
		goto IL_001c;
	}

IL_001b:
	{
		G_B4_0 = 0;
	}

IL_001c:
	{
		V_0 = (bool)G_B4_0;
		goto IL_001f;
	}

IL_001f:
	{
		bool L_5 = V_0;
		return L_5;
	}
}
IL2CPP_EXTERN_C  bool PropertyStreamHandle_IsResolvedInternal_m7B96232330AB117B2050D16FE135103D6ED97DFA_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method)
{
	PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3*>(__this + _offset);
	bool _returnValue;
	_returnValue = PropertyStreamHandle_IsResolvedInternal_m7B96232330AB117B2050D16FE135103D6ED97DFA(_thisAdjusted, ___0_stream, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.PropertyStreamHandle::CheckIsValidAndResolve(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PropertyStreamHandle_CheckIsValidAndResolve_mD4036D6F0444B68BC4C1AECDD7429FEBAF03203C (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) 
{
	bool V_0 = false;
	bool V_1 = false;
	bool V_2 = false;
	bool V_3 = false;
	int32_t G_B6_0 = 0;
	int32_t G_B12_0 = 0;
	int32_t G_B14_0 = 0;
	int32_t G_B19_0 = 0;
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_0 = ___0_stream;
		AnimationStream_CheckIsValid_m6C46800E1A5A4BE27FF761A93F72BC3CD751174C(L_0, NULL);
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_1 = ___0_stream;
		bool L_2;
		L_2 = PropertyStreamHandle_IsResolvedInternal_m7B96232330AB117B2050D16FE135103D6ED97DFA(__this, L_1, NULL);
		V_0 = L_2;
		bool L_3 = V_0;
		if (!L_3)
		{
			goto IL_0015;
		}
	}
	{
		goto IL_0091;
	}

IL_0015:
	{
		bool L_4;
		L_4 = PropertyStreamHandle_get_createdByNative_m2610F75D942E639F8D9919D9A8A8E2210503292A(__this, NULL);
		if (!L_4)
		{
			goto IL_0030;
		}
	}
	{
		bool L_5;
		L_5 = PropertyStreamHandle_get_hasHandleIndex_m296B641953CA1478332DE8D4E3616EDDE67F4415(__this, NULL);
		if (!L_5)
		{
			goto IL_0030;
		}
	}
	{
		bool L_6;
		L_6 = PropertyStreamHandle_get_hasBindType_mF482FD67DC2BBB8AF20A959C846430577FCC51B3(__this, NULL);
		G_B6_0 = ((((int32_t)L_6) == ((int32_t)0))? 1 : 0);
		goto IL_0031;
	}

IL_0030:
	{
		G_B6_0 = 1;
	}

IL_0031:
	{
		V_1 = (bool)G_B6_0;
		bool L_7 = V_1;
		if (!L_7)
		{
			goto IL_0040;
		}
	}
	{
		InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB* L_8 = (InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB_il2cpp_TypeInfo_var)));
		NullCheck(L_8);
		InvalidOperationException__ctor_mE4CB6F4712AB6D99A2358FBAE2E052B3EE976162(L_8, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral6A5239659C252C3C95FC09A31CA37CA6F6B07FAE)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_8, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&PropertyStreamHandle_CheckIsValidAndResolve_mD4036D6F0444B68BC4C1AECDD7429FEBAF03203C_RuntimeMethod_var)));
	}

IL_0040:
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_9 = ___0_stream;
		bool L_10;
		L_10 = PropertyStreamHandle_IsSameVersionAsStream_m105BA0425054D86214E70C3D0746517A0BBD5305(__this, L_9, NULL);
		if (!L_10)
		{
			goto IL_005f;
		}
	}
	{
		bool L_11;
		L_11 = PropertyStreamHandle_get_hasHandleIndex_m296B641953CA1478332DE8D4E3616EDDE67F4415(__this, NULL);
		if (!L_11)
		{
			goto IL_005c;
		}
	}
	{
		bool L_12;
		L_12 = PropertyStreamHandle_get_hasValueArrayIndex_m6BFF272278DB968E4732EE7BAA990F18258DC610(__this, NULL);
		G_B12_0 = ((((int32_t)L_12) == ((int32_t)0))? 1 : 0);
		goto IL_005d;
	}

IL_005c:
	{
		G_B12_0 = 0;
	}

IL_005d:
	{
		G_B14_0 = G_B12_0;
		goto IL_0060;
	}

IL_005f:
	{
		G_B14_0 = 1;
	}

IL_0060:
	{
		V_2 = (bool)G_B14_0;
		bool L_13 = V_2;
		if (!L_13)
		{
			goto IL_006e;
		}
	}
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_14 = ___0_stream;
		PropertyStreamHandle_ResolveInternal_mFB0A48675D8D847197CB392325CDCA837B82E64C(__this, L_14, NULL);
	}

IL_006e:
	{
		bool L_15;
		L_15 = PropertyStreamHandle_get_hasHandleIndex_m296B641953CA1478332DE8D4E3616EDDE67F4415(__this, NULL);
		if (!L_15)
		{
			goto IL_0081;
		}
	}
	{
		bool L_16;
		L_16 = PropertyStreamHandle_get_hasValueArrayIndex_m6BFF272278DB968E4732EE7BAA990F18258DC610(__this, NULL);
		G_B19_0 = ((((int32_t)L_16) == ((int32_t)0))? 1 : 0);
		goto IL_0082;
	}

IL_0081:
	{
		G_B19_0 = 0;
	}

IL_0082:
	{
		V_3 = (bool)G_B19_0;
		bool L_17 = V_3;
		if (!L_17)
		{
			goto IL_0091;
		}
	}
	{
		InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB* L_18 = (InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB_il2cpp_TypeInfo_var)));
		NullCheck(L_18);
		InvalidOperationException__ctor_mE4CB6F4712AB6D99A2358FBAE2E052B3EE976162(L_18, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral10F6FECF95C1235E3B90F738314A338A55A4DF3B)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_18, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&PropertyStreamHandle_CheckIsValidAndResolve_mD4036D6F0444B68BC4C1AECDD7429FEBAF03203C_RuntimeMethod_var)));
	}

IL_0091:
	{
		return;
	}
}
IL2CPP_EXTERN_C  void PropertyStreamHandle_CheckIsValidAndResolve_mD4036D6F0444B68BC4C1AECDD7429FEBAF03203C_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method)
{
	PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3*>(__this + _offset);
	PropertyStreamHandle_CheckIsValidAndResolve_mD4036D6F0444B68BC4C1AECDD7429FEBAF03203C(_thisAdjusted, ___0_stream, method);
}
// System.Single UnityEngine.Animations.PropertyStreamHandle::GetFloat(UnityEngine.Animations.AnimationStream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float PropertyStreamHandle_GetFloat_mAEC50079467900B74F7B485BBAF65A4DE1BBB8DF (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, const RuntimeMethod* method) 
{
	bool V_0 = false;
	float V_1 = 0.0f;
	{
		PropertyStreamHandle_CheckIsValidAndResolve_mD4036D6F0444B68BC4C1AECDD7429FEBAF03203C(__this, (&___0_stream), NULL);
		int32_t L_0 = __this->___bindType_3;
		V_0 = (bool)((((int32_t)((((int32_t)L_0) == ((int32_t)5))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0025;
		}
	}
	{
		InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB* L_2 = (InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB_il2cpp_TypeInfo_var)));
		NullCheck(L_2);
		InvalidOperationException__ctor_mE4CB6F4712AB6D99A2358FBAE2E052B3EE976162(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral9FD6FF0BE087CD9281920D7CEAF428070CEF0D13)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&PropertyStreamHandle_GetFloat_mAEC50079467900B74F7B485BBAF65A4DE1BBB8DF_RuntimeMethod_var)));
	}

IL_0025:
	{
		float L_3;
		L_3 = PropertyStreamHandle_GetFloatInternal_m11E03DE3C420D8F9BFA7926D1F452766BD34B783(__this, (&___0_stream), NULL);
		V_1 = L_3;
		goto IL_0030;
	}

IL_0030:
	{
		float L_4 = V_1;
		return L_4;
	}
}
IL2CPP_EXTERN_C  float PropertyStreamHandle_GetFloat_mAEC50079467900B74F7B485BBAF65A4DE1BBB8DF_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, const RuntimeMethod* method)
{
	PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3*>(__this + _offset);
	float _returnValue;
	_returnValue = PropertyStreamHandle_GetFloat_mAEC50079467900B74F7B485BBAF65A4DE1BBB8DF(_thisAdjusted, ___0_stream, method);
	return _returnValue;
}
// System.Int32 UnityEngine.Animations.PropertyStreamHandle::GetInt(UnityEngine.Animations.AnimationStream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t PropertyStreamHandle_GetInt_m58CECCE1A73DB1EA96E287B5B7BF51BF502D8D98 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, const RuntimeMethod* method) 
{
	bool V_0 = false;
	int32_t V_1 = 0;
	int32_t G_B4_0 = 0;
	{
		PropertyStreamHandle_CheckIsValidAndResolve_mD4036D6F0444B68BC4C1AECDD7429FEBAF03203C(__this, (&___0_stream), NULL);
		int32_t L_0 = __this->___bindType_3;
		if ((((int32_t)L_0) == ((int32_t)((int32_t)10))))
		{
			goto IL_002d;
		}
	}
	{
		int32_t L_1 = __this->___bindType_3;
		if ((((int32_t)L_1) == ((int32_t)((int32_t)11))))
		{
			goto IL_002d;
		}
	}
	{
		int32_t L_2 = __this->___bindType_3;
		G_B4_0 = ((((int32_t)((((int32_t)L_2) == ((int32_t)((int32_t)9)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_002e;
	}

IL_002d:
	{
		G_B4_0 = 0;
	}

IL_002e:
	{
		V_0 = (bool)G_B4_0;
		bool L_3 = V_0;
		if (!L_3)
		{
			goto IL_003d;
		}
	}
	{
		InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB* L_4 = (InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB_il2cpp_TypeInfo_var)));
		NullCheck(L_4);
		InvalidOperationException__ctor_mE4CB6F4712AB6D99A2358FBAE2E052B3EE976162(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral9FD6FF0BE087CD9281920D7CEAF428070CEF0D13)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&PropertyStreamHandle_GetInt_m58CECCE1A73DB1EA96E287B5B7BF51BF502D8D98_RuntimeMethod_var)));
	}

IL_003d:
	{
		int32_t L_5;
		L_5 = PropertyStreamHandle_GetIntInternal_m598EC48F1700FB43EF1A5880178BB841A781D4C9(__this, (&___0_stream), NULL);
		V_1 = L_5;
		goto IL_0048;
	}

IL_0048:
	{
		int32_t L_6 = V_1;
		return L_6;
	}
}
IL2CPP_EXTERN_C  int32_t PropertyStreamHandle_GetInt_m58CECCE1A73DB1EA96E287B5B7BF51BF502D8D98_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, const RuntimeMethod* method)
{
	PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = PropertyStreamHandle_GetInt_m58CECCE1A73DB1EA96E287B5B7BF51BF502D8D98(_thisAdjusted, ___0_stream, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.PropertyStreamHandle::GetBool(UnityEngine.Animations.AnimationStream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PropertyStreamHandle_GetBool_mBB5B008988E6CC47C526CF654E53804909C141E0 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, const RuntimeMethod* method) 
{
	bool V_0 = false;
	bool V_1 = false;
	int32_t G_B3_0 = 0;
	{
		PropertyStreamHandle_CheckIsValidAndResolve_mD4036D6F0444B68BC4C1AECDD7429FEBAF03203C(__this, (&___0_stream), NULL);
		int32_t L_0 = __this->___bindType_3;
		if ((((int32_t)L_0) == ((int32_t)6)))
		{
			goto IL_0021;
		}
	}
	{
		int32_t L_1 = __this->___bindType_3;
		G_B3_0 = ((((int32_t)((((int32_t)L_1) == ((int32_t)7))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_0022;
	}

IL_0021:
	{
		G_B3_0 = 0;
	}

IL_0022:
	{
		V_0 = (bool)G_B3_0;
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_0031;
		}
	}
	{
		InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB* L_3 = (InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB_il2cpp_TypeInfo_var)));
		NullCheck(L_3);
		InvalidOperationException__ctor_mE4CB6F4712AB6D99A2358FBAE2E052B3EE976162(L_3, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral9FD6FF0BE087CD9281920D7CEAF428070CEF0D13)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_3, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&PropertyStreamHandle_GetBool_mBB5B008988E6CC47C526CF654E53804909C141E0_RuntimeMethod_var)));
	}

IL_0031:
	{
		bool L_4;
		L_4 = PropertyStreamHandle_GetBoolInternal_m25D06AA6F53B3265E80243E589F39EF4C30E7DAD(__this, (&___0_stream), NULL);
		V_1 = L_4;
		goto IL_003c;
	}

IL_003c:
	{
		bool L_5 = V_1;
		return L_5;
	}
}
IL2CPP_EXTERN_C  bool PropertyStreamHandle_GetBool_mBB5B008988E6CC47C526CF654E53804909C141E0_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, const RuntimeMethod* method)
{
	PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3*>(__this + _offset);
	bool _returnValue;
	_returnValue = PropertyStreamHandle_GetBool_mBB5B008988E6CC47C526CF654E53804909C141E0(_thisAdjusted, ___0_stream, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.PropertyStreamHandle::ResolveInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PropertyStreamHandle_ResolveInternal_mFB0A48675D8D847197CB392325CDCA837B82E64C (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) 
{
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_0 = ___0_stream;
		PropertyStreamHandle_ResolveInternal_Injected_m2F38D58EFF0643C85F7ABA035DAC718D5A885B0F(__this, L_0, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void PropertyStreamHandle_ResolveInternal_mFB0A48675D8D847197CB392325CDCA837B82E64C_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method)
{
	PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3*>(__this + _offset);
	PropertyStreamHandle_ResolveInternal_mFB0A48675D8D847197CB392325CDCA837B82E64C(_thisAdjusted, ___0_stream, method);
}
// System.Single UnityEngine.Animations.PropertyStreamHandle::GetFloatInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float PropertyStreamHandle_GetFloatInternal_m11E03DE3C420D8F9BFA7926D1F452766BD34B783 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) 
{
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_0 = ___0_stream;
		float L_1;
		L_1 = PropertyStreamHandle_GetFloatInternal_Injected_m6604EAC314F4B69CAC8601BE540A723ADCC8734E(__this, L_0, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C  float PropertyStreamHandle_GetFloatInternal_m11E03DE3C420D8F9BFA7926D1F452766BD34B783_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method)
{
	PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3*>(__this + _offset);
	float _returnValue;
	_returnValue = PropertyStreamHandle_GetFloatInternal_m11E03DE3C420D8F9BFA7926D1F452766BD34B783(_thisAdjusted, ___0_stream, method);
	return _returnValue;
}
// System.Int32 UnityEngine.Animations.PropertyStreamHandle::GetIntInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t PropertyStreamHandle_GetIntInternal_m598EC48F1700FB43EF1A5880178BB841A781D4C9 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) 
{
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_0 = ___0_stream;
		int32_t L_1;
		L_1 = PropertyStreamHandle_GetIntInternal_Injected_mDFDACC53C8FAA687E154D78C9A86B58EA836AF14(__this, L_0, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C  int32_t PropertyStreamHandle_GetIntInternal_m598EC48F1700FB43EF1A5880178BB841A781D4C9_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method)
{
	PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = PropertyStreamHandle_GetIntInternal_m598EC48F1700FB43EF1A5880178BB841A781D4C9(_thisAdjusted, ___0_stream, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.PropertyStreamHandle::GetBoolInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PropertyStreamHandle_GetBoolInternal_m25D06AA6F53B3265E80243E589F39EF4C30E7DAD (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) 
{
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_0 = ___0_stream;
		bool L_1;
		L_1 = PropertyStreamHandle_GetBoolInternal_Injected_mDE6D207C4962AC0FC356962421418A632D7120D6(__this, L_0, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C  bool PropertyStreamHandle_GetBoolInternal_m25D06AA6F53B3265E80243E589F39EF4C30E7DAD_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method)
{
	PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3*>(__this + _offset);
	bool _returnValue;
	_returnValue = PropertyStreamHandle_GetBoolInternal_m25D06AA6F53B3265E80243E589F39EF4C30E7DAD(_thisAdjusted, ___0_stream, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.PropertyStreamHandle::ResolveInternal_Injected(UnityEngine.Animations.PropertyStreamHandle&,UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PropertyStreamHandle_ResolveInternal_Injected_m2F38D58EFF0643C85F7ABA035DAC718D5A885B0F (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, const RuntimeMethod* method) 
{
	typedef void (*PropertyStreamHandle_ResolveInternal_Injected_m2F38D58EFF0643C85F7ABA035DAC718D5A885B0F_ftn) (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3*, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A*);
	static PropertyStreamHandle_ResolveInternal_Injected_m2F38D58EFF0643C85F7ABA035DAC718D5A885B0F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (PropertyStreamHandle_ResolveInternal_Injected_m2F38D58EFF0643C85F7ABA035DAC718D5A885B0F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.PropertyStreamHandle::ResolveInternal_Injected(UnityEngine.Animations.PropertyStreamHandle&,UnityEngine.Animations.AnimationStream&)");
	_il2cpp_icall_func(___0__unity_self, ___1_stream);
}
// System.Single UnityEngine.Animations.PropertyStreamHandle::GetFloatInternal_Injected(UnityEngine.Animations.PropertyStreamHandle&,UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float PropertyStreamHandle_GetFloatInternal_Injected_m6604EAC314F4B69CAC8601BE540A723ADCC8734E (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, const RuntimeMethod* method) 
{
	typedef float (*PropertyStreamHandle_GetFloatInternal_Injected_m6604EAC314F4B69CAC8601BE540A723ADCC8734E_ftn) (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3*, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A*);
	static PropertyStreamHandle_GetFloatInternal_Injected_m6604EAC314F4B69CAC8601BE540A723ADCC8734E_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (PropertyStreamHandle_GetFloatInternal_Injected_m6604EAC314F4B69CAC8601BE540A723ADCC8734E_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.PropertyStreamHandle::GetFloatInternal_Injected(UnityEngine.Animations.PropertyStreamHandle&,UnityEngine.Animations.AnimationStream&)");
	float icallRetVal = _il2cpp_icall_func(___0__unity_self, ___1_stream);
	return icallRetVal;
}
// System.Int32 UnityEngine.Animations.PropertyStreamHandle::GetIntInternal_Injected(UnityEngine.Animations.PropertyStreamHandle&,UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t PropertyStreamHandle_GetIntInternal_Injected_mDFDACC53C8FAA687E154D78C9A86B58EA836AF14 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, const RuntimeMethod* method) 
{
	typedef int32_t (*PropertyStreamHandle_GetIntInternal_Injected_mDFDACC53C8FAA687E154D78C9A86B58EA836AF14_ftn) (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3*, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A*);
	static PropertyStreamHandle_GetIntInternal_Injected_mDFDACC53C8FAA687E154D78C9A86B58EA836AF14_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (PropertyStreamHandle_GetIntInternal_Injected_mDFDACC53C8FAA687E154D78C9A86B58EA836AF14_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.PropertyStreamHandle::GetIntInternal_Injected(UnityEngine.Animations.PropertyStreamHandle&,UnityEngine.Animations.AnimationStream&)");
	int32_t icallRetVal = _il2cpp_icall_func(___0__unity_self, ___1_stream);
	return icallRetVal;
}
// System.Boolean UnityEngine.Animations.PropertyStreamHandle::GetBoolInternal_Injected(UnityEngine.Animations.PropertyStreamHandle&,UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PropertyStreamHandle_GetBoolInternal_Injected_mDE6D207C4962AC0FC356962421418A632D7120D6 (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, const RuntimeMethod* method) 
{
	typedef bool (*PropertyStreamHandle_GetBoolInternal_Injected_mDE6D207C4962AC0FC356962421418A632D7120D6_ftn) (PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3*, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A*);
	static PropertyStreamHandle_GetBoolInternal_Injected_mDE6D207C4962AC0FC356962421418A632D7120D6_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (PropertyStreamHandle_GetBoolInternal_Injected_mDE6D207C4962AC0FC356962421418A632D7120D6_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.PropertyStreamHandle::GetBoolInternal_Injected(UnityEngine.Animations.PropertyStreamHandle&,UnityEngine.Animations.AnimationStream&)");
	bool icallRetVal = _il2cpp_icall_func(___0__unity_self, ___1_stream);
	return icallRetVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Boolean UnityEngine.Animations.TransformSceneHandle::get_createdByNative()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransformSceneHandle_get_createdByNative_m40C489AAD66DEDFEB69F6BB25B1177FC51922D3D (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* __this, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		uint32_t L_0 = __this->___valid_0;
		V_0 = (bool)((!(((uint32_t)L_0) <= ((uint32_t)0)))? 1 : 0);
		goto IL_000d;
	}

IL_000d:
	{
		bool L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  bool TransformSceneHandle_get_createdByNative_m40C489AAD66DEDFEB69F6BB25B1177FC51922D3D_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB*>(__this + _offset);
	bool _returnValue;
	_returnValue = TransformSceneHandle_get_createdByNative_m40C489AAD66DEDFEB69F6BB25B1177FC51922D3D(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.TransformSceneHandle::get_hasTransformSceneHandleDefinitionIndex()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransformSceneHandle_get_hasTransformSceneHandleDefinitionIndex_mBD4B49152989D4379E6D726B0F7E834EA484383B (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* __this, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		int32_t L_0 = __this->___transformSceneHandleDefinitionIndex_1;
		V_0 = (bool)((((int32_t)((((int32_t)L_0) == ((int32_t)(-1)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_0010;
	}

IL_0010:
	{
		bool L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  bool TransformSceneHandle_get_hasTransformSceneHandleDefinitionIndex_mBD4B49152989D4379E6D726B0F7E834EA484383B_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB*>(__this + _offset);
	bool _returnValue;
	_returnValue = TransformSceneHandle_get_hasTransformSceneHandleDefinitionIndex_mBD4B49152989D4379E6D726B0F7E834EA484383B(_thisAdjusted, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.TransformSceneHandle::CheckIsValid(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformSceneHandle_CheckIsValid_m33214B5950C49A143A5548B7FB1672062204655A (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) 
{
	bool V_0 = false;
	bool V_1 = false;
	int32_t G_B3_0 = 0;
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_0 = ___0_stream;
		AnimationStream_CheckIsValid_m6C46800E1A5A4BE27FF761A93F72BC3CD751174C(L_0, NULL);
		bool L_1;
		L_1 = TransformSceneHandle_get_createdByNative_m40C489AAD66DEDFEB69F6BB25B1177FC51922D3D(__this, NULL);
		if (!L_1)
		{
			goto IL_001b;
		}
	}
	{
		bool L_2;
		L_2 = TransformSceneHandle_get_hasTransformSceneHandleDefinitionIndex_mBD4B49152989D4379E6D726B0F7E834EA484383B(__this, NULL);
		G_B3_0 = ((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		goto IL_001c;
	}

IL_001b:
	{
		G_B3_0 = 1;
	}

IL_001c:
	{
		V_0 = (bool)G_B3_0;
		bool L_3 = V_0;
		if (!L_3)
		{
			goto IL_002b;
		}
	}
	{
		InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB* L_4 = (InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB_il2cpp_TypeInfo_var)));
		NullCheck(L_4);
		InvalidOperationException__ctor_mE4CB6F4712AB6D99A2358FBAE2E052B3EE976162(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral972CE48A8E26750559B1B00039204D0DE5B03904)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&TransformSceneHandle_CheckIsValid_m33214B5950C49A143A5548B7FB1672062204655A_RuntimeMethod_var)));
	}

IL_002b:
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_5 = ___0_stream;
		bool L_6;
		L_6 = TransformSceneHandle_HasValidTransform_m19ABA61E5902DA7F1207798BBB4DCFBE515B9537(__this, L_5, NULL);
		V_1 = (bool)((((int32_t)L_6) == ((int32_t)0))? 1 : 0);
		bool L_7 = V_1;
		if (!L_7)
		{
			goto IL_0044;
		}
	}
	{
		NullReferenceException_tBDE63A6D24569B964908408389070C6A9F5005BB* L_8 = (NullReferenceException_tBDE63A6D24569B964908408389070C6A9F5005BB*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NullReferenceException_tBDE63A6D24569B964908408389070C6A9F5005BB_il2cpp_TypeInfo_var)));
		NullCheck(L_8);
		NullReferenceException__ctor_mA41317A57F5C1C0E3F59C7EB25ABD484564B23D4(L_8, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralD05EE9FE9EFEEB35F354D97C2927EEB880DA9264)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_8, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&TransformSceneHandle_CheckIsValid_m33214B5950C49A143A5548B7FB1672062204655A_RuntimeMethod_var)));
	}

IL_0044:
	{
		return;
	}
}
IL2CPP_EXTERN_C  void TransformSceneHandle_CheckIsValid_m33214B5950C49A143A5548B7FB1672062204655A_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method)
{
	TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB*>(__this + _offset);
	TransformSceneHandle_CheckIsValid_m33214B5950C49A143A5548B7FB1672062204655A(_thisAdjusted, ___0_stream, method);
}
// UnityEngine.Vector3 UnityEngine.Animations.TransformSceneHandle::GetPosition(UnityEngine.Animations.AnimationStream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 TransformSceneHandle_GetPosition_mDB8261C4AF79828292D555DBF91A6559DE41B3B8 (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		TransformSceneHandle_CheckIsValid_m33214B5950C49A143A5548B7FB1672062204655A(__this, (&___0_stream), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0;
		L_0 = TransformSceneHandle_GetPositionInternal_mAC29651E3EB5FC3BD4CB49B2B09EB9897375FC29(__this, (&___0_stream), NULL);
		V_0 = L_0;
		goto IL_0015;
	}

IL_0015:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 TransformSceneHandle_GetPosition_mDB8261C4AF79828292D555DBF91A6559DE41B3B8_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, const RuntimeMethod* method)
{
	TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB*>(__this + _offset);
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 _returnValue;
	_returnValue = TransformSceneHandle_GetPosition_mDB8261C4AF79828292D555DBF91A6559DE41B3B8(_thisAdjusted, ___0_stream, method);
	return _returnValue;
}
// UnityEngine.Quaternion UnityEngine.Animations.TransformSceneHandle::GetRotation(UnityEngine.Animations.AnimationStream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 TransformSceneHandle_GetRotation_m8F6CA3E2302A43103A808120AEE1C527EB2A2F05 (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, const RuntimeMethod* method) 
{
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		TransformSceneHandle_CheckIsValid_m33214B5950C49A143A5548B7FB1672062204655A(__this, (&___0_stream), NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_0;
		L_0 = TransformSceneHandle_GetRotationInternal_m53DDDEE9D5824A6E5BFEE5C5681A33E468E0FC5E(__this, (&___0_stream), NULL);
		V_0 = L_0;
		goto IL_0015;
	}

IL_0015:
	{
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 TransformSceneHandle_GetRotation_m8F6CA3E2302A43103A808120AEE1C527EB2A2F05_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A ___0_stream, const RuntimeMethod* method)
{
	TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB*>(__this + _offset);
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 _returnValue;
	_returnValue = TransformSceneHandle_GetRotation_m8F6CA3E2302A43103A808120AEE1C527EB2A2F05(_thisAdjusted, ___0_stream, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.TransformSceneHandle::HasValidTransform(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransformSceneHandle_HasValidTransform_m19ABA61E5902DA7F1207798BBB4DCFBE515B9537 (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) 
{
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_0 = ___0_stream;
		bool L_1;
		L_1 = TransformSceneHandle_HasValidTransform_Injected_m1F0CEB3799D44896F7F501AE0E99BF49938ADA4B(__this, L_0, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C  bool TransformSceneHandle_HasValidTransform_m19ABA61E5902DA7F1207798BBB4DCFBE515B9537_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method)
{
	TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB*>(__this + _offset);
	bool _returnValue;
	_returnValue = TransformSceneHandle_HasValidTransform_m19ABA61E5902DA7F1207798BBB4DCFBE515B9537(_thisAdjusted, ___0_stream, method);
	return _returnValue;
}
// UnityEngine.Vector3 UnityEngine.Animations.TransformSceneHandle::GetPositionInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 TransformSceneHandle_GetPositionInternal_mAC29651E3EB5FC3BD4CB49B2B09EB9897375FC29 (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_0 = ___0_stream;
		TransformSceneHandle_GetPositionInternal_Injected_m5CB0EBF73345BD9F90E504DCEFE1C2D4B349FAB0(__this, L_0, (&V_0), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 TransformSceneHandle_GetPositionInternal_mAC29651E3EB5FC3BD4CB49B2B09EB9897375FC29_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method)
{
	TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB*>(__this + _offset);
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 _returnValue;
	_returnValue = TransformSceneHandle_GetPositionInternal_mAC29651E3EB5FC3BD4CB49B2B09EB9897375FC29(_thisAdjusted, ___0_stream, method);
	return _returnValue;
}
// UnityEngine.Quaternion UnityEngine.Animations.TransformSceneHandle::GetRotationInternal(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 TransformSceneHandle_GetRotationInternal_m53DDDEE9D5824A6E5BFEE5C5681A33E468E0FC5E (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method) 
{
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* L_0 = ___0_stream;
		TransformSceneHandle_GetRotationInternal_Injected_m50FA487714327D6B98868DB6322D1F72260B8BBE(__this, L_0, (&V_0), NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 TransformSceneHandle_GetRotationInternal_m53DDDEE9D5824A6E5BFEE5C5681A33E468E0FC5E_AdjustorThunk (RuntimeObject* __this, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0_stream, const RuntimeMethod* method)
{
	TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB*>(__this + _offset);
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 _returnValue;
	_returnValue = TransformSceneHandle_GetRotationInternal_m53DDDEE9D5824A6E5BFEE5C5681A33E468E0FC5E(_thisAdjusted, ___0_stream, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.TransformSceneHandle::HasValidTransform_Injected(UnityEngine.Animations.TransformSceneHandle&,UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransformSceneHandle_HasValidTransform_Injected_m1F0CEB3799D44896F7F501AE0E99BF49938ADA4B (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, const RuntimeMethod* method) 
{
	typedef bool (*TransformSceneHandle_HasValidTransform_Injected_m1F0CEB3799D44896F7F501AE0E99BF49938ADA4B_ftn) (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB*, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A*);
	static TransformSceneHandle_HasValidTransform_Injected_m1F0CEB3799D44896F7F501AE0E99BF49938ADA4B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (TransformSceneHandle_HasValidTransform_Injected_m1F0CEB3799D44896F7F501AE0E99BF49938ADA4B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.TransformSceneHandle::HasValidTransform_Injected(UnityEngine.Animations.TransformSceneHandle&,UnityEngine.Animations.AnimationStream&)");
	bool icallRetVal = _il2cpp_icall_func(___0__unity_self, ___1_stream);
	return icallRetVal;
}
// System.Void UnityEngine.Animations.TransformSceneHandle::GetPositionInternal_Injected(UnityEngine.Animations.TransformSceneHandle&,UnityEngine.Animations.AnimationStream&,UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformSceneHandle_GetPositionInternal_Injected_m5CB0EBF73345BD9F90E504DCEFE1C2D4B349FAB0 (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___2_ret, const RuntimeMethod* method) 
{
	typedef void (*TransformSceneHandle_GetPositionInternal_Injected_m5CB0EBF73345BD9F90E504DCEFE1C2D4B349FAB0_ftn) (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB*, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*);
	static TransformSceneHandle_GetPositionInternal_Injected_m5CB0EBF73345BD9F90E504DCEFE1C2D4B349FAB0_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (TransformSceneHandle_GetPositionInternal_Injected_m5CB0EBF73345BD9F90E504DCEFE1C2D4B349FAB0_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.TransformSceneHandle::GetPositionInternal_Injected(UnityEngine.Animations.TransformSceneHandle&,UnityEngine.Animations.AnimationStream&,UnityEngine.Vector3&)");
	_il2cpp_icall_func(___0__unity_self, ___1_stream, ___2_ret);
}
// System.Void UnityEngine.Animations.TransformSceneHandle::GetRotationInternal_Injected(UnityEngine.Animations.TransformSceneHandle&,UnityEngine.Animations.AnimationStream&,UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransformSceneHandle_GetRotationInternal_Injected_m50FA487714327D6B98868DB6322D1F72260B8BBE (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* ___0__unity_self, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___1_stream, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974* ___2_ret, const RuntimeMethod* method) 
{
	typedef void (*TransformSceneHandle_GetRotationInternal_Injected_m50FA487714327D6B98868DB6322D1F72260B8BBE_ftn) (TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB*, AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A*, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974*);
	static TransformSceneHandle_GetRotationInternal_Injected_m50FA487714327D6B98868DB6322D1F72260B8BBE_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (TransformSceneHandle_GetRotationInternal_Injected_m50FA487714327D6B98868DB6322D1F72260B8BBE_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.TransformSceneHandle::GetRotationInternal_Injected(UnityEngine.Animations.TransformSceneHandle&,UnityEngine.Animations.AnimationStream&,UnityEngine.Quaternion&)");
	_il2cpp_icall_func(___0__unity_self, ___1_stream, ___2_ret);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Animations.TransformStreamHandle UnityEngine.Animations.AnimatorJobExtensions::BindStreamTransform(UnityEngine.Animator,UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E AnimatorJobExtensions_BindStreamTransform_m9E23872D781BC0754909267ED356266392F4E26D (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___1_transform, const RuntimeMethod* method) 
{
	TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E V_0;
	memset((&V_0), 0, sizeof(V_0));
	TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		il2cpp_codegen_initobj((&V_0), sizeof(TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E));
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_0 = ___0_animator;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_1 = ___1_transform;
		AnimatorJobExtensions_InternalBindStreamTransform_m83A49A8A13E2FA7AD67FAECA1B24F11D15550C2F(L_0, L_1, (&V_0), NULL);
		TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E L_2 = V_0;
		V_1 = L_2;
		goto IL_0017;
	}

IL_0017:
	{
		TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E L_3 = V_1;
		return L_3;
	}
}
// UnityEngine.Animations.PropertyStreamHandle UnityEngine.Animations.AnimatorJobExtensions::BindStreamProperty(UnityEngine.Animator,UnityEngine.Transform,System.Type,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3 AnimatorJobExtensions_BindStreamProperty_m199C36204F072AECF047AEFC92B1A62A61FF2F7F (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___1_transform, Type_t* ___2_type, String_t* ___3_property, const RuntimeMethod* method) 
{
	PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_0 = ___0_animator;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_1 = ___1_transform;
		Type_t* L_2 = ___2_type;
		String_t* L_3 = ___3_property;
		PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3 L_4;
		L_4 = AnimatorJobExtensions_BindStreamProperty_m02E8A9116C4DB619A2B4E28AEADC593ECDE78994(L_0, L_1, L_2, L_3, (bool)0, NULL);
		V_0 = L_4;
		goto IL_000e;
	}

IL_000e:
	{
		PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3 L_5 = V_0;
		return L_5;
	}
}
// UnityEngine.Animations.PropertyStreamHandle UnityEngine.Animations.AnimatorJobExtensions::BindStreamProperty(UnityEngine.Animator,UnityEngine.Transform,System.Type,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3 AnimatorJobExtensions_BindStreamProperty_m02E8A9116C4DB619A2B4E28AEADC593ECDE78994 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___1_transform, Type_t* ___2_type, String_t* ___3_property, bool ___4_isObjectReference, const RuntimeMethod* method) 
{
	PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3 V_0;
	memset((&V_0), 0, sizeof(V_0));
	PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3 V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		il2cpp_codegen_initobj((&V_0), sizeof(PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3));
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_0 = ___0_animator;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_1 = ___1_transform;
		Type_t* L_2 = ___2_type;
		String_t* L_3 = ___3_property;
		bool L_4 = ___4_isObjectReference;
		AnimatorJobExtensions_InternalBindStreamProperty_mE09521CB89443739B6428A0FD6B012D8C0601415(L_0, L_1, L_2, L_3, L_4, (&V_0), NULL);
		PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3 L_5 = V_0;
		V_1 = L_5;
		goto IL_001b;
	}

IL_001b:
	{
		PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3 L_6 = V_1;
		return L_6;
	}
}
// UnityEngine.Animations.TransformSceneHandle UnityEngine.Animations.AnimatorJobExtensions::BindSceneTransform(UnityEngine.Animator,UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB AnimatorJobExtensions_BindSceneTransform_m78A489DBF2ED9127F74F35C33CD9C712AC73DE76 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___1_transform, const RuntimeMethod* method) 
{
	TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB V_0;
	memset((&V_0), 0, sizeof(V_0));
	TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		il2cpp_codegen_initobj((&V_0), sizeof(TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB));
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_0 = ___0_animator;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_1 = ___1_transform;
		AnimatorJobExtensions_InternalBindSceneTransform_m5C33CC9DC1C95933DA91E42411080A4DA49216C6(L_0, L_1, (&V_0), NULL);
		TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB L_2 = V_0;
		V_1 = L_2;
		goto IL_0017;
	}

IL_0017:
	{
		TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB L_3 = V_1;
		return L_3;
	}
}
// System.Void UnityEngine.Animations.AnimatorJobExtensions::InternalBindStreamTransform(UnityEngine.Animator,UnityEngine.Transform,UnityEngine.Animations.TransformStreamHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorJobExtensions_InternalBindStreamTransform_m83A49A8A13E2FA7AD67FAECA1B24F11D15550C2F (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___1_transform, TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E* ___2_transformStreamHandle, const RuntimeMethod* method) 
{
	typedef void (*AnimatorJobExtensions_InternalBindStreamTransform_m83A49A8A13E2FA7AD67FAECA1B24F11D15550C2F_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1*, TransformStreamHandle_t4C1B88E471D0A729DAF29F631D14C3E9CE7A588E*);
	static AnimatorJobExtensions_InternalBindStreamTransform_m83A49A8A13E2FA7AD67FAECA1B24F11D15550C2F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorJobExtensions_InternalBindStreamTransform_m83A49A8A13E2FA7AD67FAECA1B24F11D15550C2F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorJobExtensions::InternalBindStreamTransform(UnityEngine.Animator,UnityEngine.Transform,UnityEngine.Animations.TransformStreamHandle&)");
	_il2cpp_icall_func(___0_animator, ___1_transform, ___2_transformStreamHandle);
}
// System.Void UnityEngine.Animations.AnimatorJobExtensions::InternalBindStreamProperty(UnityEngine.Animator,UnityEngine.Transform,System.Type,System.String,System.Boolean,UnityEngine.Animations.PropertyStreamHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorJobExtensions_InternalBindStreamProperty_mE09521CB89443739B6428A0FD6B012D8C0601415 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___1_transform, Type_t* ___2_type, String_t* ___3_property, bool ___4_isObjectReference, PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3* ___5_propertyStreamHandle, const RuntimeMethod* method) 
{
	typedef void (*AnimatorJobExtensions_InternalBindStreamProperty_mE09521CB89443739B6428A0FD6B012D8C0601415_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1*, Type_t*, String_t*, bool, PropertyStreamHandle_tA4F5D5D4C6A47069B2D84EDDD84B8A7F982DA1B3*);
	static AnimatorJobExtensions_InternalBindStreamProperty_mE09521CB89443739B6428A0FD6B012D8C0601415_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorJobExtensions_InternalBindStreamProperty_mE09521CB89443739B6428A0FD6B012D8C0601415_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorJobExtensions::InternalBindStreamProperty(UnityEngine.Animator,UnityEngine.Transform,System.Type,System.String,System.Boolean,UnityEngine.Animations.PropertyStreamHandle&)");
	_il2cpp_icall_func(___0_animator, ___1_transform, ___2_type, ___3_property, ___4_isObjectReference, ___5_propertyStreamHandle);
}
// System.Void UnityEngine.Animations.AnimatorJobExtensions::InternalBindSceneTransform(UnityEngine.Animator,UnityEngine.Transform,UnityEngine.Animations.TransformSceneHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorJobExtensions_InternalBindSceneTransform_m5C33CC9DC1C95933DA91E42411080A4DA49216C6 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_animator, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___1_transform, TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB* ___2_transformSceneHandle, const RuntimeMethod* method) 
{
	typedef void (*AnimatorJobExtensions_InternalBindSceneTransform_m5C33CC9DC1C95933DA91E42411080A4DA49216C6_ftn) (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1*, TransformSceneHandle_t4A2454F99C8DC8FFFBFA0C2B35A4AFD3067961EB*);
	static AnimatorJobExtensions_InternalBindSceneTransform_m5C33CC9DC1C95933DA91E42411080A4DA49216C6_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorJobExtensions_InternalBindSceneTransform_m5C33CC9DC1C95933DA91E42411080A4DA49216C6_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimatorJobExtensions::InternalBindSceneTransform(UnityEngine.Animator,UnityEngine.Transform,UnityEngine.Animations.TransformSceneHandle&)");
	_il2cpp_icall_func(___0_animator, ___1_transform, ___2_transformSceneHandle);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Animations.AnimationClipPlayable UnityEngine.Animations.AnimationClipPlayable::Create(UnityEngine.Playables.PlayableGraph,UnityEngine.AnimationClip)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 AnimationClipPlayable_Create_m034A4A30AC2642E675B95A0A7C3C384F533F5C1A (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* ___1_clip, const RuntimeMethod* method) 
{
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_0 = ___0_graph;
		AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* L_1 = ___1_clip;
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_2;
		L_2 = AnimationClipPlayable_CreateHandle_m9804DF3694EC65E8531F6839194AB189401AE564(L_0, L_1, NULL);
		V_0 = L_2;
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_3 = V_0;
		AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 L_4;
		memset((&L_4), 0, sizeof(L_4));
		AnimationClipPlayable__ctor_mF2EE31CC772B100F98CCAE26963059C6C722FA1A((&L_4), L_3, /*hidden argument*/NULL);
		V_1 = L_4;
		goto IL_0012;
	}

IL_0012:
	{
		AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 L_5 = V_1;
		return L_5;
	}
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationClipPlayable::CreateHandle(UnityEngine.Playables.PlayableGraph,UnityEngine.AnimationClip)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationClipPlayable_CreateHandle_m9804DF3694EC65E8531F6839194AB189401AE564 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* ___1_clip, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	bool V_1 = false;
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_2;
	memset((&V_2), 0, sizeof(V_2));
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		V_0 = L_0;
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_1 = ___0_graph;
		AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* L_2 = ___1_clip;
		bool L_3;
		L_3 = AnimationClipPlayable_CreateHandleInternal_mB8466F44A261B040DBCE8BA442DA8CF7153D2212(L_1, L_2, (&V_0), NULL);
		V_1 = (bool)((((int32_t)L_3) == ((int32_t)0))? 1 : 0);
		bool L_4 = V_1;
		if (!L_4)
		{
			goto IL_001f;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_5;
		L_5 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		V_2 = L_5;
		goto IL_0023;
	}

IL_001f:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_6 = V_0;
		V_2 = L_6;
		goto IL_0023;
	}

IL_0023:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_7 = V_2;
		return L_7;
	}
}
// System.Void UnityEngine.Animations.AnimationClipPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable__ctor_mF2EE31CC772B100F98CCAE26963059C6C722FA1A (AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_IsPlayableOfType_TisAnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969_m9AA33A8596A6C41CAA768B0A6EF59B75658A1FB8_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		bool L_0;
		L_0 = PlayableHandle_IsValid_m07631D12846BAAF2CC302E69A28A44BFE9EB5098((&___0_handle), NULL);
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0027;
		}
	}
	{
		bool L_2;
		L_2 = PlayableHandle_IsPlayableOfType_TisAnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969_m9AA33A8596A6C41CAA768B0A6EF59B75658A1FB8((&___0_handle), PlayableHandle_IsPlayableOfType_TisAnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969_m9AA33A8596A6C41CAA768B0A6EF59B75658A1FB8_RuntimeMethod_var);
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0026;
		}
	}
	{
		InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E* L_4 = (InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E_il2cpp_TypeInfo_var)));
		NullCheck(L_4);
		InvalidCastException__ctor_mED3F9781E6CA47A92C602C896EDDF2F40ECB8644(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralBD022D19E88CF1C2E702FF8813F493923F8AC574)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationClipPlayable__ctor_mF2EE31CC772B100F98CCAE26963059C6C722FA1A_RuntimeMethod_var)));
	}

IL_0026:
	{
	}

IL_0027:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_5 = ___0_handle;
		__this->___m_Handle_0 = L_5;
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationClipPlayable__ctor_mF2EE31CC772B100F98CCAE26963059C6C722FA1A_AdjustorThunk (RuntimeObject* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method)
{
	AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969*>(__this + _offset);
	AnimationClipPlayable__ctor_mF2EE31CC772B100F98CCAE26963059C6C722FA1A(_thisAdjusted, ___0_handle, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationClipPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationClipPlayable_GetHandle_mE775F2247901BA293DB01A8D384D3F9D02A25627 (AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* __this, const RuntimeMethod* method) 
{
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0 = __this->___m_Handle_0;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationClipPlayable_GetHandle_mE775F2247901BA293DB01A8D384D3F9D02A25627_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969*>(__this + _offset);
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 _returnValue;
	_returnValue = AnimationClipPlayable_GetHandle_mE775F2247901BA293DB01A8D384D3F9D02A25627(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.Playables.Playable UnityEngine.Animations.AnimationClipPlayable::op_Implicit(UnityEngine.Animations.AnimationClipPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F AnimationClipPlayable_op_Implicit_m112BA2303DA5A9A8E24310332E3C27E13F74A0FD (AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 ___0_playable, const RuntimeMethod* method) 
{
	Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = AnimationClipPlayable_GetHandle_mE775F2247901BA293DB01A8D384D3F9D02A25627((&___0_playable), NULL);
		Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F L_1;
		memset((&L_1), 0, sizeof(L_1));
		Playable__ctor_mD2EB35E024816AEED68795D0124EAB30E05BF6C4((&L_1), L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F L_2 = V_0;
		return L_2;
	}
}
// UnityEngine.Animations.AnimationClipPlayable UnityEngine.Animations.AnimationClipPlayable::op_Explicit(UnityEngine.Playables.Playable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 AnimationClipPlayable_op_Explicit_m628ECE4D1BE08300E899184375D65052AEC50E00 (Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F ___0_playable, const RuntimeMethod* method) 
{
	AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = Playable_GetHandle_m39356D23E849DC5428B262092657662C064E04F8((&___0_playable), NULL);
		AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 L_1;
		memset((&L_1), 0, sizeof(L_1));
		AnimationClipPlayable__ctor_mF2EE31CC772B100F98CCAE26963059C6C722FA1A((&L_1), L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 L_2 = V_0;
		return L_2;
	}
}
// System.Boolean UnityEngine.Animations.AnimationClipPlayable::Equals(UnityEngine.Animations.AnimationClipPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClipPlayable_Equals_mC5263BEA86C02CEDF93C5B14EAA168883E1DB5F4 (AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* __this, AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 ___0_other, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = AnimationClipPlayable_GetHandle_mE775F2247901BA293DB01A8D384D3F9D02A25627(__this, NULL);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_1;
		L_1 = AnimationClipPlayable_GetHandle_mE775F2247901BA293DB01A8D384D3F9D02A25627((&___0_other), NULL);
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = PlayableHandle_op_Equality_m0E6C48A28F75A870AC22ADE3BD42F7F70A43C99C(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0016;
	}

IL_0016:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool AnimationClipPlayable_Equals_mC5263BEA86C02CEDF93C5B14EAA168883E1DB5F4_AdjustorThunk (RuntimeObject* __this, AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969 ___0_other, const RuntimeMethod* method)
{
	AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969*>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimationClipPlayable_Equals_mC5263BEA86C02CEDF93C5B14EAA168883E1DB5F4(_thisAdjusted, ___0_other, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.AnimationClipPlayable::GetApplyFootIK()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClipPlayable_GetApplyFootIK_m3E599D05D6A40BEFD651618CE5DDA03F15A3610F (AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* __this, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		bool L_1;
		L_1 = AnimationClipPlayable_GetApplyFootIKInternal_m7695131A7D19C888FB75F2CE2227EC24361AA20A(L_0, NULL);
		V_0 = L_1;
		goto IL_000f;
	}

IL_000f:
	{
		bool L_2 = V_0;
		return L_2;
	}
}
IL2CPP_EXTERN_C  bool AnimationClipPlayable_GetApplyFootIK_m3E599D05D6A40BEFD651618CE5DDA03F15A3610F_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969*>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimationClipPlayable_GetApplyFootIK_m3E599D05D6A40BEFD651618CE5DDA03F15A3610F(_thisAdjusted, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimationClipPlayable::SetApplyFootIK(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable_SetApplyFootIK_m7CBA77F56815AD21784AC53D9EBDAE18AFA48507 (AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* __this, bool ___0_value, const RuntimeMethod* method) 
{
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		bool L_1 = ___0_value;
		AnimationClipPlayable_SetApplyFootIKInternal_m57C77DC9937F7BA02885EEBF5D7CDC1CF9412DFC(L_0, L_1, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationClipPlayable_SetApplyFootIK_m7CBA77F56815AD21784AC53D9EBDAE18AFA48507_AdjustorThunk (RuntimeObject* __this, bool ___0_value, const RuntimeMethod* method)
{
	AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969*>(__this + _offset);
	AnimationClipPlayable_SetApplyFootIK_m7CBA77F56815AD21784AC53D9EBDAE18AFA48507(_thisAdjusted, ___0_value, method);
}
// System.Boolean UnityEngine.Animations.AnimationClipPlayable::GetApplyPlayableIK()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClipPlayable_GetApplyPlayableIK_m04EE9E4136AC350F27814DF3B006238260CF3EE9 (AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* __this, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		bool L_1;
		L_1 = AnimationClipPlayable_GetApplyPlayableIKInternal_m4531AC8A44F8BE94292B95E03E33B5C7E9DAF474(L_0, NULL);
		V_0 = L_1;
		goto IL_000f;
	}

IL_000f:
	{
		bool L_2 = V_0;
		return L_2;
	}
}
IL2CPP_EXTERN_C  bool AnimationClipPlayable_GetApplyPlayableIK_m04EE9E4136AC350F27814DF3B006238260CF3EE9_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969*>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimationClipPlayable_GetApplyPlayableIK_m04EE9E4136AC350F27814DF3B006238260CF3EE9(_thisAdjusted, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimationClipPlayable::SetApplyPlayableIK(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable_SetApplyPlayableIK_m69A6F6E28EB250956E27C1720A0A842848F54DAB (AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* __this, bool ___0_value, const RuntimeMethod* method) 
{
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		bool L_1 = ___0_value;
		AnimationClipPlayable_SetApplyPlayableIKInternal_mBCA5B580834435175256C8319275DD443281DD82(L_0, L_1, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationClipPlayable_SetApplyPlayableIK_m69A6F6E28EB250956E27C1720A0A842848F54DAB_AdjustorThunk (RuntimeObject* __this, bool ___0_value, const RuntimeMethod* method)
{
	AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969*>(__this + _offset);
	AnimationClipPlayable_SetApplyPlayableIK_m69A6F6E28EB250956E27C1720A0A842848F54DAB(_thisAdjusted, ___0_value, method);
}
// System.Void UnityEngine.Animations.AnimationClipPlayable::SetRemoveStartOffset(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable_SetRemoveStartOffset_mBAC88E40F6A759FACA4105EF683181D43381C8E5 (AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* __this, bool ___0_value, const RuntimeMethod* method) 
{
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		bool L_1 = ___0_value;
		AnimationClipPlayable_SetRemoveStartOffsetInternal_m5C095AAB7C17821144A2CD4D7DDFE562358CC5A4(L_0, L_1, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationClipPlayable_SetRemoveStartOffset_mBAC88E40F6A759FACA4105EF683181D43381C8E5_AdjustorThunk (RuntimeObject* __this, bool ___0_value, const RuntimeMethod* method)
{
	AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969*>(__this + _offset);
	AnimationClipPlayable_SetRemoveStartOffset_mBAC88E40F6A759FACA4105EF683181D43381C8E5(_thisAdjusted, ___0_value, method);
}
// System.Void UnityEngine.Animations.AnimationClipPlayable::SetOverrideLoopTime(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable_SetOverrideLoopTime_mF1F57940D8DDBCC6EBCB75A27C2372BB39DED177 (AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* __this, bool ___0_value, const RuntimeMethod* method) 
{
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		bool L_1 = ___0_value;
		AnimationClipPlayable_SetOverrideLoopTimeInternal_m44BAF0A6EE093D0E30EC8FF99423BF6E4B832CC5(L_0, L_1, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationClipPlayable_SetOverrideLoopTime_mF1F57940D8DDBCC6EBCB75A27C2372BB39DED177_AdjustorThunk (RuntimeObject* __this, bool ___0_value, const RuntimeMethod* method)
{
	AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969*>(__this + _offset);
	AnimationClipPlayable_SetOverrideLoopTime_mF1F57940D8DDBCC6EBCB75A27C2372BB39DED177(_thisAdjusted, ___0_value, method);
}
// System.Void UnityEngine.Animations.AnimationClipPlayable::SetLoopTime(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable_SetLoopTime_m3AAA1134C4D339C84EF57FE289D33100D4971ED8 (AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* __this, bool ___0_value, const RuntimeMethod* method) 
{
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		bool L_1 = ___0_value;
		AnimationClipPlayable_SetLoopTimeInternal_mC308D81D4A82EFACED882515D17935E43298E386(L_0, L_1, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationClipPlayable_SetLoopTime_m3AAA1134C4D339C84EF57FE289D33100D4971ED8_AdjustorThunk (RuntimeObject* __this, bool ___0_value, const RuntimeMethod* method)
{
	AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationClipPlayable_t54CEA0DD315B1674C2BD49E681005C4271D73969*>(__this + _offset);
	AnimationClipPlayable_SetLoopTime_m3AAA1134C4D339C84EF57FE289D33100D4971ED8(_thisAdjusted, ___0_value, method);
}
// System.Boolean UnityEngine.Animations.AnimationClipPlayable::CreateHandleInternal(UnityEngine.Playables.PlayableGraph,UnityEngine.AnimationClip,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClipPlayable_CreateHandleInternal_mB8466F44A261B040DBCE8BA442DA8CF7153D2212 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* ___1_clip, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___2_handle, const RuntimeMethod* method) 
{
	{
		AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* L_0 = ___1_clip;
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_1 = ___2_handle;
		bool L_2;
		L_2 = AnimationClipPlayable_CreateHandleInternal_Injected_m4FD6B80E5194144660D7974F13F44BA0355C6E3B((&___0_graph), L_0, L_1, NULL);
		return L_2;
	}
}
// System.Boolean UnityEngine.Animations.AnimationClipPlayable::GetApplyFootIKInternal(UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClipPlayable_GetApplyFootIKInternal_m7695131A7D19C888FB75F2CE2227EC24361AA20A (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, const RuntimeMethod* method) 
{
	typedef bool (*AnimationClipPlayable_GetApplyFootIKInternal_m7695131A7D19C888FB75F2CE2227EC24361AA20A_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*);
	static AnimationClipPlayable_GetApplyFootIKInternal_m7695131A7D19C888FB75F2CE2227EC24361AA20A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClipPlayable_GetApplyFootIKInternal_m7695131A7D19C888FB75F2CE2227EC24361AA20A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationClipPlayable::GetApplyFootIKInternal(UnityEngine.Playables.PlayableHandle&)");
	bool icallRetVal = _il2cpp_icall_func(___0_handle);
	return icallRetVal;
}
// System.Void UnityEngine.Animations.AnimationClipPlayable::SetApplyFootIKInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable_SetApplyFootIKInternal_m57C77DC9937F7BA02885EEBF5D7CDC1CF9412DFC (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, bool ___1_value, const RuntimeMethod* method) 
{
	typedef void (*AnimationClipPlayable_SetApplyFootIKInternal_m57C77DC9937F7BA02885EEBF5D7CDC1CF9412DFC_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, bool);
	static AnimationClipPlayable_SetApplyFootIKInternal_m57C77DC9937F7BA02885EEBF5D7CDC1CF9412DFC_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClipPlayable_SetApplyFootIKInternal_m57C77DC9937F7BA02885EEBF5D7CDC1CF9412DFC_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationClipPlayable::SetApplyFootIKInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)");
	_il2cpp_icall_func(___0_handle, ___1_value);
}
// System.Boolean UnityEngine.Animations.AnimationClipPlayable::GetApplyPlayableIKInternal(UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClipPlayable_GetApplyPlayableIKInternal_m4531AC8A44F8BE94292B95E03E33B5C7E9DAF474 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, const RuntimeMethod* method) 
{
	typedef bool (*AnimationClipPlayable_GetApplyPlayableIKInternal_m4531AC8A44F8BE94292B95E03E33B5C7E9DAF474_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*);
	static AnimationClipPlayable_GetApplyPlayableIKInternal_m4531AC8A44F8BE94292B95E03E33B5C7E9DAF474_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClipPlayable_GetApplyPlayableIKInternal_m4531AC8A44F8BE94292B95E03E33B5C7E9DAF474_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationClipPlayable::GetApplyPlayableIKInternal(UnityEngine.Playables.PlayableHandle&)");
	bool icallRetVal = _il2cpp_icall_func(___0_handle);
	return icallRetVal;
}
// System.Void UnityEngine.Animations.AnimationClipPlayable::SetApplyPlayableIKInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable_SetApplyPlayableIKInternal_mBCA5B580834435175256C8319275DD443281DD82 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, bool ___1_value, const RuntimeMethod* method) 
{
	typedef void (*AnimationClipPlayable_SetApplyPlayableIKInternal_mBCA5B580834435175256C8319275DD443281DD82_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, bool);
	static AnimationClipPlayable_SetApplyPlayableIKInternal_mBCA5B580834435175256C8319275DD443281DD82_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClipPlayable_SetApplyPlayableIKInternal_mBCA5B580834435175256C8319275DD443281DD82_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationClipPlayable::SetApplyPlayableIKInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)");
	_il2cpp_icall_func(___0_handle, ___1_value);
}
// System.Void UnityEngine.Animations.AnimationClipPlayable::SetRemoveStartOffsetInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable_SetRemoveStartOffsetInternal_m5C095AAB7C17821144A2CD4D7DDFE562358CC5A4 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, bool ___1_value, const RuntimeMethod* method) 
{
	typedef void (*AnimationClipPlayable_SetRemoveStartOffsetInternal_m5C095AAB7C17821144A2CD4D7DDFE562358CC5A4_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, bool);
	static AnimationClipPlayable_SetRemoveStartOffsetInternal_m5C095AAB7C17821144A2CD4D7DDFE562358CC5A4_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClipPlayable_SetRemoveStartOffsetInternal_m5C095AAB7C17821144A2CD4D7DDFE562358CC5A4_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationClipPlayable::SetRemoveStartOffsetInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)");
	_il2cpp_icall_func(___0_handle, ___1_value);
}
// System.Void UnityEngine.Animations.AnimationClipPlayable::SetOverrideLoopTimeInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable_SetOverrideLoopTimeInternal_m44BAF0A6EE093D0E30EC8FF99423BF6E4B832CC5 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, bool ___1_value, const RuntimeMethod* method) 
{
	typedef void (*AnimationClipPlayable_SetOverrideLoopTimeInternal_m44BAF0A6EE093D0E30EC8FF99423BF6E4B832CC5_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, bool);
	static AnimationClipPlayable_SetOverrideLoopTimeInternal_m44BAF0A6EE093D0E30EC8FF99423BF6E4B832CC5_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClipPlayable_SetOverrideLoopTimeInternal_m44BAF0A6EE093D0E30EC8FF99423BF6E4B832CC5_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationClipPlayable::SetOverrideLoopTimeInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)");
	_il2cpp_icall_func(___0_handle, ___1_value);
}
// System.Void UnityEngine.Animations.AnimationClipPlayable::SetLoopTimeInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClipPlayable_SetLoopTimeInternal_mC308D81D4A82EFACED882515D17935E43298E386 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, bool ___1_value, const RuntimeMethod* method) 
{
	typedef void (*AnimationClipPlayable_SetLoopTimeInternal_mC308D81D4A82EFACED882515D17935E43298E386_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, bool);
	static AnimationClipPlayable_SetLoopTimeInternal_mC308D81D4A82EFACED882515D17935E43298E386_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClipPlayable_SetLoopTimeInternal_mC308D81D4A82EFACED882515D17935E43298E386_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationClipPlayable::SetLoopTimeInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)");
	_il2cpp_icall_func(___0_handle, ___1_value);
}
// System.Boolean UnityEngine.Animations.AnimationClipPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.AnimationClip,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClipPlayable_CreateHandleInternal_Injected_m4FD6B80E5194144660D7974F13F44BA0355C6E3B (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712* ___1_clip, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___2_handle, const RuntimeMethod* method) 
{
	typedef bool (*AnimationClipPlayable_CreateHandleInternal_Injected_m4FD6B80E5194144660D7974F13F44BA0355C6E3B_ftn) (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E*, AnimationClip_t00BD2F131D308A4AD2C6B0BF66644FC25FECE712*, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*);
	static AnimationClipPlayable_CreateHandleInternal_Injected_m4FD6B80E5194144660D7974F13F44BA0355C6E3B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClipPlayable_CreateHandleInternal_Injected_m4FD6B80E5194144660D7974F13F44BA0355C6E3B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationClipPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.AnimationClip,UnityEngine.Playables.PlayableHandle&)");
	bool icallRetVal = _il2cpp_icall_func(___0_graph, ___1_clip, ___2_handle);
	return icallRetVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Animations.AnimationPosePlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationPosePlayable__ctor_mC6C096785918358CA7EC12BABCDF4BBD47F7BA3F (AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_IsPlayableOfType_TisAnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C_m61A79154B28DAE22A64165C871757F3E447822A6_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		bool L_0;
		L_0 = PlayableHandle_IsValid_m07631D12846BAAF2CC302E69A28A44BFE9EB5098((&___0_handle), NULL);
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0027;
		}
	}
	{
		bool L_2;
		L_2 = PlayableHandle_IsPlayableOfType_TisAnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C_m61A79154B28DAE22A64165C871757F3E447822A6((&___0_handle), PlayableHandle_IsPlayableOfType_TisAnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C_m61A79154B28DAE22A64165C871757F3E447822A6_RuntimeMethod_var);
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0026;
		}
	}
	{
		InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E* L_4 = (InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E_il2cpp_TypeInfo_var)));
		NullCheck(L_4);
		InvalidCastException__ctor_mED3F9781E6CA47A92C602C896EDDF2F40ECB8644(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralE066D08B565F88D413FDACA14C42BFF008FF4EB9)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationPosePlayable__ctor_mC6C096785918358CA7EC12BABCDF4BBD47F7BA3F_RuntimeMethod_var)));
	}

IL_0026:
	{
	}

IL_0027:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_5 = ___0_handle;
		__this->___m_Handle_0 = L_5;
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationPosePlayable__ctor_mC6C096785918358CA7EC12BABCDF4BBD47F7BA3F_AdjustorThunk (RuntimeObject* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method)
{
	AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C*>(__this + _offset);
	AnimationPosePlayable__ctor_mC6C096785918358CA7EC12BABCDF4BBD47F7BA3F(_thisAdjusted, ___0_handle, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationPosePlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationPosePlayable_GetHandle_m5DC7CA4CAF3CD525D454D99EBC3D12C3571B527B (AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C* __this, const RuntimeMethod* method) 
{
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0 = __this->___m_Handle_0;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationPosePlayable_GetHandle_m5DC7CA4CAF3CD525D454D99EBC3D12C3571B527B_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C*>(__this + _offset);
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 _returnValue;
	_returnValue = AnimationPosePlayable_GetHandle_m5DC7CA4CAF3CD525D454D99EBC3D12C3571B527B(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.AnimationPosePlayable::Equals(UnityEngine.Animations.AnimationPosePlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationPosePlayable_Equals_m10F1E7DD7037B2AB3F7DAE3E01A1DC843EABD0A3 (AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C* __this, AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C ___0_other, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = AnimationPosePlayable_GetHandle_m5DC7CA4CAF3CD525D454D99EBC3D12C3571B527B((&___0_other), NULL);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_1 = L_0;
		RuntimeObject* L_2 = Box(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var, &L_1);
		Il2CppFakeBox<AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C> L_3(AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C_il2cpp_TypeInfo_var, __this);
		bool L_4;
		L_4 = ValueType_Equals_mCA5344597A8055EC544855AD60A983B10E0EE67D((ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F*)(&L_3), L_2, NULL);
		V_0 = L_4;
		goto IL_001c;
	}

IL_001c:
	{
		bool L_5 = V_0;
		return L_5;
	}
}
IL2CPP_EXTERN_C  bool AnimationPosePlayable_Equals_m10F1E7DD7037B2AB3F7DAE3E01A1DC843EABD0A3_AdjustorThunk (RuntimeObject* __this, AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C ___0_other, const RuntimeMethod* method)
{
	AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C*>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimationPosePlayable_Equals_m10F1E7DD7037B2AB3F7DAE3E01A1DC843EABD0A3(_thisAdjusted, ___0_other, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimationPosePlayable::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationPosePlayable__cctor_mFA5FE84F06C8E9A89C07190055BC898525F897C4 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C L_1;
		memset((&L_1), 0, sizeof(L_1));
		AnimationPosePlayable__ctor_mC6C096785918358CA7EC12BABCDF4BBD47F7BA3F((&L_1), L_0, /*hidden argument*/NULL);
		((AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C_StaticFields*)il2cpp_codegen_static_fields_for(AnimationPosePlayable_tBB5B82AC675A509F3808C8F825EA24943714CD5C_il2cpp_TypeInfo_var))->___m_NullPlayable_1 = L_1;
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: UnityEngine.Animations.ConstraintSource
IL2CPP_EXTERN_C void ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F_marshal_pinvoke(const ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F& unmarshaled, ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F_marshaled_pinvoke& marshaled)
{
	Exception_t* ___m_SourceTransform_0Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_SourceTransform' of type 'ConstraintSource': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_SourceTransform_0Exception, NULL);
}
IL2CPP_EXTERN_C void ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F_marshal_pinvoke_back(const ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F_marshaled_pinvoke& marshaled, ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F& unmarshaled)
{
	Exception_t* ___m_SourceTransform_0Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_SourceTransform' of type 'ConstraintSource': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_SourceTransform_0Exception, NULL);
}
// Conversion method for clean up from marshalling of: UnityEngine.Animations.ConstraintSource
IL2CPP_EXTERN_C void ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F_marshal_pinvoke_cleanup(ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: UnityEngine.Animations.ConstraintSource
IL2CPP_EXTERN_C void ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F_marshal_com(const ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F& unmarshaled, ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F_marshaled_com& marshaled)
{
	Exception_t* ___m_SourceTransform_0Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_SourceTransform' of type 'ConstraintSource': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_SourceTransform_0Exception, NULL);
}
IL2CPP_EXTERN_C void ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F_marshal_com_back(const ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F_marshaled_com& marshaled, ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F& unmarshaled)
{
	Exception_t* ___m_SourceTransform_0Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_SourceTransform' of type 'ConstraintSource': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_SourceTransform_0Exception, NULL);
}
// Conversion method for clean up from marshalling of: UnityEngine.Animations.ConstraintSource
IL2CPP_EXTERN_C void ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F_marshal_com_cleanup(ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F_marshaled_com& marshaled)
{
}
// System.Void UnityEngine.Animations.ConstraintSource::set_sourceTransform(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConstraintSource_set_sourceTransform_mC905D9E04293D785BA40E1E0378457A77170A31B (ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F* __this, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___0_value, const RuntimeMethod* method) 
{
	{
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_0 = ___0_value;
		__this->___m_SourceTransform_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_SourceTransform_0), (void*)L_0);
		return;
	}
}
IL2CPP_EXTERN_C  void ConstraintSource_set_sourceTransform_mC905D9E04293D785BA40E1E0378457A77170A31B_AdjustorThunk (RuntimeObject* __this, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___0_value, const RuntimeMethod* method)
{
	ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F*>(__this + _offset);
	ConstraintSource_set_sourceTransform_mC905D9E04293D785BA40E1E0378457A77170A31B(_thisAdjusted, ___0_value, method);
}
// System.Void UnityEngine.Animations.ConstraintSource::set_weight(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConstraintSource_set_weight_m40EADC470F7D906EEB89A515F75CC8B0648368D7 (ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F* __this, float ___0_value, const RuntimeMethod* method) 
{
	{
		float L_0 = ___0_value;
		__this->___m_Weight_1 = L_0;
		return;
	}
}
IL2CPP_EXTERN_C  void ConstraintSource_set_weight_m40EADC470F7D906EEB89A515F75CC8B0648368D7_AdjustorThunk (RuntimeObject* __this, float ___0_value, const RuntimeMethod* method)
{
	ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<ConstraintSource_tA4C8733A808A376FC2767B6CB984C63870357C5F*>(__this + _offset);
	ConstraintSource_set_weight_m40EADC470F7D906EEB89A515F75CC8B0648368D7(_thisAdjusted, ___0_value, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Animations.AnimationMotionXToDeltaPlayable UnityEngine.Animations.AnimationMotionXToDeltaPlayable::Create(UnityEngine.Playables.PlayableGraph)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18 AnimationMotionXToDeltaPlayable_Create_m9F2C95194E1B5F76A0399BDE8FCEF33A80B77F73 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18 V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_0 = ___0_graph;
		il2cpp_codegen_runtime_class_init_inline(AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_1;
		L_1 = AnimationMotionXToDeltaPlayable_CreateHandle_m848549F4FA09509BCBD846D85E5E2E8DFB8CBE3B(L_0, NULL);
		V_0 = L_1;
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_2 = V_0;
		AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18 L_3;
		memset((&L_3), 0, sizeof(L_3));
		AnimationMotionXToDeltaPlayable__ctor_mDE3C14B4B975AC693669D66B6E41BB6432AFA940((&L_3), L_2, /*hidden argument*/NULL);
		V_1 = L_3;
		goto IL_0011;
	}

IL_0011:
	{
		AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18 L_4 = V_1;
		return L_4;
	}
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationMotionXToDeltaPlayable::CreateHandle(UnityEngine.Playables.PlayableGraph)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationMotionXToDeltaPlayable_CreateHandle_m848549F4FA09509BCBD846D85E5E2E8DFB8CBE3B (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	bool V_1 = false;
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_2;
	memset((&V_2), 0, sizeof(V_2));
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		V_0 = L_0;
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_1 = ___0_graph;
		il2cpp_codegen_runtime_class_init_inline(AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = AnimationMotionXToDeltaPlayable_CreateHandleInternal_m9556CCBB3F290E53A0BA8021F06C8E83232EF706(L_1, (&V_0), NULL);
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_001e;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_4;
		L_4 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		V_2 = L_4;
		goto IL_002b;
	}

IL_001e:
	{
		PlayableHandle_SetInputCount_m6067CD3616C428F777903FCBFD789060A2185DEE((&V_0), 1, NULL);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_5 = V_0;
		V_2 = L_5;
		goto IL_002b;
	}

IL_002b:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_6 = V_2;
		return L_6;
	}
}
// System.Void UnityEngine.Animations.AnimationMotionXToDeltaPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationMotionXToDeltaPlayable__ctor_mDE3C14B4B975AC693669D66B6E41BB6432AFA940 (AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_IsPlayableOfType_TisAnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18_mE6DAD58415B04EE79FD34641B365283758722ABF_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		bool L_0;
		L_0 = PlayableHandle_IsValid_m07631D12846BAAF2CC302E69A28A44BFE9EB5098((&___0_handle), NULL);
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0027;
		}
	}
	{
		bool L_2;
		L_2 = PlayableHandle_IsPlayableOfType_TisAnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18_mE6DAD58415B04EE79FD34641B365283758722ABF((&___0_handle), PlayableHandle_IsPlayableOfType_TisAnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18_mE6DAD58415B04EE79FD34641B365283758722ABF_RuntimeMethod_var);
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0026;
		}
	}
	{
		InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E* L_4 = (InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E_il2cpp_TypeInfo_var)));
		NullCheck(L_4);
		InvalidCastException__ctor_mED3F9781E6CA47A92C602C896EDDF2F40ECB8644(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral8DC2252638D84FAF2C30B95D54EC83F52FA6C630)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationMotionXToDeltaPlayable__ctor_mDE3C14B4B975AC693669D66B6E41BB6432AFA940_RuntimeMethod_var)));
	}

IL_0026:
	{
	}

IL_0027:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_5 = ___0_handle;
		__this->___m_Handle_0 = L_5;
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationMotionXToDeltaPlayable__ctor_mDE3C14B4B975AC693669D66B6E41BB6432AFA940_AdjustorThunk (RuntimeObject* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method)
{
	AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18*>(__this + _offset);
	AnimationMotionXToDeltaPlayable__ctor_mDE3C14B4B975AC693669D66B6E41BB6432AFA940(_thisAdjusted, ___0_handle, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationMotionXToDeltaPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationMotionXToDeltaPlayable_GetHandle_m09F605E78AD7F0135C7F57EB048031091A50E3A2 (AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18* __this, const RuntimeMethod* method) 
{
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0 = __this->___m_Handle_0;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationMotionXToDeltaPlayable_GetHandle_m09F605E78AD7F0135C7F57EB048031091A50E3A2_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18*>(__this + _offset);
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 _returnValue;
	_returnValue = AnimationMotionXToDeltaPlayable_GetHandle_m09F605E78AD7F0135C7F57EB048031091A50E3A2(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.Playables.Playable UnityEngine.Animations.AnimationMotionXToDeltaPlayable::op_Implicit(UnityEngine.Animations.AnimationMotionXToDeltaPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F AnimationMotionXToDeltaPlayable_op_Implicit_m1AC02CC4C55FD3550D6DFFFB7ADF960BD7D6E35D (AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18 ___0_playable, const RuntimeMethod* method) 
{
	Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = AnimationMotionXToDeltaPlayable_GetHandle_m09F605E78AD7F0135C7F57EB048031091A50E3A2((&___0_playable), NULL);
		Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F L_1;
		memset((&L_1), 0, sizeof(L_1));
		Playable__ctor_mD2EB35E024816AEED68795D0124EAB30E05BF6C4((&L_1), L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F L_2 = V_0;
		return L_2;
	}
}
// System.Boolean UnityEngine.Animations.AnimationMotionXToDeltaPlayable::Equals(UnityEngine.Animations.AnimationMotionXToDeltaPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationMotionXToDeltaPlayable_Equals_m7CBF3B7618EDBA4ECC2F3C2F54011248BC45CDCC (AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18* __this, AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18 ___0_other, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = AnimationMotionXToDeltaPlayable_GetHandle_m09F605E78AD7F0135C7F57EB048031091A50E3A2(__this, NULL);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_1;
		L_1 = AnimationMotionXToDeltaPlayable_GetHandle_m09F605E78AD7F0135C7F57EB048031091A50E3A2((&___0_other), NULL);
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = PlayableHandle_op_Equality_m0E6C48A28F75A870AC22ADE3BD42F7F70A43C99C(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0016;
	}

IL_0016:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool AnimationMotionXToDeltaPlayable_Equals_m7CBF3B7618EDBA4ECC2F3C2F54011248BC45CDCC_AdjustorThunk (RuntimeObject* __this, AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18 ___0_other, const RuntimeMethod* method)
{
	AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18*>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimationMotionXToDeltaPlayable_Equals_m7CBF3B7618EDBA4ECC2F3C2F54011248BC45CDCC(_thisAdjusted, ___0_other, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimationMotionXToDeltaPlayable::SetAbsoluteMotion(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationMotionXToDeltaPlayable_SetAbsoluteMotion_m5D1B029F6E6BFFB521CC6CB72ACBE7EA27B28715 (AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18* __this, bool ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = (&__this->___m_Handle_0);
		bool L_1 = ___0_value;
		il2cpp_codegen_runtime_class_init_inline(AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18_il2cpp_TypeInfo_var);
		AnimationMotionXToDeltaPlayable_SetAbsoluteMotionInternal_m616455F80B4EAE4A0CD24A29630792C62872E929(L_0, L_1, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationMotionXToDeltaPlayable_SetAbsoluteMotion_m5D1B029F6E6BFFB521CC6CB72ACBE7EA27B28715_AdjustorThunk (RuntimeObject* __this, bool ___0_value, const RuntimeMethod* method)
{
	AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18*>(__this + _offset);
	AnimationMotionXToDeltaPlayable_SetAbsoluteMotion_m5D1B029F6E6BFFB521CC6CB72ACBE7EA27B28715(_thisAdjusted, ___0_value, method);
}
// System.Boolean UnityEngine.Animations.AnimationMotionXToDeltaPlayable::CreateHandleInternal(UnityEngine.Playables.PlayableGraph,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationMotionXToDeltaPlayable_CreateHandleInternal_m9556CCBB3F290E53A0BA8021F06C8E83232EF706 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___1_handle, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = ___1_handle;
		il2cpp_codegen_runtime_class_init_inline(AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = AnimationMotionXToDeltaPlayable_CreateHandleInternal_Injected_mAFF1C58B8D07A6A9E92042C038231D7CC873EF11((&___0_graph), L_0, NULL);
		return L_1;
	}
}
// System.Void UnityEngine.Animations.AnimationMotionXToDeltaPlayable::SetAbsoluteMotionInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationMotionXToDeltaPlayable_SetAbsoluteMotionInternal_m616455F80B4EAE4A0CD24A29630792C62872E929 (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___0_handle, bool ___1_value, const RuntimeMethod* method) 
{
	typedef void (*AnimationMotionXToDeltaPlayable_SetAbsoluteMotionInternal_m616455F80B4EAE4A0CD24A29630792C62872E929_ftn) (PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*, bool);
	static AnimationMotionXToDeltaPlayable_SetAbsoluteMotionInternal_m616455F80B4EAE4A0CD24A29630792C62872E929_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationMotionXToDeltaPlayable_SetAbsoluteMotionInternal_m616455F80B4EAE4A0CD24A29630792C62872E929_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationMotionXToDeltaPlayable::SetAbsoluteMotionInternal(UnityEngine.Playables.PlayableHandle&,System.Boolean)");
	_il2cpp_icall_func(___0_handle, ___1_value);
}
// System.Void UnityEngine.Animations.AnimationMotionXToDeltaPlayable::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationMotionXToDeltaPlayable__cctor_m4FC582F607F00D5E2A6B97219D2D4150AFA42AF1 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18 L_1;
		memset((&L_1), 0, sizeof(L_1));
		AnimationMotionXToDeltaPlayable__ctor_mDE3C14B4B975AC693669D66B6E41BB6432AFA940((&L_1), L_0, /*hidden argument*/NULL);
		((AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18_StaticFields*)il2cpp_codegen_static_fields_for(AnimationMotionXToDeltaPlayable_t3946605ADB0B4C054A27B3D65A59F8EB75B6BE18_il2cpp_TypeInfo_var))->___m_NullPlayable_1 = L_1;
		return;
	}
}
// System.Boolean UnityEngine.Animations.AnimationMotionXToDeltaPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationMotionXToDeltaPlayable_CreateHandleInternal_Injected_mAFF1C58B8D07A6A9E92042C038231D7CC873EF11 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___1_handle, const RuntimeMethod* method) 
{
	typedef bool (*AnimationMotionXToDeltaPlayable_CreateHandleInternal_Injected_mAFF1C58B8D07A6A9E92042C038231D7CC873EF11_ftn) (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E*, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*);
	static AnimationMotionXToDeltaPlayable_CreateHandleInternal_Injected_mAFF1C58B8D07A6A9E92042C038231D7CC873EF11_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationMotionXToDeltaPlayable_CreateHandleInternal_Injected_mAFF1C58B8D07A6A9E92042C038231D7CC873EF11_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationMotionXToDeltaPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Playables.PlayableHandle&)");
	bool icallRetVal = _il2cpp_icall_func(___0_graph, ___1_handle);
	return icallRetVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Animations.AnimationMixerPlayable UnityEngine.Animations.AnimationMixerPlayable::Create(UnityEngine.Playables.PlayableGraph,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0 AnimationMixerPlayable_Create_m96BFD63578EC4E4167A30E4899EF3DA2A4E431F2 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, int32_t ___1_inputCount, bool ___2_normalizeWeights, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_0 = ___0_graph;
		int32_t L_1 = ___1_inputCount;
		il2cpp_codegen_runtime_class_init_inline(AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0_il2cpp_TypeInfo_var);
		AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0 L_2;
		L_2 = AnimationMixerPlayable_Create_m4136E1F8A7BF26D3DE52C68111F8E1D789A7A8F3(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_000b;
	}

IL_000b:
	{
		AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0 L_3 = V_0;
		return L_3;
	}
}
// UnityEngine.Animations.AnimationMixerPlayable UnityEngine.Animations.AnimationMixerPlayable::Create(UnityEngine.Playables.PlayableGraph,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0 AnimationMixerPlayable_Create_m4136E1F8A7BF26D3DE52C68111F8E1D789A7A8F3 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, int32_t ___1_inputCount, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0 V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_0 = ___0_graph;
		int32_t L_1 = ___1_inputCount;
		il2cpp_codegen_runtime_class_init_inline(AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_2;
		L_2 = AnimationMixerPlayable_CreateHandle_m98DCB979893A9C4F782B2E07EF12BD69CF838A9C(L_0, L_1, NULL);
		V_0 = L_2;
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_3 = V_0;
		AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0 L_4;
		memset((&L_4), 0, sizeof(L_4));
		AnimationMixerPlayable__ctor_mBF84CC064549C2C00B2AE1174018335958EB7EA7((&L_4), L_3, /*hidden argument*/NULL);
		V_1 = L_4;
		goto IL_0012;
	}

IL_0012:
	{
		AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0 L_5 = V_1;
		return L_5;
	}
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationMixerPlayable::CreateHandle(UnityEngine.Playables.PlayableGraph,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationMixerPlayable_CreateHandle_m98DCB979893A9C4F782B2E07EF12BD69CF838A9C (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, int32_t ___1_inputCount, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	bool V_1 = false;
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_2;
	memset((&V_2), 0, sizeof(V_2));
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		V_0 = L_0;
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_1 = ___0_graph;
		il2cpp_codegen_runtime_class_init_inline(AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = AnimationMixerPlayable_CreateHandleInternal_m0C404F86C8C0FDD248BED7E153F3BEFBEEA39D37(L_1, (&V_0), NULL);
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_001e;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_4;
		L_4 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		V_2 = L_4;
		goto IL_002b;
	}

IL_001e:
	{
		int32_t L_5 = ___1_inputCount;
		PlayableHandle_SetInputCount_m6067CD3616C428F777903FCBFD789060A2185DEE((&V_0), L_5, NULL);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_6 = V_0;
		V_2 = L_6;
		goto IL_002b;
	}

IL_002b:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_7 = V_2;
		return L_7;
	}
}
// System.Void UnityEngine.Animations.AnimationMixerPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationMixerPlayable__ctor_mBF84CC064549C2C00B2AE1174018335958EB7EA7 (AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_IsPlayableOfType_TisAnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0_m644E76378CB4DDC0CE669FE1DCE8A8917595D0ED_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		bool L_0;
		L_0 = PlayableHandle_IsValid_m07631D12846BAAF2CC302E69A28A44BFE9EB5098((&___0_handle), NULL);
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0027;
		}
	}
	{
		bool L_2;
		L_2 = PlayableHandle_IsPlayableOfType_TisAnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0_m644E76378CB4DDC0CE669FE1DCE8A8917595D0ED((&___0_handle), PlayableHandle_IsPlayableOfType_TisAnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0_m644E76378CB4DDC0CE669FE1DCE8A8917595D0ED_RuntimeMethod_var);
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0026;
		}
	}
	{
		InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E* L_4 = (InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E_il2cpp_TypeInfo_var)));
		NullCheck(L_4);
		InvalidCastException__ctor_mED3F9781E6CA47A92C602C896EDDF2F40ECB8644(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral4DEE968069F34C26613ADFCD69C41EFC29314286)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationMixerPlayable__ctor_mBF84CC064549C2C00B2AE1174018335958EB7EA7_RuntimeMethod_var)));
	}

IL_0026:
	{
	}

IL_0027:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_5 = ___0_handle;
		__this->___m_Handle_0 = L_5;
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationMixerPlayable__ctor_mBF84CC064549C2C00B2AE1174018335958EB7EA7_AdjustorThunk (RuntimeObject* __this, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 ___0_handle, const RuntimeMethod* method)
{
	AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0*>(__this + _offset);
	AnimationMixerPlayable__ctor_mBF84CC064549C2C00B2AE1174018335958EB7EA7(_thisAdjusted, ___0_handle, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationMixerPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationMixerPlayable_GetHandle_mBA6CEB1579A713A985D474E75BC282728318882F (AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0* __this, const RuntimeMethod* method) 
{
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0 = __this->___m_Handle_0;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 AnimationMixerPlayable_GetHandle_mBA6CEB1579A713A985D474E75BC282728318882F_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0*>(__this + _offset);
	PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 _returnValue;
	_returnValue = AnimationMixerPlayable_GetHandle_mBA6CEB1579A713A985D474E75BC282728318882F(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.Playables.Playable UnityEngine.Animations.AnimationMixerPlayable::op_Implicit(UnityEngine.Animations.AnimationMixerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F AnimationMixerPlayable_op_Implicit_m7B2D50F94CD0EE3E66478A560CC929BE7C985323 (AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0 ___0_playable, const RuntimeMethod* method) 
{
	Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = AnimationMixerPlayable_GetHandle_mBA6CEB1579A713A985D474E75BC282728318882F((&___0_playable), NULL);
		Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F L_1;
		memset((&L_1), 0, sizeof(L_1));
		Playable__ctor_mD2EB35E024816AEED68795D0124EAB30E05BF6C4((&L_1), L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		Playable_t95C6B795846BA0C7D96E4DA14897CCCF2554334F L_2 = V_0;
		return L_2;
	}
}
// System.Boolean UnityEngine.Animations.AnimationMixerPlayable::Equals(UnityEngine.Animations.AnimationMixerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationMixerPlayable_Equals_m6EBE215636EEEA3196A43F4D6C1FE6DD704AFA4E (AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0* __this, AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0 ___0_other, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = AnimationMixerPlayable_GetHandle_mBA6CEB1579A713A985D474E75BC282728318882F(__this, NULL);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_1;
		L_1 = AnimationMixerPlayable_GetHandle_mBA6CEB1579A713A985D474E75BC282728318882F((&___0_other), NULL);
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = PlayableHandle_op_Equality_m0E6C48A28F75A870AC22ADE3BD42F7F70A43C99C(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0016;
	}

IL_0016:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool AnimationMixerPlayable_Equals_m6EBE215636EEEA3196A43F4D6C1FE6DD704AFA4E_AdjustorThunk (RuntimeObject* __this, AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0 ___0_other, const RuntimeMethod* method)
{
	AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0*>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimationMixerPlayable_Equals_m6EBE215636EEEA3196A43F4D6C1FE6DD704AFA4E(_thisAdjusted, ___0_other, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.AnimationMixerPlayable::CreateHandleInternal(UnityEngine.Playables.PlayableGraph,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationMixerPlayable_CreateHandleInternal_m0C404F86C8C0FDD248BED7E153F3BEFBEEA39D37 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___1_handle, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* L_0 = ___1_handle;
		il2cpp_codegen_runtime_class_init_inline(AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = AnimationMixerPlayable_CreateHandleInternal_Injected_mD26E05A0F2676C90B7F06E718B7843167D33FE1E((&___0_graph), L_0, NULL);
		return L_1;
	}
}
// System.Void UnityEngine.Animations.AnimationMixerPlayable::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationMixerPlayable__cctor_m7D67E8E778387293AF1ACB1FDBE6ADA3E456A969 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4_il2cpp_TypeInfo_var);
		PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4 L_0;
		L_0 = PlayableHandle_get_Null_mF44FE0A71C67054D272F454C91F7E08CBF14A975(NULL);
		AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0 L_1;
		memset((&L_1), 0, sizeof(L_1));
		AnimationMixerPlayable__ctor_mBF84CC064549C2C00B2AE1174018335958EB7EA7((&L_1), L_0, /*hidden argument*/NULL);
		((AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0_StaticFields*)il2cpp_codegen_static_fields_for(AnimationMixerPlayable_t2984697B87B8719A34519FCF2130545D6D7AB6C0_il2cpp_TypeInfo_var))->___m_NullPlayable_1 = L_1;
		return;
	}
}
// System.Boolean UnityEngine.Animations.AnimationMixerPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Playables.PlayableHandle&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationMixerPlayable_CreateHandleInternal_Injected_mD26E05A0F2676C90B7F06E718B7843167D33FE1E (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E* ___0_graph, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4* ___1_handle, const RuntimeMethod* method) 
{
	typedef bool (*AnimationMixerPlayable_CreateHandleInternal_Injected_mD26E05A0F2676C90B7F06E718B7843167D33FE1E_ftn) (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E*, PlayableHandle_t5D6A01EF94382EFEDC047202F71DF882769654D4*);
	static AnimationMixerPlayable_CreateHandleInternal_Injected_mD26E05A0F2676C90B7F06E718B7843167D33FE1E_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationMixerPlayable_CreateHandleInternal_Injected_mD26E05A0F2676C90B7F06E718B7843167D33FE1E_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationMixerPlayable::CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph&,UnityEngine.Playables.PlayableHandle&)");
	bool icallRetVal = _il2cpp_icall_func(___0_graph, ___1_handle);
	return icallRetVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.UInt32 UnityEngine.Animations.AnimationStream::get_animatorBindingsVersion()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t AnimationStream_get_animatorBindingsVersion_mD7D19DCE96F93CE4DC36457F974C5B8562A3B5E4 (AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* __this, const RuntimeMethod* method) 
{
	uint32_t V_0 = 0;
	{
		uint32_t L_0 = __this->___m_AnimatorBindingsVersion_0;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		uint32_t L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  uint32_t AnimationStream_get_animatorBindingsVersion_mD7D19DCE96F93CE4DC36457F974C5B8562A3B5E4_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A*>(__this + _offset);
	uint32_t _returnValue;
	_returnValue = AnimationStream_get_animatorBindingsVersion_mD7D19DCE96F93CE4DC36457F974C5B8562A3B5E4(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.AnimationStream::get_isValid()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationStream_get_isValid_mE1F032BDA653D5A903DCD427F4677A6C9C4C227A (AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IntPtr_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	int32_t G_B7_0 = 0;
	{
		uint32_t L_0 = __this->___m_AnimatorBindingsVersion_0;
		if ((!(((uint32_t)L_0) >= ((uint32_t)2))))
		{
			goto IL_0064;
		}
	}
	{
		intptr_t L_1 = __this->___constant_1;
		intptr_t L_2 = ((IntPtr_t_StaticFields*)il2cpp_codegen_static_fields_for(IntPtr_t_il2cpp_TypeInfo_var))->___Zero_1;
		bool L_3;
		L_3 = IntPtr_op_Inequality_m90EFC9C4CAD9A33E309F2DDF98EE4E1DD253637B(L_1, L_2, NULL);
		if (!L_3)
		{
			goto IL_0064;
		}
	}
	{
		intptr_t L_4 = __this->___input_2;
		intptr_t L_5 = ((IntPtr_t_StaticFields*)il2cpp_codegen_static_fields_for(IntPtr_t_il2cpp_TypeInfo_var))->___Zero_1;
		bool L_6;
		L_6 = IntPtr_op_Inequality_m90EFC9C4CAD9A33E309F2DDF98EE4E1DD253637B(L_4, L_5, NULL);
		if (!L_6)
		{
			goto IL_0064;
		}
	}
	{
		intptr_t L_7 = __this->___output_3;
		intptr_t L_8 = ((IntPtr_t_StaticFields*)il2cpp_codegen_static_fields_for(IntPtr_t_il2cpp_TypeInfo_var))->___Zero_1;
		bool L_9;
		L_9 = IntPtr_op_Inequality_m90EFC9C4CAD9A33E309F2DDF98EE4E1DD253637B(L_7, L_8, NULL);
		if (!L_9)
		{
			goto IL_0064;
		}
	}
	{
		intptr_t L_10 = __this->___workspace_4;
		intptr_t L_11 = ((IntPtr_t_StaticFields*)il2cpp_codegen_static_fields_for(IntPtr_t_il2cpp_TypeInfo_var))->___Zero_1;
		bool L_12;
		L_12 = IntPtr_op_Inequality_m90EFC9C4CAD9A33E309F2DDF98EE4E1DD253637B(L_10, L_11, NULL);
		if (!L_12)
		{
			goto IL_0064;
		}
	}
	{
		intptr_t L_13 = __this->___animationHandleBinder_6;
		intptr_t L_14 = ((IntPtr_t_StaticFields*)il2cpp_codegen_static_fields_for(IntPtr_t_il2cpp_TypeInfo_var))->___Zero_1;
		bool L_15;
		L_15 = IntPtr_op_Inequality_m90EFC9C4CAD9A33E309F2DDF98EE4E1DD253637B(L_13, L_14, NULL);
		G_B7_0 = ((int32_t)(L_15));
		goto IL_0065;
	}

IL_0064:
	{
		G_B7_0 = 0;
	}

IL_0065:
	{
		V_0 = (bool)G_B7_0;
		goto IL_0068;
	}

IL_0068:
	{
		bool L_16 = V_0;
		return L_16;
	}
}
IL2CPP_EXTERN_C  bool AnimationStream_get_isValid_mE1F032BDA653D5A903DCD427F4677A6C9C4C227A_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A*>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimationStream_get_isValid_mE1F032BDA653D5A903DCD427F4677A6C9C4C227A(_thisAdjusted, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimationStream::CheckIsValid()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationStream_CheckIsValid_m6C46800E1A5A4BE27FF761A93F72BC3CD751174C (AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* __this, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		bool L_0;
		L_0 = AnimationStream_get_isValid_mE1F032BDA653D5A903DCD427F4677A6C9C4C227A(__this, NULL);
		V_0 = (bool)((((int32_t)L_0) == ((int32_t)0))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0019;
		}
	}
	{
		InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB* L_2 = (InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB_il2cpp_TypeInfo_var)));
		NullCheck(L_2);
		InvalidOperationException__ctor_mE4CB6F4712AB6D99A2358FBAE2E052B3EE976162(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralB31E4AEFDFD2E76052D908F31AC56B3ABCFC7987)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationStream_CheckIsValid_m6C46800E1A5A4BE27FF761A93F72BC3CD751174C_RuntimeMethod_var)));
	}

IL_0019:
	{
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationStream_CheckIsValid_m6C46800E1A5A4BE27FF761A93F72BC3CD751174C_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A*>(__this + _offset);
	AnimationStream_CheckIsValid_m6C46800E1A5A4BE27FF761A93F72BC3CD751174C(_thisAdjusted, method);
}
// System.Single UnityEngine.Animations.AnimationStream::get_deltaTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimationStream_get_deltaTime_mECEF75B188313080405BFB556AB4CFD972233861 (AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* __this, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	{
		AnimationStream_CheckIsValid_m6C46800E1A5A4BE27FF761A93F72BC3CD751174C(__this, NULL);
		float L_0;
		L_0 = AnimationStream_GetDeltaTime_m335ACEAEEAEE7E3FAE1CCBD81DA839C6C1CFF0A9(__this, NULL);
		V_0 = L_0;
		goto IL_0011;
	}

IL_0011:
	{
		float L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  float AnimationStream_get_deltaTime_mECEF75B188313080405BFB556AB4CFD972233861_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A*>(__this + _offset);
	float _returnValue;
	_returnValue = AnimationStream_get_deltaTime_mECEF75B188313080405BFB556AB4CFD972233861(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.Animations.AnimationStream::GetDeltaTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimationStream_GetDeltaTime_m335ACEAEEAEE7E3FAE1CCBD81DA839C6C1CFF0A9 (AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* __this, const RuntimeMethod* method) 
{
	{
		float L_0;
		L_0 = AnimationStream_GetDeltaTime_Injected_mF06679592F1FEFA1DD24E4553554913F59DAAE55(__this, NULL);
		return L_0;
	}
}
IL2CPP_EXTERN_C  float AnimationStream_GetDeltaTime_m335ACEAEEAEE7E3FAE1CCBD81DA839C6C1CFF0A9_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A*>(__this + _offset);
	float _returnValue;
	_returnValue = AnimationStream_GetDeltaTime_m335ACEAEEAEE7E3FAE1CCBD81DA839C6C1CFF0A9(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.Animations.AnimationStream::GetDeltaTime_Injected(UnityEngine.Animations.AnimationStream&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimationStream_GetDeltaTime_Injected_mF06679592F1FEFA1DD24E4553554913F59DAAE55 (AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A* ___0__unity_self, const RuntimeMethod* method) 
{
	typedef float (*AnimationStream_GetDeltaTime_Injected_mF06679592F1FEFA1DD24E4553554913F59DAAE55_ftn) (AnimationStream_tA73510DCEE63720142DF4F8E15C337A48E47B94A*);
	static AnimationStream_GetDeltaTime_Injected_mF06679592F1FEFA1DD24E4553554913F59DAAE55_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationStream_GetDeltaTime_Injected_mF06679592F1FEFA1DD24E4553554913F59DAAE55_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationStream::GetDeltaTime_Injected(UnityEngine.Animations.AnimationStream&)");
	float icallRetVal = _il2cpp_icall_func(___0__unity_self);
	return icallRetVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Animations.AnimationPlayableOutput UnityEngine.Animations.AnimationPlayableOutput::Create(UnityEngine.Playables.PlayableGraph,System.String,UnityEngine.Animator)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E AnimationPlayableOutput_Create_m65847A70F6C74854387814C5B1D4C281B6CCCDC4 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, String_t* ___1_name, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___2_target, const RuntimeMethod* method) 
{
	PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 V_0;
	memset((&V_0), 0, sizeof(V_0));
	AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E V_1;
	memset((&V_1), 0, sizeof(V_1));
	bool V_2 = false;
	AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E V_3;
	memset((&V_3), 0, sizeof(V_3));
	{
		String_t* L_0 = ___1_name;
		bool L_1;
		L_1 = AnimationPlayableGraphExtensions_InternalCreateAnimationOutput_m2FBE35C9ADFA39052F34E49F46E39CEBD10F4B49((&___0_graph), L_0, (&V_0), NULL);
		V_2 = (bool)((((int32_t)L_1) == ((int32_t)0))? 1 : 0);
		bool L_2 = V_2;
		if (!L_2)
		{
			goto IL_001a;
		}
	}
	{
		AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E L_3;
		L_3 = AnimationPlayableOutput_get_Null_mDF5638798B49F3E7ACCF766C266D7F776E553900(NULL);
		V_3 = L_3;
		goto IL_002f;
	}

IL_001a:
	{
		PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 L_4 = V_0;
		AnimationPlayableOutput__ctor_mE4FB8AA6DFB2F3C18E04A9317F5CE53597A7D22A((&V_1), L_4, NULL);
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_5 = ___2_target;
		AnimationPlayableOutput_SetTarget_m0F7745C4A721D76EB1E804AA48E70C9C798E0DCE((&V_1), L_5, NULL);
		AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E L_6 = V_1;
		V_3 = L_6;
		goto IL_002f;
	}

IL_002f:
	{
		AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E L_7 = V_3;
		return L_7;
	}
}
// System.Void UnityEngine.Animations.AnimationPlayableOutput::.ctor(UnityEngine.Playables.PlayableOutputHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationPlayableOutput__ctor_mE4FB8AA6DFB2F3C18E04A9317F5CE53597A7D22A (AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E* __this, PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 ___0_handle, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableOutputHandle_IsPlayableOutputOfType_TisAnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E_mDA87D18E66EB65AFF53F5AD517C7FBA69DD6D793_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		bool L_0;
		L_0 = PlayableOutputHandle_IsValid_mA94C343D72B72C3B1C7636C93A8DB5EA71691312((&___0_handle), NULL);
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0027;
		}
	}
	{
		bool L_2;
		L_2 = PlayableOutputHandle_IsPlayableOutputOfType_TisAnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E_mDA87D18E66EB65AFF53F5AD517C7FBA69DD6D793((&___0_handle), PlayableOutputHandle_IsPlayableOutputOfType_TisAnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E_mDA87D18E66EB65AFF53F5AD517C7FBA69DD6D793_RuntimeMethod_var);
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0026;
		}
	}
	{
		InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E* L_4 = (InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidCastException_t47FC62F21A3937E814D20381DDACEF240E95AC2E_il2cpp_TypeInfo_var)));
		NullCheck(L_4);
		InvalidCastException__ctor_mED3F9781E6CA47A92C602C896EDDF2F40ECB8644(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral1767A709DBA16BACAD77F5ED6AF9CBBD95D35D4E)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationPlayableOutput__ctor_mE4FB8AA6DFB2F3C18E04A9317F5CE53597A7D22A_RuntimeMethod_var)));
	}

IL_0026:
	{
	}

IL_0027:
	{
		PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 L_5 = ___0_handle;
		__this->___m_Handle_0 = L_5;
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationPlayableOutput__ctor_mE4FB8AA6DFB2F3C18E04A9317F5CE53597A7D22A_AdjustorThunk (RuntimeObject* __this, PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 ___0_handle, const RuntimeMethod* method)
{
	AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E*>(__this + _offset);
	AnimationPlayableOutput__ctor_mE4FB8AA6DFB2F3C18E04A9317F5CE53597A7D22A(_thisAdjusted, ___0_handle, method);
}
// UnityEngine.Animations.AnimationPlayableOutput UnityEngine.Animations.AnimationPlayableOutput::get_Null()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E AnimationPlayableOutput_get_Null_mDF5638798B49F3E7ACCF766C266D7F776E553900 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		il2cpp_codegen_runtime_class_init_inline(PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883_il2cpp_TypeInfo_var);
		PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 L_0;
		L_0 = PlayableOutputHandle_get_Null_m656E8D2549FA031DA8A2EA5B39CE3B33D75B69F8(NULL);
		AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E L_1;
		memset((&L_1), 0, sizeof(L_1));
		AnimationPlayableOutput__ctor_mE4FB8AA6DFB2F3C18E04A9317F5CE53597A7D22A((&L_1), L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000e;
	}

IL_000e:
	{
		AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E L_2 = V_0;
		return L_2;
	}
}
// UnityEngine.Playables.PlayableOutputHandle UnityEngine.Animations.AnimationPlayableOutput::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 AnimationPlayableOutput_GetHandle_m2A8E2A9CBD12EDCF48FC946445AB42802083338D (AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E* __this, const RuntimeMethod* method) 
{
	PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 L_0 = __this->___m_Handle_0;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 AnimationPlayableOutput_GetHandle_m2A8E2A9CBD12EDCF48FC946445AB42802083338D_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E*>(__this + _offset);
	PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 _returnValue;
	_returnValue = AnimationPlayableOutput_GetHandle_m2A8E2A9CBD12EDCF48FC946445AB42802083338D(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.Playables.PlayableOutput UnityEngine.Animations.AnimationPlayableOutput::op_Implicit(UnityEngine.Animations.AnimationPlayableOutput)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableOutput_t2F7C45A58DA3E788EEDDB439549E21CF3FCF3680 AnimationPlayableOutput_op_Implicit_mB256AA7AA6BC0577B47399941D4B42BBC5C28DA7 (AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E ___0_output, const RuntimeMethod* method) 
{
	PlayableOutput_t2F7C45A58DA3E788EEDDB439549E21CF3FCF3680 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 L_0;
		L_0 = AnimationPlayableOutput_GetHandle_m2A8E2A9CBD12EDCF48FC946445AB42802083338D((&___0_output), NULL);
		PlayableOutput_t2F7C45A58DA3E788EEDDB439549E21CF3FCF3680 L_1;
		memset((&L_1), 0, sizeof(L_1));
		PlayableOutput__ctor_m55FBB20EC479F67641835EA48D84A1AB3DF39747((&L_1), L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		PlayableOutput_t2F7C45A58DA3E788EEDDB439549E21CF3FCF3680 L_2 = V_0;
		return L_2;
	}
}
// UnityEngine.Animations.AnimationPlayableOutput UnityEngine.Animations.AnimationPlayableOutput::op_Explicit(UnityEngine.Playables.PlayableOutput)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E AnimationPlayableOutput_op_Explicit_m7139943338A06A1B3DE71DF52A0D253C6DC8877E (PlayableOutput_t2F7C45A58DA3E788EEDDB439549E21CF3FCF3680 ___0_output, const RuntimeMethod* method) 
{
	AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883 L_0;
		L_0 = PlayableOutput_GetHandle_m12FF2889D15884CBEB92A6CB376827EBA5A607BF((&___0_output), NULL);
		AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E L_1;
		memset((&L_1), 0, sizeof(L_1));
		AnimationPlayableOutput__ctor_mE4FB8AA6DFB2F3C18E04A9317F5CE53597A7D22A((&L_1), L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E L_2 = V_0;
		return L_2;
	}
}
// System.Void UnityEngine.Animations.AnimationPlayableOutput::SetTarget(UnityEngine.Animator)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationPlayableOutput_SetTarget_m0F7745C4A721D76EB1E804AA48E70C9C798E0DCE (AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E* __this, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_value, const RuntimeMethod* method) 
{
	{
		PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883* L_0 = (&__this->___m_Handle_0);
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_1 = ___0_value;
		AnimationPlayableOutput_InternalSetTarget_m49002BC3713A0AF76F2447A0147493F234B8E616(L_0, L_1, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationPlayableOutput_SetTarget_m0F7745C4A721D76EB1E804AA48E70C9C798E0DCE_AdjustorThunk (RuntimeObject* __this, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___0_value, const RuntimeMethod* method)
{
	AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E*>(__this + _offset);
	AnimationPlayableOutput_SetTarget_m0F7745C4A721D76EB1E804AA48E70C9C798E0DCE(_thisAdjusted, ___0_value, method);
}
// System.Void UnityEngine.Animations.AnimationPlayableOutput::InternalSetTarget(UnityEngine.Playables.PlayableOutputHandle&,UnityEngine.Animator)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationPlayableOutput_InternalSetTarget_m49002BC3713A0AF76F2447A0147493F234B8E616 (PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883* ___0_handle, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___1_target, const RuntimeMethod* method) 
{
	typedef void (*AnimationPlayableOutput_InternalSetTarget_m49002BC3713A0AF76F2447A0147493F234B8E616_ftn) (PlayableOutputHandle_tEB217645A8C0356A3AC6F964F283003B9740E883*, Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*);
	static AnimationPlayableOutput_InternalSetTarget_m49002BC3713A0AF76F2447A0147493F234B8E616_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationPlayableOutput_InternalSetTarget_m49002BC3713A0AF76F2447A0147493F234B8E616_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animations.AnimationPlayableOutput::InternalSetTarget(UnityEngine.Playables.PlayableOutputHandle&,UnityEngine.Animator)");
	_il2cpp_icall_func(___0_handle, ___1_target);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Playables.PlayableBinding UnityEngine.Animations.AnimationPlayableBinding::Create(System.String,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableBinding_tB68B3BAC47F4F4C559640472174D5BEF93CB6AB4 AnimationPlayableBinding_Create_m3E764C5FC95E912E727275AA705701933B93C2CB (String_t* ___0_name, Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___1_key, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationPlayableBinding_CreateAnimationOutput_mAAF4FE67781A130389ADA1BD625D42215B4C55A2_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Animator_t8A52E42AE54F76681838FE9E632683EF3952E883_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CreateOutputMethod_tD18AFE3B69E6DDD913D82D5FA1D5D909CEEC8509_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableBinding_tB68B3BAC47F4F4C559640472174D5BEF93CB6AB4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	PlayableBinding_tB68B3BAC47F4F4C559640472174D5BEF93CB6AB4 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		String_t* L_0 = ___0_name;
		Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* L_1 = ___1_key;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_2 = { reinterpret_cast<intptr_t> (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_3;
		L_3 = Type_GetTypeFromHandle_m6062B81682F79A4D6DF2640692EE6D9987858C57(L_2, NULL);
		CreateOutputMethod_tD18AFE3B69E6DDD913D82D5FA1D5D909CEEC8509* L_4 = (CreateOutputMethod_tD18AFE3B69E6DDD913D82D5FA1D5D909CEEC8509*)il2cpp_codegen_object_new(CreateOutputMethod_tD18AFE3B69E6DDD913D82D5FA1D5D909CEEC8509_il2cpp_TypeInfo_var);
		NullCheck(L_4);
		CreateOutputMethod__ctor_m5A339017CD8ECB0140EB936FD2A5B589B20166B4(L_4, NULL, (intptr_t)((void*)AnimationPlayableBinding_CreateAnimationOutput_mAAF4FE67781A130389ADA1BD625D42215B4C55A2_RuntimeMethod_var), NULL);
		il2cpp_codegen_runtime_class_init_inline(PlayableBinding_tB68B3BAC47F4F4C559640472174D5BEF93CB6AB4_il2cpp_TypeInfo_var);
		PlayableBinding_tB68B3BAC47F4F4C559640472174D5BEF93CB6AB4 L_5;
		L_5 = PlayableBinding_CreateInternal_m63C8C98E659B52725E0373019ECFCEC22167A47A(L_0, L_1, L_3, L_4, NULL);
		V_0 = L_5;
		goto IL_0021;
	}

IL_0021:
	{
		PlayableBinding_tB68B3BAC47F4F4C559640472174D5BEF93CB6AB4 L_6 = V_0;
		return L_6;
	}
}
// UnityEngine.Playables.PlayableOutput UnityEngine.Animations.AnimationPlayableBinding::CreateAnimationOutput(UnityEngine.Playables.PlayableGraph,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableOutput_t2F7C45A58DA3E788EEDDB439549E21CF3FCF3680 AnimationPlayableBinding_CreateAnimationOutput_mAAF4FE67781A130389ADA1BD625D42215B4C55A2 (PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E ___0_graph, String_t* ___1_name, const RuntimeMethod* method) 
{
	PlayableOutput_t2F7C45A58DA3E788EEDDB439549E21CF3FCF3680 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableGraph_t4A5B0B45343A240F0761574FD7C672E0CFFF7A6E L_0 = ___0_graph;
		String_t* L_1 = ___1_name;
		AnimationPlayableOutput_t753AC95DC826789BC537D18449E93114777DDF4E L_2;
		L_2 = AnimationPlayableOutput_Create_m65847A70F6C74854387814C5B1D4C281B6CCCDC4(L_0, L_1, (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883*)NULL, NULL);
		PlayableOutput_t2F7C45A58DA3E788EEDDB439549E21CF3FCF3680 L_3;
		L_3 = AnimationPlayableOutput_op_Implicit_mB256AA7AA6BC0577B47399941D4B42BBC5C28DA7(L_2, NULL);
		V_0 = L_3;
		goto IL_0011;
	}

IL_0011:
	{
		PlayableOutput_t2F7C45A58DA3E788EEDDB439549E21CF3FCF3680 L_4 = V_0;
		return L_4;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void OnOverrideControllerDirtyCallback_Invoke_m538DCB0FFFE75495DC3977DBBF55A07C570F8B5A_inline (OnOverrideControllerDirtyCallback_tDC67F7661A27502AD804BDE0B696955AFD4A44D5* __this, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
