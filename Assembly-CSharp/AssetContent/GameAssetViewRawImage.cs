using System;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Core;
using Core.Materials;
using DG.Tweening;
using Il2CppDummyDll;
using Protocol.Dic;
using UI;
using UnityEngine;

namespace AssetContent
{
	// Token: 0x02000E2A RID: 3626
	[Token(Token = "0x2000E2A")]
	public class GameAssetViewRawImage : MonoBehaviour, IAsyncLoadableContent, IGameAssetContent, IRectProvider, IGrayscalable
	{
		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x060058AA RID: 22698 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700120B")]
		public GameAnimationView GameAnimationView
		{
			[Token(Token = "0x60058AA")]
			[Address(RVA = "0xA615", Offset = "0xA615", VA = "0xA615")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x060058AB RID: 22699 RVA: 0x0000FC18 File Offset: 0x0000DE18
		[Token(Token = "0x1700120C")]
		public bool IsReady
		{
			[Token(Token = "0x60058AB")]
			[Address(RVA = "0xA616", Offset = "0xA616", VA = "0xA616", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000213 RID: 531
		// (add) Token: 0x060058AC RID: 22700 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060058AD RID: 22701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000213")]
		public event Action<IAsyncLoadableContent> ReadyEvent
		{
			[Token(Token = "0x60058AC")]
			[Address(RVA = "0xA617", Offset = "0xA617", VA = "0xA617", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60058AD")]
			[Address(RVA = "0xA618", Offset = "0xA618", VA = "0xA618", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060058AE RID: 22702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058AE")]
		[Address(RVA = "0xA619", Offset = "0xA619", VA = "0xA619")]
		private void Awake()
		{
		}

		// Token: 0x060058AF RID: 22703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058AF")]
		[Address(RVA = "0xA61A", Offset = "0xA61A", VA = "0xA61A")]
		private void GameAnimationViewOnReadyEvent(IAsyncLoadableContent obj)
		{
		}

		// Token: 0x060058B0 RID: 22704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058B0")]
		[Address(RVA = "0xA61B", Offset = "0xA61B", VA = "0xA61B")]
		private void GameRawImageLoaderOnReadyEvent(IAsyncLoadableContent obj)
		{
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x060058B1 RID: 22705 RVA: 0x0000FC30 File Offset: 0x0000DE30
		// (set) Token: 0x060058B2 RID: 22706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700120D")]
		public bool Interactable
		{
			[Token(Token = "0x60058B1")]
			[Address(RVA = "0xA61C", Offset = "0xA61C", VA = "0xA61C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60058B2")]
			[Address(RVA = "0xA61D", Offset = "0xA61D", VA = "0xA61D")]
			set
			{
			}
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x060058B3 RID: 22707 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060058B4 RID: 22708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700120E")]
		public string AssetId
		{
			[Token(Token = "0x60058B3")]
			[Address(RVA = "0xA61E", Offset = "0xA61E", VA = "0xA61E", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058B4")]
			[Address(RVA = "0x1B50", Offset = "0x1B50", VA = "0x1B50", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x060058B5 RID: 22709 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700120F")]
		public string AssetPath
		{
			[Token(Token = "0x60058B5")]
			[Address(RVA = "0xA61F", Offset = "0xA61F", VA = "0xA61F", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x060058B6 RID: 22710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058B6")]
		[Address(RVA = "0xA620", Offset = "0xA620", VA = "0xA620")]
		public void SetGrayscale(float value, float duration)
		{
		/* --- GHIDRA: SetGrayscale ---
		void AssetContent_GameAssetViewRawImage__SetGrayscale
		               (undefined8 *param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  int iVar3;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63bd9 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_IRectProvider_TypeInfo);
		    DAT_ram_00a63bd9 = '\x01';
		  }
		  param2_00 = UI_IRectProvider_TypeInfo;
		  iVar3 = *(int *)(*(int *)(param2 + 0x20) + 0x10);
		  if (iVar3 == 1) {
		    iVar3 = 0x14;
		  }
		  else {
		    if (iVar3 != 2) goto code_r0x82369049;
		    iVar3 = 0x18;
		  }
		  if (*(int *)(param2 + iVar3) != 0) {
		    uVar1 = 0;
		    param1_00 = (int *)func_ii_1082(*(int *)(param2 + iVar3),UI_IRectProvider_TypeInfo);
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (param2_00 == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8236901f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,param2_00,0);
		code_r0x8236901f:
		    (**(code **)((ulonglong)*puVar2 * 4))(&local_10,param1_00,puVar2[1]);
		    param1[1] = local_8;
		    *param1 = local_10;
		    return;
		  }
		code_r0x82369049:
		  *param1 = 0;
		  param1[1] = 0;
		  return;
		}
		*/

		/* --- GHIDRA: SetGrayscale ---
		void AssetContent_GameAssetViewRawImage__SetGrayscale
		               (undefined8 *param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  int iVar3;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63bd9 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_IRectProvider_TypeInfo);
		    DAT_ram_00a63bd9 = '\x01';
		  }
		  param2_00 = UI_IRectProvider_TypeInfo;
		  iVar3 = *(int *)(*(int *)(param2 + 0x20) + 0x10);
		  if (iVar3 == 1) {
		    iVar3 = 0x14;
		  }
		  else {
		    if (iVar3 != 2) goto code_r0x82369049;
		    iVar3 = 0x18;
		  }
		  if (*(int *)(param2 + iVar3) != 0) {
		    uVar1 = 0;
		    param1_00 = (int *)func_ii_1082(*(int *)(param2 + iVar3),UI_IRectProvider_TypeInfo);
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (param2_00 == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8236901f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,param2_00,0);
		code_r0x8236901f:
		    (**(code **)((ulonglong)*puVar2 * 4))(&local_10,param1_00,puVar2[1]);
		    param1[1] = local_8;
		    *param1 = local_10;
		    return;
		  }
		code_r0x82369049:
		  *param1 = 0;
		  param1[1] = 0;
		  return;
		}
		*/

		}

		// Token: 0x060058B7 RID: 22711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058B7")]
		[Address(RVA = "0xA621", Offset = "0xA621", VA = "0xA621")]
		private void GrayscaleChanged(float from, float to, float duration)
		{
		/* --- GHIDRA: GrayscaleChanged ---
		void AssetContent_GameAssetViewRawImage__GrayscaleChanged(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a63bd8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__remove_ReadyEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_GameAssetViewRawImage_GameAnimationViewOnReadyEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_GameAssetViewRawImage_GameRawImageLoaderOnReadyEvent__);
		    DAT_ram_00a63bd8 = '\x01';
		  }
		  if (*(int *)(param1 + 0x30) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x30),0,0);
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x14);
		  uVar3 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_AssetContent_GameAssetViewRawImage_GameRawImageLoaderOnReadyEvent__
		             ,0);
		  AssetContent_Loaders_AbstractGameGraphicLoader_object__object___get_Rect
		            (uVar4,uVar3,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__remove_ReadyEvent__
		            );
		  iVar5 = *(int *)(param1 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_AssetContent_GameAssetViewRawImage_GameAnimationViewOnReadyEvent__,
		             0);
		  if (DAT_ram_00a63bbb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAnimationView__TypeInfo);
		    DAT_ram_00a63bbb = '\x01';
		  }
		  param1_00 = *(int *)(iVar5 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,uVar3,0);
		    uVar4 = System_Action_GameAnimationView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_GameAnimationView__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(iVar5 + 0x10,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1,0,iVar2);
		      *(undefined4 *)(param1 + 0x20) = 0;
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060058B8 RID: 22712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058B8")]
		[Address(RVA = "0xA622", Offset = "0xA622", VA = "0xA622")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		uint AssetContent_GameAssetViewRawImage__OnDestroy
		               (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  *param3 = 0;
		  if (*(int *)(param2 + 0x10) == 1) {
		    piVar1 = (int *)(param1 + 0x14);
		  }
		  else {
		    if (*(int *)(param2 + 0x10) != 2) {
		      return 0;
		    }
		    piVar1 = (int *)(param1 + 0x18);
		  }
		  iVar2 = *piVar1;
		  *param3 = iVar2;
		  return (uint)(iVar2 != 0);
		}
		*/

		}

		// Token: 0x060058B9 RID: 22713 RVA: 0x0000FC48 File Offset: 0x0000DE48
		[Token(Token = "0x60058B9")]
		[Address(RVA = "0xA623", Offset = "0xA623", VA = "0xA623")]
		public bool TryGetCurrentContent(AssetDic asset, out IGameAssetContent content)
		{
		/* --- GHIDRA: TryGetCurrentContent ---
		void AssetContent_GameAssetViewRawImage__TryGetCurrentContent
		               (int param1,float param2,undefined4 param3)
		
		{
		  Core_Data_MedalData__IsMedalAchieved(*(undefined4 *)(param1 + 0x10),param2,0);
		  AssetContent_GameAnimationView__PlayAnimation(*(undefined4 *)(param1 + 0x18),param2,param1);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060058BA RID: 22714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058BA")]
		[Address(RVA = "0xA624", Offset = "0xA624", VA = "0xA624", Slot = "11")]
		public void SetGrayscale(float value)
		{
		}

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x060058BB RID: 22715 RVA: 0x0000FC60 File Offset: 0x0000DE60
		[Token(Token = "0x17001210")]
		public Rect Rect
		{
			[Token(Token = "0x60058BB")]
			[Address(RVA = "0xA625", Offset = "0xA625", VA = "0xA625", Slot = "10")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x060058BC RID: 22716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058BC")]
		[Address(RVA = "0xA626", Offset = "0xA626", VA = "0xA626")]
		public GameAssetViewRawImage()
		{
		}

		// Token: 0x04002FF5 RID: 12277
		[Token(Token = "0x4002FF5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RawImageWithGrayscale _gameRawImage;

		// Token: 0x04002FF6 RID: 12278
		[Token(Token = "0x4002FF6")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameRawImageLoader _gameRawImageLoader;

		// Token: 0x04002FF7 RID: 12279
		[Token(Token = "0x4002FF7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameAnimationView _gameAnimationView;

		// Token: 0x04002FF8 RID: 12280
		[Token(Token = "0x4002FF8")]
		[FieldOffset(Offset = "0x1C")]
		private string _assetId;

		// Token: 0x04002FF9 RID: 12281
		[Token(Token = "0x4002FF9")]
		[FieldOffset(Offset = "0x20")]
		private AssetDic _asset;

		// Token: 0x04002FFB RID: 12283
		[Token(Token = "0x4002FFB")]
		[FieldOffset(Offset = "0x28")]
		private bool _interactable;

		// Token: 0x04002FFC RID: 12284
		[Token(Token = "0x4002FFC")]
		[FieldOffset(Offset = "0x2C")]
		private float _grayscaleValue;

		// Token: 0x04002FFD RID: 12285
		[Token(Token = "0x4002FFD")]
		[FieldOffset(Offset = "0x30")]
		private Tween _grayscaleTween;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_GameAnimationView ---
		uint AssetContent_GameAssetViewRawImage__get_GameAnimationView(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  
		  if (DAT_ram_00a63bd1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__get_IsReady__
		              );
		    DAT_ram_00a63bd1 = '\x01';
		  }
		  if (*(char *)(*(int *)(param1 + 0x18) + 0x44) == '\0') {
		    uVar1 = (uint)(*(char *)(*(int *)(param1 + 0x14) + 0x20) != '\0');
		  }
		  else {
		    uVar1 = 1;
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_IsReady ---
		void AssetContent_GameAssetViewRawImage__get_IsReady(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63bd2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    DAT_ram_00a63bd2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IAsyncLoadableContent__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAsyncLoadableContent__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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


		/* --- GHIDRA: add_ReadyEvent ---
		void AssetContent_GameAssetViewRawImage__add_ReadyEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63bd3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    DAT_ram_00a63bd3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IAsyncLoadableContent__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAsyncLoadableContent__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ReadyEvent ---
		void AssetContent_GameAssetViewRawImage__remove_ReadyEvent(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a63bd4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__add_ReadyEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_GameAssetViewRawImage_GameAnimationViewOnReadyEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_GameAssetViewRawImage_GameRawImageLoaderOnReadyEvent__);
		    DAT_ram_00a63bd4 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x14);
		  uVar3 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_AssetContent_GameAssetViewRawImage_GameRawImageLoaderOnReadyEvent__
		             ,0);
		  AssetContent_Loaders_AbstractGameGraphicLoader_object__object___SetAssetPath
		            (uVar4,uVar3,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__add_ReadyEvent__
		            );
		  iVar5 = *(int *)(param1 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_AssetContent_GameAssetViewRawImage_GameAnimationViewOnReadyEvent__,
		             0);
		  if (DAT_ram_00a63bba == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAnimationView__TypeInfo);
		    DAT_ram_00a63bba = '\x01';
		  }
		  param1_00 = *(int *)(iVar5 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,uVar3,0);
		    uVar4 = System_Action_GameAnimationView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_GameAnimationView__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(iVar5 + 0x10,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_Interactable ---
		void AssetContent_GameAssetViewRawImage__get_Interactable
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  char cVar1;
		  uint uVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  
		  *(char *)(param1 + 0x28) = (char)param2;
		  iVar4 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x188) * 4))
		            (*(int **)(param1 + 0x10),param2,*(undefined4 *)(iVar4 + 0x18c));
		  cVar1 = *(char *)(param1 + 0x28);
		  iVar4 = *(int *)(param1 + 0x18);
		  if (DAT_ram_00a63bc0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    DAT_ram_00a63bc0 = '\x01';
		  }
		  *(char *)(iVar4 + 0x1c) = cVar1;
		  param1_00 = *(int **)(iVar4 + 0x3c);
		  if (param1_00 != (int *)0x0) {
		    uVar2 = 0;
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8))
		        {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + iVar4 + 0xe8);
		          goto code_r0x82367dcf;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Animations_IGameAnimation_TypeInfo,5);
		code_r0x82367dcf:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_00,cVar1 != '\0',puVar3[1]);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_AssetId ---
		undefined4 AssetContent_GameAssetViewRawImage__get_AssetId(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63bd6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_IGameAssetContent_TypeInfo);
		    DAT_ram_00a63bd6 = '\x01';
		  }
		  iVar5 = *(int *)(*(int *)(param1 + 0x20) + 0x10);
		  if (iVar5 == 1) {
		    piVar6 = (int *)(param1 + 0x14);
		  }
		  else {
		    if (iVar5 != 2) goto code_r0x82368bf4;
		    piVar6 = (int *)(param1 + 0x18);
		  }
		  piVar6 = (int *)*piVar6;
		  if (piVar6 != (int *)0x0) {
		    uVar1 = 0;
		    iVar5 = *piVar6;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_IGameAssetContent_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x82368bda;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar6,Core_IGameAssetContent_TypeInfo,2);
		code_r0x82368bda:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		    return uVar3;
		  }
		code_r0x82368bf4:
		  uVar3 = unnamed_function_2232(&string___TypeInfo);
		  iVar5 = Mono_Security_ASN1Convert__ToOid(uVar3,6);
		  uVar3 = unnamed_function_2232(&StringLiteral_8419);
		  *(undefined4 *)(iVar5 + 0x10) = uVar3;
		  local_4 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0x10);
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar4 = unnamed_function_2232(&StringLiteral_19965);
		  uVar3 = func_ii_4419(uVar4,uVar3,0);
		  *(undefined4 *)(iVar5 + 0x14) = uVar3;
		  uVar3 = unnamed_function_2232(&StringLiteral_23245);
		  *(undefined4 *)(iVar5 + 0x18) = uVar3;
		  *(undefined4 *)(iVar5 + 0x1c) = *(undefined4 *)(*(int *)(param1 + 0x20) + 0xc);
		  uVar3 = unnamed_function_2232(&StringLiteral_278);
		  *(undefined4 *)(iVar5 + 0x20) = uVar3;
		  *(undefined4 *)(iVar5 + 0x24) = *(undefined4 *)(*(int *)(param1 + 0x20) + 0x14);
		  uVar3 = System_Single__ToString(iVar5,0);
		  uVar4 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar4 = unnamed_function_1417(uVar4);
		  System_String__Concat(uVar4,uVar3,0);
		  uVar3 = unnamed_function_2232(&Method_AssetContent_GameAssetViewRawImage_get_AssetPath__);
		  func_ii_1050(uVar4,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_AssetId ---
		undefined4 AssetContent_GameAssetViewRawImage__set_AssetId(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x44);
		  param2_00 = 0;
		  if (DAT_ram_00a5acf5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__);
		    DAT_ram_00a5acf5 = '\x01';
		  }
		  if (0 < *(int *)(param1_00 + 0xc)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param1_00,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == 0x10) {
		        return *(undefined4 *)(iVar1 + 0x10);
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param1_00 + 0xc));
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: get_AssetPath ---
		void AssetContent_GameAssetViewRawImage__get_AssetPath
		               (int param1,float param2,float param3,undefined4 param4)
		
		{
		  float fVar1;
		  float fVar2;
		  float fVar3;
		  float fVar4;
		  
		  fVar1 = *(float *)(param1 + 0x2c);
		  if (DAT_ram_00a648f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Mathf_TypeInfo);
		    DAT_ram_00a648f3 = '\x01';
		  }
		  fVar2 = ABS(fVar1);
		  if (fVar2 <= ABS(param2)) {
		    fVar2 = ABS(param2);
		  }
		  fVar4 = **(float **)(UnityEngine_Mathf_TypeInfo + 0x5c) * 8.0;
		  fVar3 = fVar2 * 1e-06;
		  if (fVar2 * 1e-06 <= fVar4) {
		    fVar3 = fVar4;
		  }
		  if (fVar3 <= ABS(param2 - fVar1)) {
		    fVar1 = *(float *)(param1 + 0x2c);
		    *(float *)(param1 + 0x2c) = param2;
		    AssetContent_GameAssetViewRawImage__SetGrayscale(param1,fVar1,param2,param3,param1);
		  }
		  return;
		}
		*/

}
