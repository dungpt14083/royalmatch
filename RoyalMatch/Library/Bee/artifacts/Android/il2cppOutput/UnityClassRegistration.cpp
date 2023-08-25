extern "C" void RegisterStaticallyLinkedModulesGranular()
{
	void RegisterModule_SharedInternals();
	RegisterModule_SharedInternals();

	void RegisterModule_Core();
	RegisterModule_Core();

	void RegisterModule_AI();
	RegisterModule_AI();

	void RegisterModule_AndroidJNI();
	RegisterModule_AndroidJNI();

	void RegisterModule_Animation();
	RegisterModule_Animation();

	void RegisterModule_Audio();
	RegisterModule_Audio();

	void RegisterModule_Director();
	RegisterModule_Director();

	void RegisterModule_Grid();
	RegisterModule_Grid();

	void RegisterModule_ImageConversion();
	RegisterModule_ImageConversion();

	void RegisterModule_IMGUI();
	RegisterModule_IMGUI();

	void RegisterModule_JSONSerialize();
	RegisterModule_JSONSerialize();

	void RegisterModule_CrashReporting();
	RegisterModule_CrashReporting();

	void RegisterModule_Input();
	RegisterModule_Input();

	void RegisterModule_InputLegacy();
	RegisterModule_InputLegacy();

	void RegisterModule_ParticleSystem();
	RegisterModule_ParticleSystem();

	void RegisterModule_PerformanceReporting();
	RegisterModule_PerformanceReporting();

	void RegisterModule_Physics();
	RegisterModule_Physics();

	void RegisterModule_Physics2D();
	RegisterModule_Physics2D();

	void RegisterModule_RuntimeInitializeOnLoadManagerInitializer();
	RegisterModule_RuntimeInitializeOnLoadManagerInitializer();

	void RegisterModule_ScreenCapture();
	RegisterModule_ScreenCapture();

	void RegisterModule_SpriteMask();
	RegisterModule_SpriteMask();

	void RegisterModule_Subsystems();
	RegisterModule_Subsystems();

	void RegisterModule_Terrain();
	RegisterModule_Terrain();

	void RegisterModule_TextRendering();
	RegisterModule_TextRendering();

	void RegisterModule_TextCoreFontEngine();
	RegisterModule_TextCoreFontEngine();

	void RegisterModule_TextCoreTextEngine();
	RegisterModule_TextCoreTextEngine();

	void RegisterModule_Tilemap();
	RegisterModule_Tilemap();

	void RegisterModule_TLS();
	RegisterModule_TLS();

	void RegisterModule_UI();
	RegisterModule_UI();

	void RegisterModule_UIElementsNative();
	RegisterModule_UIElementsNative();

	void RegisterModule_UIElements();
	RegisterModule_UIElements();

	void RegisterModule_UnityAnalyticsCommon();
	RegisterModule_UnityAnalyticsCommon();

	void RegisterModule_UnityConnect();
	RegisterModule_UnityConnect();

	void RegisterModule_UnityWebRequest();
	RegisterModule_UnityWebRequest();

	void RegisterModule_UnityAnalytics();
	RegisterModule_UnityAnalytics();

	void RegisterModule_VFX();
	RegisterModule_VFX();

	void RegisterModule_Video();
	RegisterModule_Video();

	void RegisterModule_XR();
	RegisterModule_XR();

	void RegisterModule_VR();
	RegisterModule_VR();

}

template <typename T> void RegisterUnityClass(const char*);
template <typename T> void RegisterStrippedType(int, const char*, const char*);

void InvokeRegisterStaticallyLinkedModuleClasses()
{
	// Do nothing (we're in stripping mode)
}

