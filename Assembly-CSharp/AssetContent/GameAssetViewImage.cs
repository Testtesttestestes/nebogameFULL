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
	// Token: 0x02000E29 RID: 3625
	[Token(Token = "0x2000E29")]
	public class GameAssetViewImage : MonoBehaviour, IAsyncLoadableContent, IGameAssetContent, IRectProvider, IGrayscalable
	{
		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x06005896 RID: 22678 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001205")]
		public GameAnimationView GameAnimationView
		{
			[Token(Token = "0x6005896")]
			[Address(RVA = "0xA601", Offset = "0xA601", VA = "0xA601")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x06005897 RID: 22679 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
		[Token(Token = "0x17001206")]
		public bool IsReady
		{
			[Token(Token = "0x6005897")]
			[Address(RVA = "0xA602", Offset = "0xA602", VA = "0xA602", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000212 RID: 530
		// (add) Token: 0x06005898 RID: 22680 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005899 RID: 22681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000212")]
		public event Action<IAsyncLoadableContent> ReadyEvent
		{
			[Token(Token = "0x6005898")]
			[Address(RVA = "0xA603", Offset = "0xA603", VA = "0xA603", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005899")]
			[Address(RVA = "0xA604", Offset = "0xA604", VA = "0xA604", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600589A RID: 22682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600589A")]
		[Address(RVA = "0xA605", Offset = "0xA605", VA = "0xA605")]
		private void Awake()
		{
		}

		// Token: 0x0600589B RID: 22683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600589B")]
		[Address(RVA = "0xA606", Offset = "0xA606", VA = "0xA606")]
		private void GameAnimationViewOnReadyEvent(IAsyncLoadableContent obj)
		{
		}

		// Token: 0x0600589C RID: 22684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600589C")]
		[Address(RVA = "0xA607", Offset = "0xA607", VA = "0xA607")]
		private void LoaderOnReadyEvent(IAsyncLoadableContent obj)
		{
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x0600589D RID: 22685 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
		// (set) Token: 0x0600589E RID: 22686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001207")]
		public bool Interactable
		{
			[Token(Token = "0x600589D")]
			[Address(RVA = "0xA608", Offset = "0xA608", VA = "0xA608")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600589E")]
			[Address(RVA = "0xA609", Offset = "0xA609", VA = "0xA609")]
			set
			{
			}
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x0600589F RID: 22687 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060058A0 RID: 22688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001208")]
		public string AssetId
		{
			[Token(Token = "0x600589F")]
			[Address(RVA = "0xA60A", Offset = "0xA60A", VA = "0xA60A", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058A0")]
			[Address(RVA = "0xA60B", Offset = "0xA60B", VA = "0xA60B", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x060058A1 RID: 22689 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001209")]
		public string AssetPath
		{
			[Token(Token = "0x60058A1")]
			[Address(RVA = "0xA60C", Offset = "0xA60C", VA = "0xA60C", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x060058A2 RID: 22690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058A2")]
		[Address(RVA = "0xA60D", Offset = "0xA60D", VA = "0xA60D")]
		public void SetGrayscale(float value, float duration)
		{
		/* --- GHIDRA: SetGrayscale ---
		void AssetContent_GameAssetViewImage__SetGrayscale(undefined8 *param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  int iVar3;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63bd0 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_IRectProvider_TypeInfo);
		    DAT_ram_00a63bd0 = '\x01';
		  }
		  param2_00 = UI_IRectProvider_TypeInfo;
		  iVar3 = *(int *)(*(int *)(param2 + 0x20) + 0x10);
		  if (iVar3 == 1) {
		    iVar3 = 0x14;
		  }
		  else {
		    if (iVar3 != 2) goto code_r0x82368606;
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
		          goto code_r0x823685dc;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,param2_00,0);
		code_r0x823685dc:
		    (**(code **)((ulonglong)*puVar2 * 4))(&local_10,param1_00,puVar2[1]);
		    param1[1] = local_8;
		    *param1 = local_10;
		    return;
		  }
		code_r0x82368606:
		  *param1 = 0;
		  param1[1] = 0;
		  return;
		}
		*/

		/* --- GHIDRA: SetGrayscale ---
		void AssetContent_GameAssetViewImage__SetGrayscale(undefined8 *param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  int iVar3;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63bd0 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_IRectProvider_TypeInfo);
		    DAT_ram_00a63bd0 = '\x01';
		  }
		  param2_00 = UI_IRectProvider_TypeInfo;
		  iVar3 = *(int *)(*(int *)(param2 + 0x20) + 0x10);
		  if (iVar3 == 1) {
		    iVar3 = 0x14;
		  }
		  else {
		    if (iVar3 != 2) goto code_r0x82368606;
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
		          goto code_r0x823685dc;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,param2_00,0);
		code_r0x823685dc:
		    (**(code **)((ulonglong)*puVar2 * 4))(&local_10,param1_00,puVar2[1]);
		    param1[1] = local_8;
		    *param1 = local_10;
		    return;
		  }
		code_r0x82368606:
		  *param1 = 0;
		  param1[1] = 0;
		  return;
		}
		*/

		}

		// Token: 0x060058A3 RID: 22691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058A3")]
		[Address(RVA = "0xA60E", Offset = "0xA60E", VA = "0xA60E")]
		private void GrayscaleChanged(float from, float to, float duration)
		{
		/* --- GHIDRA: GrayscaleChanged ---
		void AssetContent_GameAssetViewImage__GrayscaleChanged(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a63bcf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__remove_ReadyEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_GameAssetViewImage_GameAnimationViewOnReadyEvent__);
		    Mono_Security_ASN1__get_Item(&Method_AssetContent_GameAssetViewImage_LoaderOnReadyEvent__);
		    DAT_ram_00a63bcf = '\x01';
		  }
		  if (*(int *)(param1 + 0x30) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x30),0,0);
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x14);
		  uVar3 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_AssetContent_GameAssetViewImage_LoaderOnReadyEvent__,0);
		  AssetContent_Loaders_AbstractGameGraphicLoader_object__object___get_Rect
		            (uVar4,uVar3,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__remove_ReadyEvent__
		            );
		  iVar5 = *(int *)(param1 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_AssetContent_GameAssetViewImage_GameAnimationViewOnReadyEvent__,0);
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
		      AssetContent_GameAssetViewImage__get_AssetId(param1,0,iVar2);
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

		// Token: 0x060058A4 RID: 22692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058A4")]
		[Address(RVA = "0xA60F", Offset = "0xA60F", VA = "0xA60F")]
		private void OnDestroy()
		{
		}

		// Token: 0x060058A5 RID: 22693 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
		[Token(Token = "0x60058A5")]
		[Address(RVA = "0xA610", Offset = "0xA610", VA = "0xA610")]
		public bool TryGetCurrentContent(AssetDic asset, out IGameAssetContent content)
		{
		/* --- GHIDRA: TryGetCurrentContent ---
		void AssetContent_GameAssetViewImage__TryGetCurrentContent
		               (int param1,float param2,undefined4 param3)
		
		{
		  UI_ImageAnimation__ShowAnimation_d__9__System_Collections_IEnumerator_get_Current
		            (*(undefined4 *)(param1 + 0x10),param2,0);
		  AssetContent_GameAnimationView__PlayAnimation(*(undefined4 *)(param1 + 0x18),param2,param1);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060058A6 RID: 22694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058A6")]
		[Address(RVA = "0xA611", Offset = "0xA611", VA = "0xA611", Slot = "11")]
		public void SetGrayscale(float value)
		{
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x060058A7 RID: 22695 RVA: 0x0000FC00 File Offset: 0x0000DE00
		[Token(Token = "0x1700120A")]
		public Rect Rect
		{
			[Token(Token = "0x60058A7")]
			[Address(RVA = "0xA612", Offset = "0xA612", VA = "0xA612", Slot = "10")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x060058A8 RID: 22696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058A8")]
		[Address(RVA = "0xA613", Offset = "0xA613", VA = "0xA613")]
		public GameAssetViewImage()
		{
		}

		// Token: 0x04002FEC RID: 12268
		[Token(Token = "0x4002FEC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ImageWithGrayscale _image;

		// Token: 0x04002FED RID: 12269
		[Token(Token = "0x4002FED")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameImageLoader _loader;

		// Token: 0x04002FEE RID: 12270
		[Token(Token = "0x4002FEE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameAnimationView _gameAnimationView;

		// Token: 0x04002FEF RID: 12271
		[Token(Token = "0x4002FEF")]
		[FieldOffset(Offset = "0x1C")]
		private string _assetId;

		// Token: 0x04002FF0 RID: 12272
		[Token(Token = "0x4002FF0")]
		[FieldOffset(Offset = "0x20")]
		private AssetDic _asset;

		// Token: 0x04002FF2 RID: 12274
		[Token(Token = "0x4002FF2")]
		[FieldOffset(Offset = "0x28")]
		private bool _interactable;

		// Token: 0x04002FF3 RID: 12275
		[Token(Token = "0x4002FF3")]
		[FieldOffset(Offset = "0x2C")]
		private float _grayscaleValue;

		// Token: 0x04002FF4 RID: 12276
		[Token(Token = "0x4002FF4")]
		[FieldOffset(Offset = "0x30")]
		private Tween _grayscaleTween;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_GameAnimationView ---
		uint AssetContent_GameAssetViewImage__get_GameAnimationView(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  
		  if (DAT_ram_00a63bc8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__get_IsReady__);
		    DAT_ram_00a63bc8 = '\x01';
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
		void AssetContent_GameAssetViewImage__get_IsReady(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63bc9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    DAT_ram_00a63bc9 = '\x01';
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
		void AssetContent_GameAssetViewImage__add_ReadyEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63bca == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    DAT_ram_00a63bca = '\x01';
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
		void AssetContent_GameAssetViewImage__remove_ReadyEvent(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a63bcb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__add_ReadyEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_GameAssetViewImage_GameAnimationViewOnReadyEvent__);
		    Mono_Security_ASN1__get_Item(&Method_AssetContent_GameAssetViewImage_LoaderOnReadyEvent__);
		    DAT_ram_00a63bcb = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x14);
		  uVar3 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_AssetContent_GameAssetViewImage_LoaderOnReadyEvent__,0);
		  AssetContent_Loaders_AbstractGameGraphicLoader_object__object___SetAssetPath
		            (uVar4,uVar3,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__add_ReadyEvent__);
		  iVar5 = *(int *)(param1 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_AssetContent_GameAssetViewImage_GameAnimationViewOnReadyEvent__,0);
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


		/* --- GHIDRA: get_AssetId ---
		void AssetContent_GameAssetViewImage__get_AssetId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  int *piVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63bcc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__set_AssetId__);
		    Mono_Security_ASN1__get_Item(&Core_IGameAssetContent_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a63bcc = '\x01';
		  }
		  iVar2 = System_Collections_CollectionBase___ctor(*(undefined4 *)(param1 + 0x1c),param2,0);
		  if (iVar2 == 0) {
		    Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		              (*(undefined4 *)(param1 + 0x14),0,
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__set_AssetId__);
		    UnityEngine_Transform__SetParent(*(undefined4 *)(param1 + 0x18),0,param2);
		    *(undefined4 *)(param1 + 0x20) = 0;
		    *(undefined4 *)(param1 + 0x1c) = param2;
		    iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(param2,0);
		    if (iVar2 != 0) {
		      return;
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		          goto code_r0x82367efe;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x82367efe:
		    piVar6 = (int *)(param1 + 0x18);
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    iVar2 = Core_Gameplay_Managers_DictManager__CheckSupportedService
		                      (uVar4,*(undefined4 *)(param1 + 0x1c),0);
		    *(int *)(param1 + 0x20) = iVar2;
		    if (*(int *)(iVar2 + 0x10) == 1) {
		      piVar6 = (int *)(param1 + 0x14);
		    }
		    else if (*(int *)(iVar2 + 0x10) != 2) goto code_r0x82367fd7;
		    piVar6 = (int *)*piVar6;
		    if (piVar6 == (int *)0x0) {
		code_r0x82367fd7:
		      uVar4 = unnamed_function_2232(&string___TypeInfo);
		      iVar2 = Mono_Security_ASN1Convert__ToOid(uVar4,6);
		      uVar4 = unnamed_function_2232(&StringLiteral_8419);
		      *(undefined4 *)(iVar2 + 0x10) = uVar4;
		      local_4 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0x10);
		      uVar4 = func_ii_1081(DAT_ram_00a66958,&local_4);
		      uVar5 = unnamed_function_2232(&StringLiteral_19965);
		      uVar4 = func_ii_4419(uVar5,uVar4,0);
		      *(undefined4 *)(iVar2 + 0x14) = uVar4;
		      uVar4 = unnamed_function_2232(&StringLiteral_23245);
		      *(undefined4 *)(iVar2 + 0x18) = uVar4;
		      *(undefined4 *)(iVar2 + 0x1c) = *(undefined4 *)(*(int *)(param1 + 0x20) + 0xc);
		      uVar4 = unnamed_function_2232(&StringLiteral_278);
		      *(undefined4 *)(iVar2 + 0x20) = uVar4;
		      *(undefined4 *)(iVar2 + 0x24) = *(undefined4 *)(*(int *)(param1 + 0x20) + 0x14);
		      uVar4 = System_Single__ToString(iVar2,0);
		      uVar5 = unnamed_function_2232(&System_Exception_TypeInfo);
		      uVar5 = unnamed_function_1417(uVar5);
		      System_String__Concat(uVar5,uVar4,0);
		      uVar4 = unnamed_function_2232(&Method_AssetContent_GameAssetViewImage_set_AssetId__);
		      func_ii_1050(uVar5,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar1 = 0;
		    uVar4 = *(undefined4 *)(param1 + 0x1c);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_IGameAssetContent_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		          goto code_r0x82367fc0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_IGameAssetContent_TypeInfo,1);
		code_r0x82367fc0:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar6,uVar4,puVar3[1]);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_AssetId ---
		undefined4 AssetContent_GameAssetViewImage__set_AssetId(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63bcd == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_IGameAssetContent_TypeInfo);
		    DAT_ram_00a63bcd = '\x01';
		  }
		  iVar5 = *(int *)(*(int *)(param1 + 0x20) + 0x10);
		  if (iVar5 == 1) {
		    piVar6 = (int *)(param1 + 0x14);
		  }
		  else {
		    if (iVar5 != 2) goto code_r0x823681b1;
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
		          goto code_r0x82368197;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar6,Core_IGameAssetContent_TypeInfo,2);
		code_r0x82368197:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		    return uVar3;
		  }
		code_r0x823681b1:
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
		  uVar3 = unnamed_function_2232(&Method_AssetContent_GameAssetViewImage_get_AssetPath__);
		  func_ii_1050(uVar4,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_AssetPath ---
		void AssetContent_GameAssetViewImage__get_AssetPath
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
		    AssetContent_GameAssetViewImage__SetGrayscale(param1,fVar1,param2,param3,param1);
		  }
		  return;
		}
		*/

}
