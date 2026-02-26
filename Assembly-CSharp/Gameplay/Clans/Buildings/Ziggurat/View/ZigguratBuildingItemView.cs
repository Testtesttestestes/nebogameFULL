using System;
using Core.Data;
using Il2CppDummyDll;
using UI.Windows.Buildings;

namespace Gameplay.Clans.Buildings.Ziggurat.View
{
	// Token: 0x02000AAB RID: 2731
	[Token(Token = "0x2000AAB")]
	public class ZigguratBuildingItemView : BaseBuildingItemView
	{
		// Token: 0x060041EC RID: 16876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041EC")]
		[Address(RVA = "0x90A0", Offset = "0x90A0", VA = "0x90A0", Slot = "7")]
		protected override void HandleActionButton(UserData ownerUserData, UserData loggedUser)
		{
		}

		// Token: 0x060041ED RID: 16877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041ED")]
		[Address(RVA = "0x90A1", Offset = "0x90A1", VA = "0x90A1")]
		public ZigguratBuildingItemView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Buildings_Ziggurat_View_ZigguratBuildingItemView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  iVar3 = *(int *)(param1 + 0x10);
		  if (*(int *)(iVar3 + 0xc) == 2) {
		    *(undefined4 *)(*(int *)(iVar3 + 0x10) + 0x38) = 2;
		    *(undefined4 *)(*(int *)(iVar3 + 0x14) + 0x38) = 3;
		    return;
		  }
		  uVar1 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  uVar2 = unnamed_function_2232(&StringLiteral_19434);
		  System_String__Concat(uVar1,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_Gameplay_Clans_Buildings_Ziggurat_View_ZigguratView_Init__);
		  func_ii_1050(uVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}
	}
}