class NavMeshAgent; template <> void RegisterUnityClass<NavMeshAgent>(const char*);
class NavMeshData; template <> void RegisterUnityClass<NavMeshData>(const char*);
class NavMeshObstacle; template <> void RegisterUnityClass<NavMeshObstacle>(const char*);
class NavMeshProjectSettings; template <> void RegisterUnityClass<NavMeshProjectSettings>(const char*);
class NavMeshSettings; template <> void RegisterUnityClass<NavMeshSettings>(const char*);
class Animation; template <> void RegisterUnityClass<Animation>(const char*);
class AnimationClip; template <> void RegisterUnityClass<AnimationClip>(const char*);
class Animator; template <> void RegisterUnityClass<Animator>(const char*);
class AnimatorController; template <> void RegisterUnityClass<AnimatorController>(const char*);
class AnimatorOverrideController; template <> void RegisterUnityClass<AnimatorOverrideController>(const char*);
class Avatar; template <> void RegisterUnityClass<Avatar>(const char*);
class AvatarMask; template <> void RegisterUnityClass<AvatarMask>(const char*);
class Behaviour; template <> void RegisterUnityClass<Behaviour>(const char*);
class IConstraint; template <> void RegisterUnityClass<IConstraint>(const char*);
class LookAtConstraint; template <> void RegisterUnityClass<LookAtConstraint>(const char*);
class Motion; template <> void RegisterUnityClass<Motion>(const char*);
class RuntimeAnimatorController; template <> void RegisterUnityClass<RuntimeAnimatorController>(const char*);
class AudioBehaviour; template <> void RegisterUnityClass<AudioBehaviour>(const char*);
class AudioClip; template <> void RegisterUnityClass<AudioClip>(const char*);
class AudioListener; template <> void RegisterUnityClass<AudioListener>(const char*);
class AudioManager; template <> void RegisterUnityClass<AudioManager>(const char*);
class AudioMixer; template <> void RegisterUnityClass<AudioMixer>(const char*);
class AudioMixerSnapshot; template <> void RegisterUnityClass<AudioMixerSnapshot>(const char*);
class AudioSource; template <> void RegisterUnityClass<AudioSource>(const char*);
class SampleClip; template <> void RegisterUnityClass<SampleClip>(const char*);
class BuildSettings; template <> void RegisterUnityClass<BuildSettings>(const char*);
class Camera; template <> void RegisterUnityClass<Camera>(const char*);
namespace Unity { class Component; } template <> void RegisterUnityClass<Unity::Component>(const char*);
class ComputeShader; template <> void RegisterUnityClass<ComputeShader>(const char*);
class Cubemap; template <> void RegisterUnityClass<Cubemap>(const char*);
class CubemapArray; template <> void RegisterUnityClass<CubemapArray>(const char*);
class DelayedCallManager; template <> void RegisterUnityClass<DelayedCallManager>(const char*);
class EditorExtension; template <> void RegisterUnityClass<EditorExtension>(const char*);
class FlareLayer; template <> void RegisterUnityClass<FlareLayer>(const char*);
class GameManager; template <> void RegisterUnityClass<GameManager>(const char*);
class GameObject; template <> void RegisterUnityClass<GameObject>(const char*);
class GlobalGameManager; template <> void RegisterUnityClass<GlobalGameManager>(const char*);
class GraphicsSettings; template <> void RegisterUnityClass<GraphicsSettings>(const char*);
class InputManager; template <> void RegisterUnityClass<InputManager>(const char*);
class LevelGameManager; template <> void RegisterUnityClass<LevelGameManager>(const char*);
class Light; template <> void RegisterUnityClass<Light>(const char*);
class LightingSettings; template <> void RegisterUnityClass<LightingSettings>(const char*);
class LightmapSettings; template <> void RegisterUnityClass<LightmapSettings>(const char*);
class LightProbes; template <> void RegisterUnityClass<LightProbes>(const char*);
class LowerResBlitTexture; template <> void RegisterUnityClass<LowerResBlitTexture>(const char*);
class Material; template <> void RegisterUnityClass<Material>(const char*);
class Mesh; template <> void RegisterUnityClass<Mesh>(const char*);
class MeshFilter; template <> void RegisterUnityClass<MeshFilter>(const char*);
class MeshRenderer; template <> void RegisterUnityClass<MeshRenderer>(const char*);
class MonoBehaviour; template <> void RegisterUnityClass<MonoBehaviour>(const char*);
class MonoManager; template <> void RegisterUnityClass<MonoManager>(const char*);
class MonoScript; template <> void RegisterUnityClass<MonoScript>(const char*);
class NamedObject; template <> void RegisterUnityClass<NamedObject>(const char*);
class Object; template <> void RegisterUnityClass<Object>(const char*);
class PlayerSettings; template <> void RegisterUnityClass<PlayerSettings>(const char*);
class PreloadData; template <> void RegisterUnityClass<PreloadData>(const char*);
class QualitySettings; template <> void RegisterUnityClass<QualitySettings>(const char*);
namespace UI { class RectTransform; } template <> void RegisterUnityClass<UI::RectTransform>(const char*);
class ReflectionProbe; template <> void RegisterUnityClass<ReflectionProbe>(const char*);
class Renderer; template <> void RegisterUnityClass<Renderer>(const char*);
class RenderSettings; template <> void RegisterUnityClass<RenderSettings>(const char*);
class RenderTexture; template <> void RegisterUnityClass<RenderTexture>(const char*);
class ResourceManager; template <> void RegisterUnityClass<ResourceManager>(const char*);
class RuntimeInitializeOnLoadManager; template <> void RegisterUnityClass<RuntimeInitializeOnLoadManager>(const char*);
class Shader; template <> void RegisterUnityClass<Shader>(const char*);
class ShaderNameRegistry; template <> void RegisterUnityClass<ShaderNameRegistry>(const char*);
class SkinnedMeshRenderer; template <> void RegisterUnityClass<SkinnedMeshRenderer>(const char*);
class SortingGroup; template <> void RegisterUnityClass<SortingGroup>(const char*);
class Sprite; template <> void RegisterUnityClass<Sprite>(const char*);
class SpriteAtlas; template <> void RegisterUnityClass<SpriteAtlas>(const char*);
class SpriteRenderer; template <> void RegisterUnityClass<SpriteRenderer>(const char*);
class TagManager; template <> void RegisterUnityClass<TagManager>(const char*);
class TextAsset; template <> void RegisterUnityClass<TextAsset>(const char*);
class Texture; template <> void RegisterUnityClass<Texture>(const char*);
class Texture2D; template <> void RegisterUnityClass<Texture2D>(const char*);
class Texture2DArray; template <> void RegisterUnityClass<Texture2DArray>(const char*);
class Texture3D; template <> void RegisterUnityClass<Texture3D>(const char*);
class TimeManager; template <> void RegisterUnityClass<TimeManager>(const char*);
class TrailRenderer; template <> void RegisterUnityClass<TrailRenderer>(const char*);
class Transform; template <> void RegisterUnityClass<Transform>(const char*);
class PlayableDirector; template <> void RegisterUnityClass<PlayableDirector>(const char*);
class Grid; template <> void RegisterUnityClass<Grid>(const char*);
class GridLayout; template <> void RegisterUnityClass<GridLayout>(const char*);
class ParticleSystem; template <> void RegisterUnityClass<ParticleSystem>(const char*);
class ParticleSystemRenderer; template <> void RegisterUnityClass<ParticleSystemRenderer>(const char*);
class BoxCollider; template <> void RegisterUnityClass<BoxCollider>(const char*);
class CapsuleCollider; template <> void RegisterUnityClass<CapsuleCollider>(const char*);
class CharacterController; template <> void RegisterUnityClass<CharacterController>(const char*);
namespace Unity { class CharacterJoint; } template <> void RegisterUnityClass<Unity::CharacterJoint>(const char*);
class Collider; template <> void RegisterUnityClass<Collider>(const char*);
namespace Unity { class Joint; } template <> void RegisterUnityClass<Unity::Joint>(const char*);
class MeshCollider; template <> void RegisterUnityClass<MeshCollider>(const char*);
class PhysicsManager; template <> void RegisterUnityClass<PhysicsManager>(const char*);
class Rigidbody; template <> void RegisterUnityClass<Rigidbody>(const char*);
class SphereCollider; template <> void RegisterUnityClass<SphereCollider>(const char*);
class AnchoredJoint2D; template <> void RegisterUnityClass<AnchoredJoint2D>(const char*);
class BoxCollider2D; template <> void RegisterUnityClass<BoxCollider2D>(const char*);
class CapsuleCollider2D; template <> void RegisterUnityClass<CapsuleCollider2D>(const char*);
class CircleCollider2D; template <> void RegisterUnityClass<CircleCollider2D>(const char*);
class Collider2D; template <> void RegisterUnityClass<Collider2D>(const char*);
class CompositeCollider2D; template <> void RegisterUnityClass<CompositeCollider2D>(const char*);
class DistanceJoint2D; template <> void RegisterUnityClass<DistanceJoint2D>(const char*);
class Effector2D; template <> void RegisterUnityClass<Effector2D>(const char*);
class HingeJoint2D; template <> void RegisterUnityClass<HingeJoint2D>(const char*);
class Joint2D; template <> void RegisterUnityClass<Joint2D>(const char*);
class Physics2DSettings; template <> void RegisterUnityClass<Physics2DSettings>(const char*);
class PhysicsMaterial2D; template <> void RegisterUnityClass<PhysicsMaterial2D>(const char*);
class PointEffector2D; template <> void RegisterUnityClass<PointEffector2D>(const char*);
class PolygonCollider2D; template <> void RegisterUnityClass<PolygonCollider2D>(const char*);
class Rigidbody2D; template <> void RegisterUnityClass<Rigidbody2D>(const char*);
class SpriteMask; template <> void RegisterUnityClass<SpriteMask>(const char*);
class Terrain; template <> void RegisterUnityClass<Terrain>(const char*);
class TerrainData; template <> void RegisterUnityClass<TerrainData>(const char*);
namespace TextRendering { class Font; } template <> void RegisterUnityClass<TextRendering::Font>(const char*);
namespace TextRenderingPrivate { class TextMesh; } template <> void RegisterUnityClass<TextRenderingPrivate::TextMesh>(const char*);
class Tilemap; template <> void RegisterUnityClass<Tilemap>(const char*);
class TilemapRenderer; template <> void RegisterUnityClass<TilemapRenderer>(const char*);
namespace UI { class Canvas; } template <> void RegisterUnityClass<UI::Canvas>(const char*);
namespace UI { class CanvasGroup; } template <> void RegisterUnityClass<UI::CanvasGroup>(const char*);
namespace UI { class CanvasRenderer; } template <> void RegisterUnityClass<UI::CanvasRenderer>(const char*);
class UnityConnectSettings; template <> void RegisterUnityClass<UnityConnectSettings>(const char*);
class VFXManager; template <> void RegisterUnityClass<VFXManager>(const char*);
class VisualEffect; template <> void RegisterUnityClass<VisualEffect>(const char*);
class VisualEffectAsset; template <> void RegisterUnityClass<VisualEffectAsset>(const char*);
class VisualEffectObject; template <> void RegisterUnityClass<VisualEffectObject>(const char*);
class VideoPlayer; template <> void RegisterUnityClass<VideoPlayer>(const char*);

