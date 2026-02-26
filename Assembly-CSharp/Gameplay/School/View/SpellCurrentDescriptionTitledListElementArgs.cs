using System;
using Gameplay.School.Model;
using Il2CppDummyDll;
using UI.Elements.RightPanel.TitledList;

namespace Gameplay.School.View
{
	// Token: 0x02000642 RID: 1602
	[Token(Token = "0x2000642")]
	public class SpellCurrentDescriptionTitledListElementArgs : BaseTitledListElementArgs
	{
		// Token: 0x060026DA RID: 9946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026DA")]
		[Address(RVA = "0x780F", Offset = "0x780F", VA = "0x780F")]
		public SpellCurrentDescriptionTitledListElementArgs(SchoolSpellData spellData)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_School_View_SpellCurrentDescriptionTitledListElementArgs___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5a04a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    DAT_ram_00a5a04a = '\x01';
		  }
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (*(undefined4 *)(param1 + 0x10),param2,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04001548 RID: 5448
		[Token(Token = "0x4001548")]
		[FieldOffset(Offset = "0x8")]
		public SchoolSpellData SpellData;
	}
}
