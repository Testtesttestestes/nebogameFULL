using System;
using Gameplay.UserInfo.Control;
using Gameplay.UserInfo.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x02000401 RID: 1025
	[Token(Token = "0x2000401")]
	public class UserInfoEditWindow : ClosableBaseWindow<UserInfoEditWindow.UserInfoEditWindowArgs>
	{
		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000434")]
		public override string WindowId
		{
			[Token(Token = "0x600181B")]
			[Address(RVA = "0x69CF", Offset = "0x69CF", VA = "0x69CF", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600181C")]
		[Address(RVA = "0x69D0", Offset = "0x69D0", VA = "0x69D0", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_UserInfo_View_UserInfoEditWindow__OnClose(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  int *param1_00;
		  undefined4 param2_00;
		  undefined4 param4;
		  int iVar1;
		  
		  if (DAT_ram_00a598f3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_UserInfoEditWindow_UserInfoEditWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_UserInfo_Control_UserInfoEditViewMediator_TypeInfo);
		    DAT_ram_00a598f3 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_UserInfoEditWindow_UserInfoEditWindowArgs__OnShow__
		              );
		  param2_00 = *(undefined4 *)(param2 + 0x18);
		  iVar1 = **(int **)(param2 + 0x1c);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x110) * 4))
		                        (*(int **)(param2 + 0x1c),*(undefined4 *)(iVar1 + 0x114));
		  param4 = *(undefined4 *)(param2 + 0x1c);
		  param1_00 = (int *)unnamed_function_1417
		                               (Gameplay_UserInfo_Control_UserInfoEditViewMediator_TypeInfo);
		  if (DAT_ram_00a59928 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__CultGenderNickSettingsView___ctor__
		              );
		    DAT_ram_00a59928 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,param2_00,param3_00,param4,
		             Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__CultGenderNickSettingsView___ctor__
		            );
		  *(int **)(param1 + 0x40) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,*(undefined4 *)(param1 + 0x3c),*(undefined4 *)(*param1_00 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x0600181D RID: 6173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600181D")]
		[Address(RVA = "0x69D1", Offset = "0x69D1", VA = "0x69D1", Slot = "22")]
		protected override void OnShow(UserInfoEditWindow.UserInfoEditWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_UserInfo_View_UserInfoEditWindow__OnShow(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a598f4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_UserInfoEditWindow_UserInfoEditWindowArgs___ctor__
		              );
		    DAT_ram_00a598f4 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_UserInfoEditWindow_UserInfoEditWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600181E")]
		[Address(RVA = "0x69D2", Offset = "0x69D2", VA = "0x69D2")]
		public UserInfoEditWindow()
		{
		}

		// Token: 0x04000CD0 RID: 3280
		[Token(Token = "0x4000CD0")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/UserInfo/UserInfoEditWindow";

		// Token: 0x04000CD1 RID: 3281
		[Token(Token = "0x4000CD1")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private CultGenderNickSettingsView _view;

		// Token: 0x04000CD2 RID: 3282
		[Token(Token = "0x4000CD2")]
		[FieldOffset(Offset = "0x40")]
		private UserInfoEditViewMediator _mediator;

		// Token: 0x02000402 RID: 1026
		[Token(Token = "0x2000402")]
		public class UserInfoEditWindowArgs : BaseWindowArgs
		{
			// Token: 0x0600181F RID: 6175 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600181F")]
			[Address(RVA = "0x69D3", Offset = "0x69D3", VA = "0x69D3")]
			public UserInfoEditWindowArgs(UserInfoModel model, UserInfoController controller)
			{
			}

			// Token: 0x04000CD3 RID: 3283
			[Token(Token = "0x4000CD3")]
			[FieldOffset(Offset = "0x18")]
			public readonly UserInfoModel Model;

			// Token: 0x04000CD4 RID: 3284
			[Token(Token = "0x4000CD4")]
			[FieldOffset(Offset = "0x1C")]
			public readonly UserInfoController Controller;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_UserInfo_View_UserInfoEditWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a598f2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_UserInfoEditWindow_UserInfoEditWindowArgs__OnClose__
		              );
		    DAT_ram_00a598f2 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_UserInfoEditWindow_UserInfoEditWindowArgs__OnClose__
		            );
		  iVar1 = **(int **)(param1 + 0x40);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x40),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x40) = 0;
		  return;
		}
		*/

}
