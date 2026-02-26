using System;
using AssetContent.Loaders;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.RightPanel.TitledList;
using UnityEngine;

namespace Gameplay.School.View
{
	// Token: 0x02000643 RID: 1603
	[Token(Token = "0x2000643")]
	public class SpellTitle : CustomTitle
	{
		// Token: 0x17000747 RID: 1863
		// (set) Token: 0x060026DB RID: 9947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000747")]
		public string ImageUrl
		{
			[Token(Token = "0x60026DB")]
			[Address(RVA = "0x7810", Offset = "0x7810", VA = "0x7810")]
			set
			{
			}
		}

		// Token: 0x17000748 RID: 1864
		// (set) Token: 0x060026DC RID: 9948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000748")]
		public string Title
		{
			[Token(Token = "0x60026DC")]
			[Address(RVA = "0x7811", Offset = "0x7811", VA = "0x7811")]
			set
			{
			}
		}

		// Token: 0x17000749 RID: 1865
		// (set) Token: 0x060026DD RID: 9949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000749")]
		public int Level
		{
			[Token(Token = "0x60026DD")]
			[Address(RVA = "0x7812", Offset = "0x7812", VA = "0x7812")]
			set
			{
			}
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026DE")]
		[Address(RVA = "0x7813", Offset = "0x7813", VA = "0x7813")]
		public SpellTitle()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_School_View_SpellTitle___ctor(undefined4 param1,int param2,undefined4 param3)
		
		{
		  Gameplay_School_View_SpellUpgradeRequirementsTitledListElement__OnInit
		            (param1,*(undefined4 *)(param2 + 8),*(undefined4 *)(param2 + 0xc),
		             *(undefined4 *)(param2 + 0x10),param2);
		  return;
		}
		*/

		}

		// Token: 0x04001549 RID: 5449
		[Token(Token = "0x4001549")]
		private const string SPELL_LEVEL = "SCHOOL/SPELL/LEVEL";

		// Token: 0x0400154A RID: 5450
		[Token(Token = "0x400154A")]
		private const string LEVEL_TAG = "value";

		// Token: 0x0400154B RID: 5451
		[Token(Token = "0x400154B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImageLoader _imageLoader;

		// Token: 0x0400154C RID: 5452
		[Token(Token = "0x400154C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400154D RID: 5453
		[Token(Token = "0x400154D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _level;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Title ---
		void Gameplay_School_View_SpellTitle__set_Title(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  int *piVar2;
		  int iVar3;
		  undefined4 local_4;
		  
		  local_4 = param2;
		  if (DAT_ram_00a5a04b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13729);
		    DAT_ram_00a5a04b = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x18);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13729,1,0,1,0,0,0,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  param3_00 = func_ii_4443(&local_4,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_28217,param3_00,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar1 = Core_GameLocalization__GetTranslation(uVar1,param1_00,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

}
