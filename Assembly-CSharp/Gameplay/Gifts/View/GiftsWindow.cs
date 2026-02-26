using System;
using Core.Data;
using Gameplay.Gifts.Controller;
using Gameplay.Gifts.Events;
using Gameplay.Gifts.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Gifts.View
{
	// Token: 0x0200070A RID: 1802
	[Token(Token = "0x200070A")]
	public class GiftsWindow : ClosableBaseWindow<GiftsWindow.GiftsWindowArgs>
	{
		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06002B1E RID: 11038 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000833")]
		public override string WindowId
		{
			[Token(Token = "0x6002B1E")]
			[Address(RVA = "0x7BB9", Offset = "0x7BB9", VA = "0x7BB9", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B1F")]
		[Address(RVA = "0x7BBA", Offset = "0x7BBA", VA = "0x7BBA")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Gifts_View_GiftsWindow__OnDestroy(int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5a221 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_GiftsWindow_GiftsWindowArgs__OnShow__);
		    DAT_ram_00a5a221 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_GiftsWindow_GiftsWindowArgs__OnShow__);
		  Gameplay_UserInterface_View_UserView__get_UserData
		            (*(undefined4 *)(param1 + 0x40),*(undefined4 *)(param2 + 0x18),0);
		  Gameplay_Gifts_View_GiftsWindow__OnShow(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B20")]
		[Address(RVA = "0x7BBB", Offset = "0x7BBB", VA = "0x7BBB", Slot = "22")]
		protected override void OnShow(GiftsWindow.GiftsWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Gifts_View_GiftsWindow__OnShow(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  int *param1_00;
		  
		  if (DAT_ram_00a5a222 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_GiftsWindow_GiftsWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Gifts_Controller_GiftsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Gifts_Events_GiftsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Gifts_Model_GiftsModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Gifts_Controller_GiftsViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a222 = '\x01';
		  }
		  if (*(char *)(param1 + 0x54) == '\0') {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		          goto code_r0x811e9118;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811e9118:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar7 = *param1_00;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		          goto code_r0x811e91c4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811e91c4:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    uVar4 = func_ii_7112(uVar4,0);
		    iVar7 = unnamed_function_1417(Gameplay_Gifts_Model_GiftsModel_TypeInfo);
		    Gameplay_Gifts_Model_GiftsModel__Dispose(iVar7,piVar6,uVar3,uVar4,iVar7);
		    iVar5 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_GiftsWindow_GiftsWindowArgs__get_WindowArgs__)
		    ;
		    *(undefined4 *)(iVar7 + 0xc) = *(undefined4 *)(iVar5 + 0x18);
		    *(int *)(param1 + 0x44) = iVar7;
		    uVar3 = unnamed_function_1417(Gameplay_Gifts_Events_GiftsEvents_TypeInfo);
		    *(undefined4 *)(param1 + 0x48) = uVar3;
		    uVar4 = *(undefined4 *)(param1 + 0x44);
		    iVar7 = unnamed_function_1417(Gameplay_Gifts_Controller_GiftsController_TypeInfo);
		    if (DAT_ram_00a5a251 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_GiftsModel__GiftsEvents___ctor__);
		      Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_SocialService___);
		      Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		      DAT_ram_00a5a251 = '\x01';
		    }
		    Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		              (iVar7,uVar4,uVar3,Method_MVC_AbstractController_GiftsModel__GiftsEvents___ctor__);
		    if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		    }
		    uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                      (Method_Core_Net_ServiceFactory_GetService_SocialService___);
		    *(undefined4 *)(iVar7 + 0x18) = uVar3;
		    *(int *)(param1 + 0x4c) = iVar7;
		    uVar3 = *(undefined4 *)(param1 + 0x44);
		    uVar4 = *(undefined4 *)(param1 + 0x48);
		    piVar6 = (int *)unnamed_function_1417(Gameplay_Gifts_Controller_GiftsViewMediator_TypeInfo);
		    if (DAT_ram_00a5a257 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_GiftsModel__GiftsEvents__GiftsController__GiftsView___ctor__
		                );
		      DAT_ram_00a5a257 = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (piVar6,uVar3,uVar4,iVar7,
		               Method_MVC_AbstractViewMediator_GiftsModel__GiftsEvents__GiftsController__GiftsView___ctor__
		              );
		    (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x160) * 4))
		              (piVar6,*(undefined4 *)(param1 + 0x3c),*(undefined4 *)(*piVar6 + 0x164));
		    *(int **)(param1 + 0x50) = piVar6;
		    MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x4c),0);
		    *(undefined1 *)(param1 + 0x54) = 1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B21")]
		[Address(RVA = "0x7BBC", Offset = "0x7BBC", VA = "0x7BBC")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_Gifts_View_GiftsWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  undefined8 *puVar1;
		  int iVar2;
		  
		  if (*(char *)(param1 + 0x54) != '\0') {
		    puVar1 = (undefined8 *)(param1 + 0x4c);
		    MVC_AbstractController__Run(*(undefined4 *)puVar1,0);
		    iVar2 = **(int **)(param1 + 0x44);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)(param1 + 0x44),*(undefined4 *)(iVar2 + 0xec));
		    iVar2 = **(int **)puVar1;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)puVar1,*(undefined4 *)(iVar2 + 0xec));
		    iVar2 = **(int **)(param1 + 0x50);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		              (*(int **)(param1 + 0x50),*(undefined4 *)(iVar2 + 0x134));
		    *puVar1 = 0;
		    *(undefined8 *)(param1 + 0x44) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B22")]
		[Address(RVA = "0x7BBD", Offset = "0x7BBD", VA = "0x7BBD")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_Gifts_View_GiftsWindow__DestroyMVC(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a223 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_GiftsWindow_GiftsWindowArgs___ctor__);
		    DAT_ram_00a5a223 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_GiftsWindow_GiftsWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B23")]
		[Address(RVA = "0x7BBE", Offset = "0x7BBE", VA = "0x7BBE")]
		public GiftsWindow()
		{
		}

		// Token: 0x0400178F RID: 6031
		[Token(Token = "0x400178F")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Gifts/GiftsWindow";

		// Token: 0x04001790 RID: 6032
		[Token(Token = "0x4001790")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GiftsView _giftsView;

		// Token: 0x04001791 RID: 6033
		[Token(Token = "0x4001791")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UserView _userView;

		// Token: 0x04001792 RID: 6034
		[Token(Token = "0x4001792")]
		[FieldOffset(Offset = "0x44")]
		private GiftsModel _model;

		// Token: 0x04001793 RID: 6035
		[Token(Token = "0x4001793")]
		[FieldOffset(Offset = "0x48")]
		private GiftsEvents _events;

		// Token: 0x04001794 RID: 6036
		[Token(Token = "0x4001794")]
		[FieldOffset(Offset = "0x4C")]
		private GiftsController _controller;

		// Token: 0x04001795 RID: 6037
		[Token(Token = "0x4001795")]
		[FieldOffset(Offset = "0x50")]
		private GiftsViewMediator _mediator;

		// Token: 0x04001796 RID: 6038
		[Token(Token = "0x4001796")]
		[FieldOffset(Offset = "0x54")]
		private bool _mvcSetUp;

		// Token: 0x0200070B RID: 1803
		[Token(Token = "0x200070B")]
		public class GiftsWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002B24 RID: 11044 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002B24")]
			[Address(RVA = "0x7BBF", Offset = "0x7BBF", VA = "0x7BBF")]
			public GiftsWindowArgs(UserData owner)
			{
			}

			// Token: 0x04001797 RID: 6039
			[Token(Token = "0x4001797")]
			[FieldOffset(Offset = "0x18")]
			public UserData Owner;
		}
	}
}
