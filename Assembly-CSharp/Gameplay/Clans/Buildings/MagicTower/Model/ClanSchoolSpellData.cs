using System;
using Core.Data.Balance;
using Gameplay.School.Model;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;

namespace Gameplay.Clans.Buildings.MagicTower.Model
{
	// Token: 0x02000AB5 RID: 2741
	[Token(Token = "0x2000AB5")]
	public class ClanSchoolSpellData : SchoolSpellData
	{
		// Token: 0x06004225 RID: 16933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004225")]
		[Address(RVA = "0x90D9", Offset = "0x90D9", VA = "0x90D9")]
		public ClanSchoolSpellData(ShortSpellInfo shortSpellInfo, IBalanceSource treasury, Dictionaries dict)
		{
		/* --- GHIDRA: .ctor ---
		double Gameplay_Clans_Buildings_MagicTower_Model_ClanSchoolSpellData___ctor
		                 (undefined4 param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  double dVar3;
		  int *param1_00;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a5780a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21211);
		    DAT_ram_00a5780a = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar5 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80de333f;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80de333f:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  dVar3 = Core_Extensions_Dict_DictExt__GetIntParameter(uVar2,StringLiteral_21211,0);
		  return dVar3;
		}
		*/

		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06004226 RID: 16934 RVA: 0x0000CA68 File Offset: 0x0000AC68
		[Token(Token = "0x17000D07")]
		public override double PriceCoef
		{
			[Token(Token = "0x6004226")]
			[Address(RVA = "0x90DA", Offset = "0x90DA", VA = "0x90DA", Slot = "11")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06004227 RID: 16935 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D08")]
		public override ResourceSet LearnPrice
		{
			[Token(Token = "0x6004227")]
			[Address(RVA = "0x90DB", Offset = "0x90DB", VA = "0x90DB", Slot = "10")]
			get
			{
				return null;
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_PriceCoef ---
		undefined4
		Gameplay_Clans_Buildings_MagicTower_Model_ClanSchoolSpellData__get_PriceCoef
		          (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  double param2_00;
		  
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0xf4));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))(param1,uVar1);
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  if ((iVar2 == 0) || (iVar2 = func_ii_8746(param1,0), iVar2 == 0)) {
		    param2_00 = (double)(**(code **)((ulonglong)*(uint *)(*param1 + 0x118) * 4))
		                                  (param1,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x11c)));
		  }
		  else {
		    param2_00 = *(double *)(param1[0xd] + 0x20);
		  }
		  uVar3 = Protocol_Common_ResourceSet___ctor(*(undefined4 *)(param1[0xc] + 0x30),0);
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__Round(uVar3,param2_00,0);
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__SetValue(uVar3,0);
		  return uVar3;
		}
		*/

}
