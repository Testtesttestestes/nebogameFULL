using System;
using Gameplay.Gifts.GdEvents.Control;
using Gameplay.Gifts.GdEvents.Model;
using Gameplay.Gifts.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Gifts.GdEvents.View
{
	// Token: 0x0200070E RID: 1806
	[Token(Token = "0x200070E")]
	public class GiftWindow : ClosableBaseWindow<GiftWindow.GiftWindowArgs>
	{
		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06002B39 RID: 11065 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700083C")]
		public override string WindowId
		{
			[Token(Token = "0x6002B39")]
			[Address(RVA = "0x7BD4", Offset = "0x7BD4", VA = "0x7BD4", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06002B3A RID: 11066 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700083D")]
		public GiftView GiftView
		{
			[Token(Token = "0x6002B3A")]
			[Address(RVA = "0x7BD5", Offset = "0x7BD5", VA = "0x7BD5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06002B3B RID: 11067 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700083E")]
		public TextMeshProUGUI Annotation
		{
			[Token(Token = "0x6002B3B")]
			[Address(RVA = "0x7BD6", Offset = "0x7BD6", VA = "0x7BD6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B3C")]
		[Address(RVA = "0x7BD7", Offset = "0x7BD7", VA = "0x7BD7", Slot = "18")]
		protected override void OnShow(BaseWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Gifts_GdEvents_View_GiftWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a22a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_GiftWindow_GiftWindowArgs__OnClose__);
		    DAT_ram_00a5a22a = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_GiftWindow_GiftWindowArgs__OnClose__);
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x44),0);
		  iVar1 = **(int **)(param1 + 0x44);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x44),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x48);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x48),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x4c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x4c),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x4c) = 0;
		  *(undefined8 *)(param1 + 0x44) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B3D")]
		[Address(RVA = "0x7BD8", Offset = "0x7BD8", VA = "0x7BD8", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Gifts_GdEvents_View_GiftWindow__OnClose(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a22b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_GiftWindow_GiftWindowArgs___ctor__);
		    DAT_ram_00a5a22b = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_GiftWindow_GiftWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B3E")]
		[Address(RVA = "0x7BD9", Offset = "0x7BD9", VA = "0x7BD9")]
		public GiftWindow()
		{
		}

		// Token: 0x040017A0 RID: 6048
		[Token(Token = "0x40017A0")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Gifts/GdEvents/GiftWindow";

		// Token: 0x040017A1 RID: 6049
		[Token(Token = "0x40017A1")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GiftView _giftView;

		// Token: 0x040017A2 RID: 6050
		[Token(Token = "0x40017A2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _annotation;

		// Token: 0x040017A3 RID: 6051
		[Token(Token = "0x40017A3")]
		[FieldOffset(Offset = "0x44")]
		private GiftController _controller;

		// Token: 0x040017A4 RID: 6052
		[Token(Token = "0x40017A4")]
		[FieldOffset(Offset = "0x48")]
		private GiftModel _model;

		// Token: 0x040017A5 RID: 6053
		[Token(Token = "0x40017A5")]
		[FieldOffset(Offset = "0x4C")]
		private GiftWindowMediator _mediator;

		// Token: 0x0200070F RID: 1807
		[Token(Token = "0x200070F")]
		public class GiftWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002B3F RID: 11071 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002B3F")]
			[Address(RVA = "0x7BDA", Offset = "0x7BDA", VA = "0x7BDA")]
			public GiftWindowArgs(SocialGiftDic gift)
			{
			}

			// Token: 0x040017A6 RID: 6054
			[Token(Token = "0x40017A6")]
			[FieldOffset(Offset = "0x18")]
			public readonly SocialGiftDic Gift;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Annotation ---
		void Gameplay_Gifts_GdEvents_View_GiftWindow__get_Annotation
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param3_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  undefined4 uVar8;
		  int iVar9;
		  
		  if (DAT_ram_00a5a229 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_BaseWindow_GiftWindow_GiftWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Gifts_GdEvents_Control_GiftController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Gifts_GdEvents_Model_GiftModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Gifts_GdEvents_Control_GiftWindowMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Gifts_Events_GiftsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a229 = '\x01';
		  }
		  UI_Windows_BaseWindow_object____ctor
		            (param1,param2,Method_UI_Windows_BaseWindow_GiftWindow_GiftWindowArgs__OnShow__);
		  param3_00 = unnamed_function_1417(Gameplay_Gifts_Events_GiftsEvents_TypeInfo);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x811e99be;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811e99be:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar7;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x158);
		        goto code_r0x811e9a6a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x811e9a6a:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  uVar8 = *(undefined4 *)(iVar6 + 0x14);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar7;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x811e9b19;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811e9b19:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  iVar6 = unnamed_function_1417(Gameplay_Gifts_GdEvents_Model_GiftModel_TypeInfo);
		  Gameplay_Gifts_Model_GiftsModel__Dispose(iVar6,piVar5,uVar3,uVar4,iVar6);
		  *(undefined4 *)(iVar6 + 0x24) = uVar8;
		  *(undefined4 *)(iVar6 + 0x20) = 10;
		  *(int *)(param1 + 0x48) = iVar6;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x1d8);
		        goto code_r0x811e9bf9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x23);
		code_r0x811e9bf9:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar9 = **(int **)(iVar6 + 0x10);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x100) * 4))
		                    (*(int **)(iVar6 + 0x10),*(undefined4 *)(iVar9 + 0x104));
		  uVar8 = *(undefined4 *)(param1 + 0x48);
		  iVar6 = unnamed_function_1417(Gameplay_Gifts_GdEvents_Control_GiftController_TypeInfo);
		  if (DAT_ram_00a5a251 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_GiftsModel__GiftsEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_SocialService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5a251 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (iVar6,uVar8,param3_00,Method_MVC_AbstractController_GiftsModel__GiftsEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar8 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_SocialService___);
		  *(undefined4 *)(iVar6 + 0x1c) = uVar3;
		  *(undefined4 *)(iVar6 + 0x18) = uVar8;
		  *(int *)(param1 + 0x44) = iVar6;
		  uVar3 = *(undefined4 *)(param1 + 0x48);
		  piVar5 = (int *)unnamed_function_1417(Gameplay_Gifts_GdEvents_Control_GiftWindowMediator_TypeInfo)
		  ;
		  if (DAT_ram_00a5a240 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GiftModel__GiftsEvents__GiftController__GiftWindow___ctor__
		              );
		    DAT_ram_00a5a240 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (piVar5,uVar3,param3_00,iVar6,
		             Method_MVC_AbstractViewMediator_GiftModel__GiftsEvents__GiftController__GiftWindow___ctor__
		            );
		  *(int **)(param1 + 0x4c) = piVar5;
		  (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x160) * 4))
		            (piVar5,param1,*(undefined4 *)(*piVar5 + 0x164));
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x44),0);
		  return;
		}
		*/

}
