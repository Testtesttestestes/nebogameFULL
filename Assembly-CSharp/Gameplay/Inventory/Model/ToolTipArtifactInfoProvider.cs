using System;
using Core.Data;
using Il2CppDummyDll;

namespace Gameplay.Inventory.Model
{
	// Token: 0x020006AB RID: 1707
	[Token(Token = "0x20006AB")]
	public class ToolTipArtifactInfoProvider : ArtifactInfoProvider
	{
		// Token: 0x0600294D RID: 10573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600294D")]
		[Address(RVA = "0x7A55", Offset = "0x7A55", VA = "0x7A55")]
		public ToolTipArtifactInfoProvider(UserData user, UserData loggedUser, ArtifactData artifact)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_Model_ToolTipArtifactInfoProvider___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_14;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a167 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		    DAT_ram_00a5a167 = '\x01';
		  }
		  if (*(int *)(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		  }
		  local_c = 0x3f8000003f800000;
		  local_20 = 0x3f8000003f800000;
		  local_14 = 0x3f8000003f800000;
		  local_28 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_4,&local_28,0);
		  *(undefined4 *)(param1 + 0x24) = local_4;
		  Core_Data_InfoRows_AbstractUserInformationProvider__Dispose(param1,param2,param3,0);
		  *(undefined4 *)(param1 + 0x20) = param4;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_Model_ToolTipArtifactInfoProvider___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_14;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a167 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		    DAT_ram_00a5a167 = '\x01';
		  }
		  if (*(int *)(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		  }
		  local_c = 0x3f8000003f800000;
		  local_20 = 0x3f8000003f800000;
		  local_14 = 0x3f8000003f800000;
		  local_28 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_4,&local_28,0);
		  *(undefined4 *)(param1 + 0x24) = local_4;
		  Core_Data_InfoRows_AbstractUserInformationProvider__Dispose(param1,param2,param3,0);
		  *(undefined4 *)(param1 + 0x20) = param4;
		  return;
		}
		*/

		}

		// Token: 0x0600294E RID: 10574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600294E")]
		[Address(RVA = "0x7A56", Offset = "0x7A56", VA = "0x7A56")]
		public ToolTipArtifactInfoProvider(UserData user, UserData loggedUser, ArtikulData artikul)
		{
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600294F")]
		[Address(RVA = "0x7A57", Offset = "0x7A57", VA = "0x7A57")]
		private void DefineSpecialProps()
		{
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002950")]
		[Address(RVA = "0x7A58", Offset = "0x7A58", VA = "0x7A58", Slot = "11")]
		protected override void HandleCollectionRow()
		{
		}
	}
}
