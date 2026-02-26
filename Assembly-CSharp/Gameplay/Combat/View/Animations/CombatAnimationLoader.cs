using System;
using System.Runtime.CompilerServices;
using Core.Animations;
using Il2CppDummyDll;
using UnityEngine;
using Utils;

namespace Gameplay.Combat.View.Animations
{
	// Token: 0x02000982 RID: 2434
	[Token(Token = "0x2000982")]
	public class CombatAnimationLoader : CombatAnimation.IContent, IDisposable
	{
		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06003A09 RID: 14857 RVA: 0x0000B940 File Offset: 0x00009B40
		// (set) Token: 0x06003A0A RID: 14858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B63")]
		public bool IsLeft
		{
			[Token(Token = "0x6003A09")]
			[Address(RVA = "0x898D", Offset = "0x898D", VA = "0x898D", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A0A")]
			[Address(RVA = "0x898E", Offset = "0x898E", VA = "0x898E", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1400018B RID: 395
		// (add) Token: 0x06003A0B RID: 14859 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003A0C RID: 14860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400018B")]
		public event Action<CombatAnimation.IContent> OnCompleteEvent
		{
			[Token(Token = "0x6003A0B")]
			[Address(RVA = "0x898F", Offset = "0x898F", VA = "0x898F", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A0C")]
			[Address(RVA = "0x8990", Offset = "0x8990", VA = "0x8990", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06003A0D RID: 14861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A0D")]
		[Address(RVA = "0x8991", Offset = "0x8991", VA = "0x8991")]
		public CombatAnimationLoader(int sortingOrder)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Combat_View_Animations_CombatAnimationLoader___ctor
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  undefined4 param1_01;
		  undefined4 param1_02;
		  undefined4 param1_03;
		  
		  if (DAT_ram_00a57e16 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_GameResources_GameResourcesManager_AnimationReadyDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_Animations_CombatAnimationLoader_HandleLoadFail__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_Animations_CombatAnimationLoader_HandleLoadSuccess__);
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourcesManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_GameResources_GameResourcesManager_ResourceFailedDelegate_TypeInfo);
		    DAT_ram_00a57e16 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0xc) = param2;
		  param1_00 = (int *)unnamed_function_1417
		                               (
		                               Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent__TypeInfo
		                               );
		  Gameplay_FeedbackForm_Model_FeedbackFormModel__GetUid
		            (param1_00,
		             Method_Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___ctor__);
		  *(int **)(param1 + 0x1c) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		            (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		  *(undefined4 *)(param1 + 0x14) = param3;
		  param1_03 = *(undefined4 *)(param1 + 0xc);
		  param1_01 = unnamed_function_1417
		                        (Core_GameResources_GameResourcesManager_AnimationReadyDelegate_TypeInfo);
		  Core_GameResources_GameResourcesManager_AudioClipReadyDelegate__EndInvoke
		            (param1_01,param1,
		             Method_Gameplay_Combat_View_Animations_CombatAnimationLoader_HandleLoadSuccess__,0);
		  param1_02 = unnamed_function_1417
		                        (Core_GameResources_GameResourcesManager_ResourceFailedDelegate_TypeInfo);
		  Core_GameResources_GameResourcesManager_SpriteAtlasReadyDelegate___ctor
		            (param1_02,param1,
		             Method_Gameplay_Combat_View_Animations_CombatAnimationLoader_HandleLoadFail__,0);
		  if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameResources_GameResourcesManager_TypeInfo);
		  }
		  Core_GameResources_GameResourcesManager__ReleaseTextMeshProSpriteAsset
		            (param1_03,param1_01,param1_02,1,0);
		  return *(undefined4 *)(param1 + 0x1c);
		}
		*/

		}

		// Token: 0x06003A0E RID: 14862 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A0E")]
		[Address(RVA = "0x8992", Offset = "0x8992", VA = "0x8992")]
		public OpToken<CombatAnimation.IContent, CombatAnimation.IContent> Load(string path, Transform parent)
		{
		/* --- GHIDRA: Load ---
		void Gameplay_Combat_View_Animations_CombatAnimationLoader__Load
		               (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a57e17 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGameAnimation__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_Animations_CombatAnimationLoader_HandleCompleteEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent__Complete__)
		    ;
		    DAT_ram_00a57e17 = '\x01';
		  }
		  if ((*(int *)(param1 + 0x1c) != 0) && (*(int *)(*(int *)(param1 + 0x1c) + 8) != 4)) {
		    *(int **)(param1 + 0x10) = param2;
		    uVar1 = 0;
		    uVar3 = *(undefined4 *)(param1 + 0x18);
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		        {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		          goto code_r0x80e69102;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Core_Animations_IGameAnimation_TypeInfo,10);
		code_r0x80e69102:
		    (**(code **)((ulonglong)*puVar2 * 4))(param2,uVar3,puVar2[1]);
		    uVar1 = 0;
		    piVar4 = *(int **)(param1 + 0x10);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		        {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xf0);
		          goto code_r0x80e69181;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Animations_IGameAnimation_TypeInfo,6);
		code_r0x80e69181:
		    uVar1 = 0;
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar3,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		    piVar4 = *(int **)(param1 + 0x10);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		        {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xf0);
		          goto code_r0x80e69212;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Animations_IGameAnimation_TypeInfo,6);
		code_r0x80e69212:
		    uVar1 = 0;
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar3,0);
		    uVar3 = UnityEngine_UI_Selectable__set_interactable(uVar3,0);
		    UnityEngine_GameObject___ctor(uVar3,*(undefined4 *)(param1 + 0x14),0,0);
		    piVar4 = *(int **)(param1 + 0x10);
		    uVar3 = unnamed_function_1417(System_Action_IGameAnimation__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Combat_View_Animations_CombatAnimationLoader_HandleCompleteEvent__,0)
		    ;
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		        {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x80e692d1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Animations_IGameAnimation_TypeInfo,2);
		code_r0x80e692d1:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar4,uVar3,puVar2[1]);
		    Core_ExternAppMethods__OpenPaymentWindow
		              (*(undefined4 *)(param1 + 0x1c),param1,
		               Method_Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent__Complete__);
		    return;
		  }
		  uVar1 = 0;
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xf0);
		        goto code_r0x80e69051;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Animations_IGameAnimation_TypeInfo,6);
		code_r0x80e69051:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar3,0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  UnityEngine_Application__get_isPlaying(uVar3,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003A0F RID: 14863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A0F")]
		[Address(RVA = "0x8993", Offset = "0x8993", VA = "0x8993")]
		private void HandleLoadSuccess(IGameAnimation gameAnimation, string resourceUrl)
		{
		/* --- GHIDRA: HandleLoadSuccess ---
		void Gameplay_Combat_View_Animations_CombatAnimationLoader__HandleLoadSuccess
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x20);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06003A10 RID: 14864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A10")]
		[Address(RVA = "0x8994", Offset = "0x8994", VA = "0x8994")]
		private void HandleCompleteEvent(IGameAnimation obj)
		{
		/* --- GHIDRA: HandleCompleteEvent ---
		void Gameplay_Combat_View_Animations_CombatAnimationLoader__HandleCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57e18 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent__Fail__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5592);
		    DAT_ram_00a57e18 = '\x01';
		  }
		  param1_00 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_5592,param2,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  func_ii_7830(param1_00,0);
		  Utils_OpToken_object__object___DisposeHandlers
		            (*(undefined4 *)(param1 + 0x1c),param1,
		             Method_Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent__Fail__);
		  return;
		}
		*/

		}

		// Token: 0x06003A11 RID: 14865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A11")]
		[Address(RVA = "0x8995", Offset = "0x8995", VA = "0x8995")]
		private void HandleLoadFail(string path)
		{
		/* --- GHIDRA: HandleLoadFail ---
		void Gameplay_Combat_View_Animations_CombatAnimationLoader__HandleLoadFail
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a57e19 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    DAT_ram_00a57e19 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x120);
		        goto code_r0x80e69418;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Animations_IGameAnimation_TypeInfo,0xc);
		code_r0x80e69418:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06003A12 RID: 14866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A12")]
		[Address(RVA = "0x8996", Offset = "0x8996", VA = "0x8996", Slot = "8")]
		public void Play(bool loop = false)
		{
		/* --- GHIDRA: Play ---
		void Gameplay_Combat_View_Animations_CombatAnimationLoader__Play(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57e1a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    DAT_ram_00a57e1a = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf0);
		        goto code_r0x80e694c1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Animations_IGameAnimation_TypeInfo,6);
		code_r0x80e694c1:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar3,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003A13 RID: 14867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A13")]
		[Address(RVA = "0x8997", Offset = "0x8997", VA = "0x8997", Slot = "6")]
		public void Show()
		{
		/* --- GHIDRA: Show ---
		void Gameplay_Combat_View_Animations_CombatAnimationLoader__Show(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57e1b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    DAT_ram_00a57e1b = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf0);
		        goto code_r0x80e69576;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Animations_IGameAnimation_TypeInfo,6);
		code_r0x80e69576:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar3,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A14")]
		[Address(RVA = "0x8998", Offset = "0x8998", VA = "0x8998", Slot = "7")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		undefined4 Gameplay_Combat_View_Animations_CombatAnimationLoader__Hide(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57e1c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    DAT_ram_00a57e1c = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf0);
		        goto code_r0x80e6962b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Animations_IGameAnimation_TypeInfo,6);
		code_r0x80e6962b:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (uVar3,0);
		  return uVar3;
		}
		*/

		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06003A15 RID: 14869 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B64")]
		public Transform Transform
		{
			[Token(Token = "0x6003A15")]
			[Address(RVA = "0x8999", Offset = "0x8999", VA = "0x8999", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003A16 RID: 14870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A16")]
		[Address(RVA = "0x899A", Offset = "0x899A", VA = "0x899A", Slot = "12")]
		public void Dispose()
		{
		}

		// Token: 0x04002013 RID: 8211
		[Token(Token = "0x4002013")]
		[FieldOffset(Offset = "0xC")]
		public string Path;

		// Token: 0x04002014 RID: 8212
		[Token(Token = "0x4002014")]
		[FieldOffset(Offset = "0x10")]
		private IGameAnimation _animation;

		// Token: 0x04002015 RID: 8213
		[Token(Token = "0x4002015")]
		[FieldOffset(Offset = "0x14")]
		private Transform _parent;

		// Token: 0x04002016 RID: 8214
		[Token(Token = "0x4002016")]
		[FieldOffset(Offset = "0x18")]
		private readonly int _sortingOrder;

		// Token: 0x04002017 RID: 8215
		[Token(Token = "0x4002017")]
		[FieldOffset(Offset = "0x1C")]
		private OpToken<CombatAnimation.IContent, CombatAnimation.IContent> _loadOperation;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_IsLeft ---
		void Gameplay_Combat_View_Animations_CombatAnimationLoader__set_IsLeft
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57e14 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatAnimation_IContent__TypeInfo);
		    DAT_ram_00a57e14 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_CombatAnimation_IContent__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_CombatAnimation_IContent__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: add_OnCompleteEvent ---
		void Gameplay_Combat_View_Animations_CombatAnimationLoader__add_OnCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57e15 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatAnimation_IContent__TypeInfo);
		    DAT_ram_00a57e15 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_CombatAnimation_IContent__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_CombatAnimation_IContent__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: get_Transform ---
		void Gameplay_Combat_View_Animations_CombatAnimationLoader__get_Transform
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57e1d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGameAnimation__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_Animations_CombatAnimationLoader_HandleCompleteEvent__);
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourcesManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    DAT_ram_00a57e1d = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    uVar3 = unnamed_function_1417(System_Action_IGameAnimation__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Combat_View_Animations_CombatAnimationLoader_HandleCompleteEvent__,0)
		    ;
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		        {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd8);
		          goto code_r0x80e67b6c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Animations_IGameAnimation_TypeInfo,3);
		code_r0x80e67b6c:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,uVar3,puVar2[1]);
		  }
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  *(undefined4 *)(param1 + 0x10) = 0;
		  uVar3 = *(undefined4 *)(param1 + 0xc);
		  if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameResources_GameResourcesManager_TypeInfo);
		  }
		  Core_GameResources_GameResourcesManager__GetAnimation(uVar3,0);
		  return;
		}
		*/

}
