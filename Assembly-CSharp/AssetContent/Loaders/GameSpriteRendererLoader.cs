using System;
using System.Runtime.CompilerServices;
using Core;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace AssetContent.Loaders
{
	// Token: 0x02000E34 RID: 3636
	[Token(Token = "0x2000E34")]
	[RequireComponent(typeof(SpriteRenderer))]
	[DisallowMultipleComponent]
	public class GameSpriteRendererLoader : MonoBehaviour, IAsyncLoadableContent, IGameAssetContent
	{
		// Token: 0x14000218 RID: 536
		// (add) Token: 0x0600590D RID: 22797 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600590E RID: 22798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000218")]
		public event Action<IAsyncLoadableContent> ReadyEvent
		{
			[Token(Token = "0x600590D")]
			[Address(RVA = "0xA661", Offset = "0xA661", VA = "0xA661", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600590E")]
			[Address(RVA = "0xA662", Offset = "0xA662", VA = "0xA662", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x0600590F RID: 22799 RVA: 0x0000FD50 File Offset: 0x0000DF50
		// (set) Token: 0x06005910 RID: 22800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001223")]
		public bool IsReady
		{
			[Token(Token = "0x600590F")]
			[Address(RVA = "0xA663", Offset = "0xA663", VA = "0xA663", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005910")]
			[Address(RVA = "0xA664", Offset = "0xA664", VA = "0xA664")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x06005911 RID: 22801 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001224")]
		private MaterialPropertyBlock MaterialPropertyBlock
		{
			[Token(Token = "0x6005911")]
			[Address(RVA = "0xA665", Offset = "0xA665", VA = "0xA665")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x06005912 RID: 22802 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001225")]
		public SpriteRenderer SpriteRenderer
		{
			[Token(Token = "0x6005912")]
			[Address(RVA = "0x1DFB", Offset = "0x1DFB", VA = "0x1DFB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x06005913 RID: 22803 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005914 RID: 22804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001226")]
		public string AssetId
		{
			[Token(Token = "0x6005913")]
			[Address(RVA = "0xA666", Offset = "0xA666", VA = "0xA666", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005914")]
			[Address(RVA = "0xA667", Offset = "0xA667", VA = "0xA667", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x06005915 RID: 22805 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005916 RID: 22806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001227")]
		public string AssetPath
		{
			[Token(Token = "0x6005915")]
			[Address(RVA = "0xA668", Offset = "0xA668", VA = "0xA668", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005916")]
			[Address(RVA = "0xA669", Offset = "0xA669", VA = "0xA669")]
			set
			{
			}
		}

		// Token: 0x06005917 RID: 22807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005917")]
		[Address(RVA = "0xA66A", Offset = "0xA66A", VA = "0xA66A")]
		private void SetAssetPath(string value)
		{
		/* --- GHIDRA: SetAssetPath ---
		void AssetContent_Loaders_GameSpriteRendererLoader__SetAssetPath
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63bff == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_346);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8431);
		    DAT_ram_00a63bff = '\x01';
		  }
		  param1_00 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                        (StringLiteral_8431,*(undefined4 *)(param1 + 0x1c),StringLiteral_346,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06005918 RID: 22808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005918")]
		[Address(RVA = "0xA66B", Offset = "0xA66B", VA = "0xA66B")]
		private void FailCallback(string resourceUrl)
		{
		/* --- GHIDRA: FailCallback ---
		void AssetContent_Loaders_GameSpriteRendererLoader__FailCallback
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63c00 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Color__Color__ColorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Color__Color__ColorOptions____
		              );
		    DAT_ram_00a63c00 = '\x01';
		  }
		  if (((char)param1[8] == '\0') &&
		     (iVar1 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                        (param3,param1[7],0), iVar1 == 0)) {
		    if (DAT_ram_00a63bfc == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		      DAT_ram_00a63bfc = '\x01';
		    }
		    if (param1[0xb] == 0) {
		      iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		      param1[0xb] = iVar1;
		    }
		    else {
		      iVar1 = param1[0xb];
		    }
		    Core_Extensions_SpriteAtlasExt__TryGetSprite(iVar1,param2,0);
		    if ((float)param1[4] <= 0.0) {
		      if (DAT_ram_00a63bfc == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		        DAT_ram_00a63bfc = '\x01';
		      }
		      if (param1[0xb] == 0) {
		        iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		        param1[0xb] = iVar1;
		      }
		      else {
		        iVar1 = param1[0xb];
		      }
		      local_8 = 0x3f8000003f800000;
		      local_18 = 0x3f8000003f800000;
		      local_10 = 0x3f8000003f800000;
		      local_20 = 0x3f8000003f800000;
		      UnityEngine_SpriteRenderer__get_color(iVar1,&local_20,0);
		    }
		    else {
		      if (param1[9] != 0) {
		        func_ii_7891(param1[9],0,0);
		      }
		      if (DAT_ram_00a63bfc == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		        DAT_ram_00a63bfc = '\x01';
		      }
		      if (param1[0xb] == 0) {
		        iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		        param1[0xb] = iVar1;
		      }
		      else {
		        iVar1 = param1[0xb];
		      }
		      uVar2 = DG_Tweening_DOTweenModuleSprite__DOColor(iVar1,1.0,(float)param1[4],0);
		      uVar2 = DG_Tweening_ShortcutExtensions__DOScale
		                        (uVar2,9,
		                         Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Color__Color__ColorOptions____
		                        );
		      if (DAT_ram_00a63bfc == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		        DAT_ram_00a63bfc = '\x01';
		      }
		      if (param1[0xb] == 0) {
		        iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		        param1[0xb] = iVar1;
		      }
		      else {
		        iVar1 = param1[0xb];
		      }
		      param2_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (iVar1,0);
		      iVar1 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                        (uVar2,param2_00,
		                         Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Color__Color__ColorOptions____
		                        );
		      param1[9] = iVar1;
		    }
		    *(undefined1 *)(param1 + 0xc) = 1;
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		              (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = param1[5];
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005919 RID: 22809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005919")]
		[Address(RVA = "0xA66C", Offset = "0xA66C", VA = "0xA66C")]
		private void CompleteCallback(Sprite sprite, string resourceUrl)
		{
		/* --- GHIDRA: CompleteCallback ---
		void AssetContent_Loaders_GameSpriteRendererLoader__CompleteCallback(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (*(char *)(param1 + 0x20) == '\0') {
		    if (DAT_ram_00a63bfc == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		      DAT_ram_00a63bfc = '\x01';
		    }
		    if (*(int *)(param1 + 0x2c) == 0) {
		      uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		      *(undefined4 *)(param1 + 0x2c) = uVar1;
		    }
		    else {
		      uVar1 = *(undefined4 *)(param1 + 0x2c);
		    }
		    iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		    if (iVar2 != 0) {
		      if (DAT_ram_00a63bfc == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		        DAT_ram_00a63bfc = '\x01';
		      }
		      if (*(int *)(param1 + 0x2c) == 0) {
		        uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		        *(undefined4 *)(param1 + 0x2c) = uVar1;
		      }
		      else {
		        uVar1 = *(undefined4 *)(param1 + 0x2c);
		      }
		      Core_Extensions_SpriteAtlasExt__TryGetSprite(uVar1,0,0);
		      if (*(int *)(param1 + 0x24) != 0) {
		        func_ii_7891(*(int *)(param1 + 0x24),0,0);
		      }
		    }
		    AssetContent_Loaders_GameSpriteRendererLoader__set_AssetPath(param1,0,param1);
		    *(undefined1 *)(param1 + 0x20) = 1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600591A RID: 22810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600591A")]
		[Address(RVA = "0xA66D", Offset = "0xA66D", VA = "0xA66D")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600591B RID: 22811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600591B")]
		[Address(RVA = "0xA66E", Offset = "0xA66E", VA = "0xA66E", Slot = "10")]
		protected virtual void HandleSpriteChanged()
		{
		/* --- GHIDRA: HandleSpriteChanged ---
		void AssetContent_Loaders_GameSpriteRendererLoader__HandleSpriteChanged
		               (int param1,float param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63c01 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo);
		    DAT_ram_00a63c01 = '\x01';
		  }
		  param1_00 = AssetContent_Loaders_GameSpriteRendererLoader__set_IsReady(param1,param1);
		  if (*(int *)(Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo);
		  }
		  UnityEngine_MaterialPropertyBlock__Dispose
		            (param1_00,
		             *(undefined4 *)
		              (*(int *)(Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo + 0x5c) + 4),param2,0);
		  if (DAT_ram_00a63bfc == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		    DAT_ram_00a63bfc = '\x01';
		  }
		  if (*(int *)(param1 + 0x2c) == 0) {
		    param1_01 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		    *(undefined4 *)(param1 + 0x2c) = param1_01;
		  }
		  else {
		    param1_01 = *(undefined4 *)(param1 + 0x2c);
		  }
		  UnityEngine_Renderer__HasPropertyBlock(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600591C RID: 22812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600591C")]
		[Address(RVA = "0xA66F", Offset = "0xA66F", VA = "0xA66F", Slot = "11")]
		public void SetGrayscale(float value)
		{
		}

		// Token: 0x0600591D RID: 22813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600591D")]
		[Address(RVA = "0xA670", Offset = "0xA670", VA = "0xA670")]
		public GameSpriteRendererLoader()
		{
		/* --- GHIDRA: .ctor ---
		void AssetContent_Loaders_GameSpriteRendererLoader___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a63c02 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63c02 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x34,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04003015 RID: 12309
		[Token(Token = "0x4003015")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _fadeInDuration;

		// Token: 0x04003017 RID: 12311
		[Token(Token = "0x4003017")]
		[FieldOffset(Offset = "0x18")]
		private string _assetId;

		// Token: 0x04003018 RID: 12312
		[Token(Token = "0x4003018")]
		[FieldOffset(Offset = "0x1C")]
		private string _assetPath;

		// Token: 0x04003019 RID: 12313
		[Token(Token = "0x4003019")]
		[FieldOffset(Offset = "0x20")]
		protected bool _isDestroyed;

		// Token: 0x0400301A RID: 12314
		[Token(Token = "0x400301A")]
		[FieldOffset(Offset = "0x24")]
		private Tween _colorTween;

		// Token: 0x0400301B RID: 12315
		[Token(Token = "0x400301B")]
		[FieldOffset(Offset = "0x28")]
		private MaterialPropertyBlock _materialPropertyBlock;

		// Token: 0x0400301C RID: 12316
		[Token(Token = "0x400301C")]
		[FieldOffset(Offset = "0x2C")]
		protected SpriteRenderer _spriteRenderer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ReadyEvent ---
		void AssetContent_Loaders_GameSpriteRendererLoader__add_ReadyEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63bfa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    DAT_ram_00a63bfa = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IAsyncLoadableContent__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAsyncLoadableContent__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_IsReady ---
		undefined4 AssetContent_Loaders_GameSpriteRendererLoader__set_IsReady(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63bfb == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_MaterialPropertyBlock_TypeInfo);
		    DAT_ram_00a63bfb = '\x01';
		  }
		  if (*(int *)(param1 + 0x28) == 0) {
		    uVar1 = unnamed_function_1417(UnityEngine_MaterialPropertyBlock_TypeInfo);
		    UnityEngine_MaterialPropertyBlock__SetVectorArray(uVar1,0);
		    *(undefined4 *)(param1 + 0x28) = uVar1;
		  }
		  if (DAT_ram_00a63bfc == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		    DAT_ram_00a63bfc = '\x01';
		  }
		  if (*(int *)(param1 + 0x2c) == 0) {
		    uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		    *(undefined4 *)(param1 + 0x2c) = uVar1;
		  }
		  else {
		    uVar1 = *(undefined4 *)(param1 + 0x2c);
		  }
		  UnityEngine_Renderer__SetPropertyBlock(uVar1,*(undefined4 *)(param1 + 0x28),0);
		  return *(undefined4 *)(param1 + 0x28);
		}
		*/


		/* --- GHIDRA: get_SpriteRenderer ---
		void AssetContent_Loaders_GameSpriteRendererLoader__get_SpriteRenderer
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a6242b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_MarshalledUnityObject_MarshalNotNull_Renderer___);
		    DAT_ram_00a6242b = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 8);
		  if (iVar1 == 0) {
		    System_Collections_Generic_ArraySortHelper_AppBuildInfo_Element___InternalBinarySearch(param1,0)
		    ;
		  }
		  if (DAT_ram_00a624a0 == 0) {
		    DAT_ram_00a624a0 = func_ii_2140(s_UnityEngine_Renderer__set_sortin_ram_0006e9d2);
		  }
		  (**(code **)((ulonglong)DAT_ram_00a624a0 * 4))(iVar1,param2);
		  return;
		}
		*/


		/* --- GHIDRA: get_AssetId ---
		void AssetContent_Loaders_GameSpriteRendererLoader__get_AssetId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *param3_00;
		  undefined4 uVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a63bfd == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a63bfd = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = param2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        param3_00 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x178);
		        goto code_r0x82369be4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  param3_00 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x82369be4:
		  uVar2 = (**(code **)((ulonglong)*param3_00 * 4))(param1_00,param3_00[1]);
		  uVar2 = Core_Extensions_Dict_GameFieldGemSetsDicExt__GetGemsSpriteAtlasAssetId
		                    (uVar2,*(undefined4 *)(param1 + 0x18),0);
		  AssetContent_Loaders_GameSpriteRendererLoader__set_AssetPath(param1,uVar2,param3_00);
		  return;
		}
		*/


		/* --- GHIDRA: get_AssetPath ---
		void AssetContent_Loaders_GameSpriteRendererLoader__get_AssetPath
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x18) = 0;
		  AssetContent_Loaders_GameSpriteRendererLoader__set_AssetPath(param1,param2,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_AssetPath ---
		void AssetContent_Loaders_GameSpriteRendererLoader__set_AssetPath
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63bfe == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourcesManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_Loaders_GameSpriteRendererLoader_CompleteCallback__);
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_Loaders_GameSpriteRendererLoader_FailCallback__);
		    Mono_Security_ASN1__get_Item
		              (&Core_GameResources_GameResourcesManager_ResourceFailedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_GameResources_GameResourcesManager_SpriteReadyDelegate_TypeInfo);
		    DAT_ram_00a63bfe = '\x01';
		  }
		  iVar1 = System_Collections_CollectionBase___ctor(param1[7],param2,0);
		  if (iVar1 == 0) {
		    iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                      (param1[7],0);
		    if (iVar1 == 0) {
		      iVar1 = param1[7];
		      if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameResources_GameResourcesManager_TypeInfo);
		      }
		      Core_GameResources_GameResourcesManager__ReleaseAudioClip(iVar1,0);
		    }
		    *(undefined1 *)(param1 + 0xc) = 0;
		    param1[7] = param2;
		    if (DAT_ram_00a63bfc == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		      DAT_ram_00a63bfc = '\x01';
		    }
		    if (param1[0xb] == 0) {
		      iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		      param1[0xb] = iVar1;
		    }
		    else {
		      iVar1 = param1[0xb];
		    }
		    local_8 = 0x3f800000;
		    local_18 = 0x3f800000;
		    local_10 = 0x3f8000003f800000;
		    local_20 = 0x3f8000003f800000;
		    UnityEngine_SpriteRenderer__get_color(iVar1,&local_20,0);
		    if (param1[9] != 0) {
		      func_ii_7891(param1[9],0,0);
		    }
		    iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                      (param1[7],0);
		    if (iVar1 == 0) {
		      uVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                        (param1[6],0);
		      iVar1 = param1[7];
		      param1_00 = unnamed_function_1417
		                            (Core_GameResources_GameResourcesManager_SpriteReadyDelegate_TypeInfo);
		      Core_GameResources_GameResourcesManager_TextureReadyDelegate__EndInvoke
		                (param1_00,param1,
		                 Method_AssetContent_Loaders_GameSpriteRendererLoader_CompleteCallback__,0);
		      param1_01 = unnamed_function_1417
		                            (Core_GameResources_GameResourcesManager_ResourceFailedDelegate_TypeInfo
		                            );
		      Core_GameResources_GameResourcesManager_SpriteAtlasReadyDelegate___ctor
		                (param1_01,param1,
		                 Method_AssetContent_Loaders_GameSpriteRendererLoader_FailCallback__,0);
		      if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameResources_GameResourcesManager_TypeInfo);
		      }
		      Core_GameResources_GameResourcesManager__ReleaseTexture(iVar1,param1_00,param1_01,uVar2 ^ 1,0)
		      ;
		    }
		    else {
		      if (DAT_ram_00a63bfc == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		        DAT_ram_00a63bfc = '\x01';
		      }
		      if (param1[0xb] == 0) {
		        iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		        param1[0xb] = iVar1;
		      }
		      else {
		        iVar1 = param1[0xb];
		      }
		      Core_Extensions_SpriteAtlasExt__TryGetSprite(iVar1,0,0);
		      (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                (param1,*(undefined4 *)(*param1 + 0x114));
		    }
		  }
		  return;
		}
		*/

}
