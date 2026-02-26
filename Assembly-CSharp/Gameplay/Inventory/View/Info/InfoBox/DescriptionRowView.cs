using System;
using Il2CppDummyDll;

namespace Gameplay.Inventory.View.Info.InfoBox
{
	// Token: 0x02000678 RID: 1656
	[Token(Token = "0x2000678")]
	public class DescriptionRowView : TitleRowView
	{
		// Token: 0x06002825 RID: 10277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002825")]
		[Address(RVA = "0x794A", Offset = "0x794A", VA = "0x794A", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002826")]
		[Address(RVA = "0x794B", Offset = "0x794B", VA = "0x794B")]
		public DescriptionRowView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_View_Info_InfoBox_DescriptionRowView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5a0da == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ValueRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2003);
		    DAT_ram_00a5a0da = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x20);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Core_Data_InfoRows_ValueRow_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Core_Data_InfoRows_ValueRow_TypeInfo + 0xb8) * 4 + -4) !=
		        Core_Data_InfoRows_ValueRow_TypeInfo)) {
		      System_Activator__CreateInstance(param1_00,Core_Data_InfoRows_ValueRow_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (((param1_00[6] != 0) || (param1_00[8] != 0)) || (*(longlong *)(param1_00 + 10) != 0)) {
		    param2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(param2,StringLiteral_2003,0);
		  }
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x10),param2,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/

		}
	}
}
