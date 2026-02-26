using System;
using Core.Data.Skills;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Duel.View
{
	// Token: 0x0200085E RID: 2142
	[Token(Token = "0x200085E")]
	public class SkillsComparer : MonoBehaviour
	{
		// Token: 0x06003250 RID: 12880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003250")]
		[Address(RVA = "0x82A5", Offset = "0x82A5", VA = "0x82A5")]
		public void Init(SkillCollection leftSkills, SkillCollection rightSkills, Dictionaries dict)
		{
		}

		// Token: 0x06003251 RID: 12881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003251")]
		[Address(RVA = "0x82A6", Offset = "0x82A6", VA = "0x82A6")]
		public SkillsComparer()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Duel_View_SkillsComparer___ctor
		               (int param1,float param2,float param3,undefined4 param4)
		
		{
		  float fVar1;
		  int iVar2;
		  undefined4 param2_00;
		  undefined4 uVar3;
		  float4 local_4;
		  
		  uVar3 = *(undefined4 *)(param1 + 0x10);
		  local_4 = (float4)param2;
		  fVar1 = UnityEngine_Camera__set_orthographicSize(param2,param2 + param3,0);
		  Gameplay_Duel_View_SkillsComparerPowerBars__Init(param1,uVar3,fVar1,param1);
		  uVar3 = *(undefined4 *)(param1 + 0x14);
		  fVar1 = UnityEngine_Camera__set_orthographicSize(param3,param2 + param3,0);
		  Gameplay_Duel_View_SkillsComparerPowerBars__Init(param1,uVar3,fVar1,param1);
		  iVar2 = System_Double__CompareTo(&local_4,param3,0);
		  if (iVar2 < 0) {
		    uVar3 = *(undefined4 *)(param1 + 0x28);
		    func_ii_7050(*(undefined4 *)(param1 + 0x18),*(undefined4 *)(param1 + 0x2c),0);
		    func_ii_7050(*(undefined4 *)(param1 + 0x1c),uVar3,0);
		    param2_00 = *(undefined4 *)(param1 + 0x24);
		    uVar3 = *(undefined4 *)(param1 + 0x20);
		  }
		  else if (iVar2 == 0) {
		    uVar3 = *(undefined4 *)(param1 + 0x30);
		    func_ii_7050(*(undefined4 *)(param1 + 0x18),uVar3,0);
		    func_ii_7050(*(undefined4 *)(param1 + 0x1c),uVar3,0);
		    param2_00 = *(undefined4 *)(param1 + 0x20);
		    uVar3 = param2_00;
		  }
		  else {
		    uVar3 = *(undefined4 *)(param1 + 0x2c);
		    func_ii_7050(*(undefined4 *)(param1 + 0x18),*(undefined4 *)(param1 + 0x28),0);
		    func_ii_7050(*(undefined4 *)(param1 + 0x1c),uVar3,0);
		    param2_00 = *(undefined4 *)(param1 + 0x20);
		    uVar3 = *(undefined4 *)(param1 + 0x24);
		  }
		  func_ii_7050(*(undefined4 *)(param1 + 0x10),param2_00,0);
		  func_ii_7050(*(undefined4 *)(param1 + 0x14),uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x04001B8C RID: 7052
		[Token(Token = "0x4001B8C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SkillCompareRow _rowPrefab;

		// Token: 0x04001B8D RID: 7053
		[Token(Token = "0x4001B8D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04001B8E RID: 7054
		[Token(Token = "0x4001B8E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SkillsComparerPowerBars _powerBars;
	}
}
