using System;
using Il2CppDummyDll;

namespace Gameplay.Combat.View.Spells
{
	// Token: 0x02000944 RID: 2372
	[Token(Token = "0x2000944")]
	public class CombatSpellButtonV2 : CombatSpellButton
	{
		// Token: 0x0600381C RID: 14364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600381C")]
		[Address(RVA = "0x87D3", Offset = "0x87D3", VA = "0x87D3", Slot = "8")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Combat_View_Spells_CombatSpellButtonV2__HandleDataChanged
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  int param1_00;
		  
		  if (DAT_ram_00a566e8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__get_Data__
		              );
		    DAT_ram_00a566e8 = '\x01';
		  }
		  param1_00 = *(int *)(*(int *)(param1 + 0x4c) + 0xc);
		  if (param1_00 != 0) {
		    param2_00 = Core_Extensions_Dict_SpellDicExt__GetIconAssetId(param1_00,0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66
		              (*(undefined4 *)(param1 + 0x20),param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600381D RID: 14365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600381D")]
		[Address(RVA = "0x87D4", Offset = "0x87D4", VA = "0x87D4", Slot = "16")]
		protected override void LoadImage()
		{
		/* --- GHIDRA: LoadImage ---
		void Gameplay_Combat_View_Spells_CombatSpellButtonV2__LoadImage(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a566e6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData___ctor__
		              );
		    DAT_ram_00a566e6 = '\x01';
		  }
		  HuaweiMobileServices_Drive_AbstractClientRequest___Il2CppFullySharedGenericType___GetMediaHttpUploader
		            (param1,
		             Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600381E RID: 14366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600381E")]
		[Address(RVA = "0x87D5", Offset = "0x87D5", VA = "0x87D5")]
		public CombatSpellButtonV2()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_Spells_CombatSpellButtonV2___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a566e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a566e9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x30,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}
	}
}
