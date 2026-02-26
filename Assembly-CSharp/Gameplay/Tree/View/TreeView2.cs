using System;
using Gameplay.Isles.User;
using Gameplay.Tree.Control;
using Il2CppDummyDll;
using UI.Windows.Buildings;

namespace Gameplay.Tree.View
{
	// Token: 0x02000492 RID: 1170
	[Token(Token = "0x2000492")]
	public class TreeView2 : MainBuildingView2<UserIsle>, IDisposable
	{
		// Token: 0x06001BB4 RID: 7092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB4")]
		[Address(RVA = "0x6D33", Offset = "0x6D33", VA = "0x6D33", Slot = "4")]
		public override void Init(UserIsle isle)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Tree_View_TreeView2__Init(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  piVar1 = *(int **)(param1 + 0x1c);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		    *(undefined4 *)(param1 + 0x1c) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB5")]
		[Address(RVA = "0x6D34", Offset = "0x6D34", VA = "0x6D34", Slot = "5")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Tree_View_TreeView2__Dispose(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a584b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_Buildings_MainBuildingView2_UserIsle___ctor__);
		    DAT_ram_00a584b5 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_Windows_Buildings_MainBuildingView2_UserIsle___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB6")]
		[Address(RVA = "0x6D35", Offset = "0x6D35", VA = "0x6D35")]
		public TreeView2()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tree_View_TreeView2___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a584b6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__TreeView2___ctor__
		              );
		    DAT_ram_00a584b6 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__TreeView2___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04000EF9 RID: 3833
		[Token(Token = "0x4000EF9")]
		[FieldOffset(Offset = "0x1C")]
		private TreeViewMediator2 _mediator;
	}
}
