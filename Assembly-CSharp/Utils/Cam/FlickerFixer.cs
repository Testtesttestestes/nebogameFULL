using System;
using Il2CppDummyDll;
using UI.SkinsV2;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Utils.Cam
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	public class FlickerFixer : MonoBehaviour
	{
		// Token: 0x0600034F RID: 847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x57AE", Offset = "0x57AE", VA = "0x57AE")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Utils_Cam_FlickerFixer__OnDestroy(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6284b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cam_FlickerFixer_SceneManagerOnSceneLoaded__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cam_FlickerFixer_SceneManagerOnSceneUnloaded__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_SceneManagement_SceneManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_Scene__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_Scene__LoadSceneMode__TypeInfo);
		    DAT_ram_00a6284b = '\x01';
		  }
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_Scene__TypeInfo);
		  UnityEngine_Events_UnityAction_object___Invoke
		            (uVar1,param1,Method_Utils_Cam_FlickerFixer_SceneManagerOnSceneUnloaded__,0);
		  if (*(int *)(UnityEngine_SceneManagement_SceneManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_SceneManagement_SceneManager_TypeInfo);
		  }
		  UnityEngine_SceneManagement_SceneManager__remove_sceneLoaded(uVar1,0);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_Scene__LoadSceneMode__TypeInfo);
		  UnityEngine_Events_UnityAction_InputAction_CallbackContext___Invoke
		            (uVar1,param1,Method_Utils_Cam_FlickerFixer_SceneManagerOnSceneLoaded__,0);
		  UnityEngine_SceneManagement_SceneManager__LoadFirstScene_Internal(uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000350 RID: 848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x57AF", Offset = "0x57AF", VA = "0x57AF")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Utils_Cam_FlickerFixer__Awake
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Utils_Cam_FlickerFixer__SceneManagerOnSceneUnloaded(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000351 RID: 849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x57B0", Offset = "0x57B0", VA = "0x57B0")]
		private void SceneManagerOnSceneLoaded(Scene scene, LoadSceneMode arg1)
		{
		/* --- GHIDRA: SceneManagerOnSceneLoaded ---
		void Utils_Cam_FlickerFixer__SceneManagerOnSceneLoaded
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Utils_Cam_FlickerFixer__SceneManagerOnSceneUnloaded(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000352 RID: 850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x57B1", Offset = "0x57B1", VA = "0x57B1")]
		private void SceneManagerOnSceneUnloaded(Scene scene)
		{
		/* --- GHIDRA: SceneManagerOnSceneUnloaded ---
		void Utils_Cam_FlickerFixer__SceneManagerOnSceneUnloaded(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint param2_00;
		  
		  if (DAT_ram_00a6284c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_SkinsV2_AbstractSkinResolver_RawImage__Texture__Resolve__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a6284c = '\x01';
		  }
		  if (DAT_ram_00a6284d == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_Cache_CameraMainCache_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a6284d = '\x01';
		  }
		  uVar3 = **(undefined4 **)(Utils_Cache_CameraMainCache_TypeInfo + 0x5c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(uVar3,0,0);
		  if (iVar1 != 0) {
		    uVar3 = UnityEngine_Camera__CalculateFrustumCorners(0);
		    **(undefined4 **)(Utils_Cache_CameraMainCache_TypeInfo + 0x5c) = uVar3;
		  }
		  uVar3 = **(undefined4 **)(Utils_Cache_CameraMainCache_TypeInfo + 0x5c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar2 = UnityEngine_Component__GetComponent_object_(uVar3,0);
		  param2_00 = uVar2 ^ 1;
		  UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x10),param2_00,0);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,param2_00,0);
		  UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x18),param2_00,0);
		  if (uVar2 == 0) {
		    UI_SkinsV2_AbstractSkinResolver_object__object___OnEnable
		              (*(undefined4 *)(param1 + 0x18),
		               Method_UI_SkinsV2_AbstractSkinResolver_RawImage__Texture__Resolve__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000353 RID: 851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x57B2", Offset = "0x57B2", VA = "0x57B2")]
		private void HandleLoading()
		{
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x57B3", Offset = "0x57B3", VA = "0x57B3")]
		public FlickerFixer()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Utils_Cam_FlickerFixer___ctor(undefined4 param1)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a6284d == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_Cache_CameraMainCache_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a6284d = '\x01';
		  }
		  uVar2 = **(undefined4 **)(Utils_Cache_CameraMainCache_TypeInfo + 0x5c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(uVar2,0,0);
		  if (iVar1 != 0) {
		    uVar2 = UnityEngine_Camera__CalculateFrustumCorners(0);
		    **(undefined4 **)(Utils_Cache_CameraMainCache_TypeInfo + 0x5c) = uVar2;
		  }
		  return **(undefined4 **)(Utils_Cache_CameraMainCache_TypeInfo + 0x5c);
		}
		*/

		}

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Camera _camera;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _stub;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RawImageSkinResolver _skinResolver;
	}
}
