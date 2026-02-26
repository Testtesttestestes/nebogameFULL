using System;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.GenericList;
using UnityEngine;

namespace UI.Elements.Buildings
{
	// Token: 0x0200024C RID: 588
	[Token(Token = "0x200024C")]
	public class SpellList : SelectorGenericList<SpellListArgs, SpellItem, SpellItemArgs>
	{
		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000E5A RID: 3674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001EF")]
		public string Title
		{
			[Token(Token = "0x6000E59")]
			[Address(RVA = "0x60E0", Offset = "0x60E0", VA = "0x60E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E5A")]
			[Address(RVA = "0x60E1", Offset = "0x60E1", VA = "0x60E1")]
			set
			{
			}
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5B")]
		[Address(RVA = "0x60E2", Offset = "0x60E2", VA = "0x60E2")]
		public SpellList()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Elements_Buildings_SpellList___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a639b4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_GenericList_SelectedGenericListArgs_SpellItemArgs___ctor__);
		    DAT_ram_00a639b4 = '\x01';
		  }
		  UI_Elements_GenericList_SelectableListElement_object___get_Data
		            (param1,Method_UI_Elements_GenericList_SelectedGenericListArgs_SpellItemArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x04000729 RID: 1833
		[Token(Token = "0x4000729")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _title;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Title ---
		void UI_Elements_Buildings_SpellList__get_Title(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x2c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x2c),param2,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/


		/* --- GHIDRA: set_Title ---
		void UI_Elements_Buildings_SpellList__set_Title(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a639b3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectorGenericList_SpellListArgs__SpellItem__SpellItemArgs___ctor__
		              );
		    DAT_ram_00a639b3 = '\x01';
		  }
		  UI_Elements_GenericList_SelectedGenericListElement_object___set_Selected
		            (param1,
		             Method_UI_Elements_GenericList_SelectorGenericList_SpellListArgs__SpellItem__SpellItemArgs___ctor__
		            );
		  return;
		}
		*/

}
