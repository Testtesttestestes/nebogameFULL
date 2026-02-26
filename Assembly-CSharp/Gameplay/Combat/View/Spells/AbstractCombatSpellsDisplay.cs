using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Combat.View.Spells
{
	// Token: 0x02000940 RID: 2368
	[Token(Token = "0x2000940")]
	public abstract class AbstractCombatSpellsDisplay : MonoBehaviour, ICombatSpellDisplay
	{
		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06003808 RID: 14344 RVA: 0x0000B3A0 File Offset: 0x000095A0
		// (set) Token: 0x06003809 RID: 14345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B0F")]
		public virtual int Count
		{
			[Token(Token = "0x6003808")]
			[Address(RVA = "0x87C2", Offset = "0x87C2", VA = "0x87C2", Slot = "8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003809")]
			[Address(RVA = "0x87C3", Offset = "0x87C3", VA = "0x87C3", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x0600380A RID: 14346
		[Token(Token = "0x600380A")]
		protected abstract void HandleCountChanged();

		// Token: 0x0600380B RID: 14347
		[Token(Token = "0x600380B")]
		public abstract CombatSpellButton GetNexButton();

		// Token: 0x0600380C RID: 14348
		[Token(Token = "0x600380C")]
		public abstract void Reset();

		// Token: 0x0600380D RID: 14349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600380D")]
		[Address(RVA = "0x87C4", Offset = "0x87C4", VA = "0x87C4")]
		protected AbstractCombatSpellsDisplay()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_Spells_AbstractCombatSpellsDisplay___ctor(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a566db == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__HandleDataChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__get_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    DAT_ram_00a566db = '\x01';
		  }
		  Gameplay_Combat_View_Spells_AbstractCombatSpellButton_object___GetData
		            (param1,
		             Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__HandleDataChanged__
		            );
		  if (*(int *)(param1[0x13] + 0x2c) != 0) {
		    param1_00 = Core_Extensions_Dict_ArtikulDicExt__GetPetIconAssetId
		                          (*(undefined4 *)(*(int *)(*(int *)(param1[0x13] + 0x2c) + 8) + 0x10),0);
		    iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                      (param1_00,0);
		    if (iVar1 != 0) {
		      param1_00 = Core_Extensions_Dict_IsleInfoDictExt__GetBackgroundImageAssetId
		                            (*(undefined4 *)(*(int *)(param1[0x13] + 0x2c) + 0x14),0);
		    }
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1[0x17],param1_00,0);
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))(param1,*(undefined4 *)(*param1 + 0x13c));
		  return;
		}
		*/

		}

		// Token: 0x04001EFE RID: 7934
		[Token(Token = "0x4001EFE")]
		[FieldOffset(Offset = "0x10")]
		private int _count;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Count ---
		void Gameplay_Combat_View_Spells_AbstractCombatSpellsDisplay__get_Count
		               (int *param1,int param2,undefined4 param3)
		
		{
		  if (param2 != param1[4]) {
		    if (param2 < 1) {
		      param2 = 0;
		    }
		    param1[4] = param2;
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		              (param1,*(undefined4 *)(*param1 + 0x114));
		  }
		  return;
		}
		*/

}