void RegisterAllClasses()
{
void RegisterBuiltinTypes();
RegisterBuiltinTypes();
	//Total: 126 non stripped classes
	//0. NavMeshAgent
	RegisterUnityClass<NavMeshAgent>("AI");
	//1. NavMeshData
	RegisterUnityClass<NavMeshData>("AI");
	//2. NavMeshObstacle
	RegisterUnityClass<NavMeshObstacle>("AI");
	//3. NavMeshProjectSettings
	RegisterUnityClass<NavMeshProjectSettings>("AI");
	//4. NavMeshSettings
	RegisterUnityClass<NavMeshSettings>("AI");
	//5. Animation
	RegisterUnityClass<Animation>("Animation");
	//6. AnimationClip
	RegisterUnityClass<AnimationClip>("Animation");
	//7. Animator
	RegisterUnityClass<Animator>("Animation");
	//8. AnimatorController
	RegisterUnityClass<AnimatorController>("Animation");
	//9. AnimatorOverrideController
	RegisterUnityClass<AnimatorOverrideController>("Animation");
	//10. Avatar
	RegisterUnityClass<Avatar>("Animation");
	//11. AvatarMask
	RegisterUnityClass<AvatarMask>("Animation");
	//12. Behaviour
	RegisterUnityClass<Behaviour>("Core");
	//13. IConstraint
	RegisterUnityClass<IConstraint>("Animation");
	//14. LookAtConstraint
	RegisterUnityClass<LookAtConstraint>("Animation");
	//15. Motion
	RegisterUnityClass<Motion>("Animation");
	//16. RuntimeAnimatorController
	RegisterUnityClass<RuntimeAnimatorController>("Animation");
	//17. AudioBehaviour
	RegisterUnityClass<AudioBehaviour>("Audio");
	//18. AudioClip
	RegisterUnityClass<AudioClip>("Audio");
	//19. AudioListener
	RegisterUnityClass<AudioListener>("Audio");
	//20. AudioManager
	RegisterUnityClass<AudioManager>("Audio");
	//21. AudioMixer
	RegisterUnityClass<AudioMixer>("Audio");
	//22. AudioMixerSnapshot
	RegisterUnityClass<AudioMixerSnapshot>("Audio");
	//23. AudioSource
	RegisterUnityClass<AudioSource>("Audio");
	//24. SampleClip
	RegisterUnityClass<SampleClip>("Audio");
	//25. BuildSettings
	RegisterUnityClass<BuildSettings>("Core");
	//26. Camera
	RegisterUnityClass<Camera>("Core");
	//27. Component
	RegisterUnityClass<Unity::Component>("Core");
	//28. ComputeShader
	RegisterUnityClass<ComputeShader>("Core");
	//29. Cubemap
	RegisterUnityClass<Cubemap>("Core");
	//30. CubemapArray
	RegisterUnityClass<CubemapArray>("Core");
	//31. DelayedCallManager
	RegisterUnityClass<DelayedCallManager>("Core");
	//32. EditorExtension
	RegisterUnityClass<EditorExtension>("Core");
	//33. FlareLayer
	RegisterUnityClass<FlareLayer>("Core");
	//34. GameManager
	RegisterUnityClass<GameManager>("Core");
	//35. GameObject
	RegisterUnityClass<GameObject>("Core");
	//36. GlobalGameManager
	RegisterUnityClass<GlobalGameManager>("Core");
	//37. GraphicsSettings
	RegisterUnityClass<GraphicsSettings>("Core");
	//38. InputManager
	RegisterUnityClass<InputManager>("Core");
	//39. LevelGameManager
	RegisterUnityClass<LevelGameManager>("Core");
	//40. Light
	RegisterUnityClass<Light>("Core");
	//41. LightingSettings
	RegisterUnityClass<LightingSettings>("Core");
	//42. LightmapSettings
	RegisterUnityClass<LightmapSettings>("Core");
	//43. LightProbes
	RegisterUnityClass<LightProbes>("Core");
	//44. LowerResBlitTexture
	RegisterUnityClass<LowerResBlitTexture>("Core");
	//45. Material
	RegisterUnityClass<Material>("Core");
	//46. Mesh
	RegisterUnityClass<Mesh>("Core");
	//47. MeshFilter
	RegisterUnityClass<MeshFilter>("Core");
	//48. MeshRenderer
	RegisterUnityClass<MeshRenderer>("Core");
	//49. MonoBehaviour
	RegisterUnityClass<MonoBehaviour>("Core");
	//50. MonoManager
	RegisterUnityClass<MonoManager>("Core");
	//51. MonoScript
	RegisterUnityClass<MonoScript>("Core");
	//52. NamedObject
	RegisterUnityClass<NamedObject>("Core");
	//53. Object
	//Skipping Object
	//54. PlayerSettings
	RegisterUnityClass<PlayerSettings>("Core");
	//55. PreloadData
	RegisterUnityClass<PreloadData>("Core");
	//56. QualitySettings
	RegisterUnityClass<QualitySettings>("Core");
	//57. RectTransform
	RegisterUnityClass<UI::RectTransform>("Core");
	//58. ReflectionProbe
	RegisterUnityClass<ReflectionProbe>("Core");
	//59. Renderer
	RegisterUnityClass<Renderer>("Core");
	//60. RenderSettings
	RegisterUnityClass<RenderSettings>("Core");
	//61. RenderTexture
	RegisterUnityClass<RenderTexture>("Core");
	//62. ResourceManager
	RegisterUnityClass<ResourceManager>("Core");
	//63. RuntimeInitializeOnLoadManager
	RegisterUnityClass<RuntimeInitializeOnLoadManager>("Core");
	//64. Shader
	RegisterUnityClass<Shader>("Core");
	//65. ShaderNameRegistry
	RegisterUnityClass<ShaderNameRegistry>("Core");
	//66. SkinnedMeshRenderer
	RegisterUnityClass<SkinnedMeshRenderer>("Core");
	//67. SortingGroup
	RegisterUnityClass<SortingGroup>("Core");
	//68. Sprite
	RegisterUnityClass<Sprite>("Core");
	//69. SpriteAtlas
	RegisterUnityClass<SpriteAtlas>("Core");
	//70. SpriteRenderer
	RegisterUnityClass<SpriteRenderer>("Core");
	//71. TagManager
	RegisterUnityClass<TagManager>("Core");
	//72. TextAsset
	RegisterUnityClass<TextAsset>("Core");
	//73. Texture
	RegisterUnityClass<Texture>("Core");
	//74. Texture2D
	RegisterUnityClass<Texture2D>("Core");
	//75. Texture2DArray
	RegisterUnityClass<Texture2DArray>("Core");
	//76. Texture3D
	RegisterUnityClass<Texture3D>("Core");
	//77. TimeManager
	RegisterUnityClass<TimeManager>("Core");
	//78. TrailRenderer
	RegisterUnityClass<TrailRenderer>("Core");
	//79. Transform
	RegisterUnityClass<Transform>("Core");
	//80. PlayableDirector
	RegisterUnityClass<PlayableDirector>("Director");
	//81. Grid
	RegisterUnityClass<Grid>("Grid");
	//82. GridLayout
	RegisterUnityClass<GridLayout>("Grid");
	//83. ParticleSystem
	RegisterUnityClass<ParticleSystem>("ParticleSystem");
	//84. ParticleSystemRenderer
	RegisterUnityClass<ParticleSystemRenderer>("ParticleSystem");
	//85. BoxCollider
	RegisterUnityClass<BoxCollider>("Physics");
	//86. CapsuleCollider
	RegisterUnityClass<CapsuleCollider>("Physics");
	//87. CharacterController
	RegisterUnityClass<CharacterController>("Physics");
	//88. CharacterJoint
	RegisterUnityClass<Unity::CharacterJoint>("Physics");
	//89. Collider
	RegisterUnityClass<Collider>("Physics");
	//90. Joint
	RegisterUnityClass<Unity::Joint>("Physics");
	//91. MeshCollider
	RegisterUnityClass<MeshCollider>("Physics");
	//92. PhysicsManager
	RegisterUnityClass<PhysicsManager>("Physics");
	//93. Rigidbody
	RegisterUnityClass<Rigidbody>("Physics");
	//94. SphereCollider
	RegisterUnityClass<SphereCollider>("Physics");
	//95. AnchoredJoint2D
	RegisterUnityClass<AnchoredJoint2D>("Physics2D");
	//96. BoxCollider2D
	RegisterUnityClass<BoxCollider2D>("Physics2D");
	//97. CapsuleCollider2D
	RegisterUnityClass<CapsuleCollider2D>("Physics2D");
	//98. CircleCollider2D
	RegisterUnityClass<CircleCollider2D>("Physics2D");
	//99. Collider2D
	RegisterUnityClass<Collider2D>("Physics2D");
	//100. CompositeCollider2D
	RegisterUnityClass<CompositeCollider2D>("Physics2D");
	//101. DistanceJoint2D
	RegisterUnityClass<DistanceJoint2D>("Physics2D");
	//102. Effector2D
	RegisterUnityClass<Effector2D>("Physics2D");
	//103. HingeJoint2D
	RegisterUnityClass<HingeJoint2D>("Physics2D");
	//104. Joint2D
	RegisterUnityClass<Joint2D>("Physics2D");
	//105. Physics2DSettings
	RegisterUnityClass<Physics2DSettings>("Physics2D");
	//106. PhysicsMaterial2D
	RegisterUnityClass<PhysicsMaterial2D>("Physics2D");
	//107. PointEffector2D
	RegisterUnityClass<PointEffector2D>("Physics2D");
	//108. PolygonCollider2D
	RegisterUnityClass<PolygonCollider2D>("Physics2D");
	//109. Rigidbody2D
	RegisterUnityClass<Rigidbody2D>("Physics2D");
	//110. SpriteMask
	RegisterUnityClass<SpriteMask>("SpriteMask");
	//111. Terrain
	RegisterUnityClass<Terrain>("Terrain");
	//112. TerrainData
	RegisterUnityClass<TerrainData>("Terrain");
	//113. Font
	RegisterUnityClass<TextRendering::Font>("TextRendering");
	//114. TextMesh
	RegisterUnityClass<TextRenderingPrivate::TextMesh>("TextRendering");
	//115. Tilemap
	RegisterUnityClass<Tilemap>("Tilemap");
	//116. TilemapRenderer
	RegisterUnityClass<TilemapRenderer>("Tilemap");
	//117. Canvas
	RegisterUnityClass<UI::Canvas>("UI");
	//118. CanvasGroup
	RegisterUnityClass<UI::CanvasGroup>("UI");
	//119. CanvasRenderer
	RegisterUnityClass<UI::CanvasRenderer>("UI");
	//120. UnityConnectSettings
	RegisterUnityClass<UnityConnectSettings>("UnityConnect");
	//121. VFXManager
	RegisterUnityClass<VFXManager>("VFX");
	//122. VisualEffect
	RegisterUnityClass<VisualEffect>("VFX");
	//123. VisualEffectAsset
	RegisterUnityClass<VisualEffectAsset>("VFX");
	//124. VisualEffectObject
	RegisterUnityClass<VisualEffectObject>("VFX");
	//125. VideoPlayer
	RegisterUnityClass<VideoPlayer>("Video");

}
