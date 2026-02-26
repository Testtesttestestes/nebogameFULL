using System;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Gameplay.Combat.View.GameField.Hint
{
	// Token: 0x02000972 RID: 2418
	[Token(Token = "0x2000972")]
	[CreateAssetMenu(fileName = "HintPattern", menuName = "Heavens/HintPattern")]
	public class HintPatternSO : SerializedScriptableObject
	{
		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x0600398D RID: 14733 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B4D")]
		public PatternElement[,] Map
		{
			[Token(Token = "0x600398D")]
			[Address(RVA = "0x891E", Offset = "0x891E", VA = "0x891E")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600398E RID: 14734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600398E")]
		[Address(RVA = "0x891F", Offset = "0x891F", VA = "0x891F")]
		private void GeneratePattern(int x = 3, int y = 3)
		{
		/* --- GHIDRA: GeneratePattern ---
		undefined4
		Gameplay_Combat_View_GameField_Hint_HintPatternSO__GeneratePattern
		          (undefined4 param1,int param2,int param3,int param4,undefined4 param5)
		
		{
		  return *(undefined4 *)(param2 + (*(int *)(*(int *)(param2 + 8) + 8) * param3 + param4) * 4 + 0x10)
		  ;
		}
		*/

		}

		// Token: 0x0600398F RID: 14735 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600398F")]
		[Address(RVA = "0x8920", Offset = "0x8920", VA = "0x8920")]
		private static PatternElement DrawElement(Rect rect, PatternElement[,] array, int x, int y)
		{
			return null;
		}

		// Token: 0x06003990 RID: 14736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003990")]
		[Address(RVA = "0x8921", Offset = "0x8921", VA = "0x8921")]
		private static void DrawRect(Rect rect, PatternElement value)
		{
		/* --- GHIDRA: DrawRect ---
		void Gameplay_Combat_View_GameField_Hint_HintPatternSO__DrawRect(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a56767 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_GameField_Hint_PatternElement____TypeInfo);
		    DAT_ram_00a56767 = '\x01';
		  }
		  local_8 = 0x300000003;
		  uVar1 = unnamed_function_2396
		                    (Gameplay_Combat_View_GameField_Hint_PatternElement____TypeInfo,&local_8);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  UnityEngine_Tilemaps_TileBase__StartUpRef(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003991 RID: 14737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003991")]
		[Address(RVA = "0x8922", Offset = "0x8922", VA = "0x8922")]
		public HintPatternSO()
		{
		}

		// Token: 0x04001FDB RID: 8155
		[Token(Token = "0x4001FDB")]
		private const int DefaultPatternSize = 3;

		// Token: 0x04001FDC RID: 8156
		[Token(Token = "0x4001FDC")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private PatternElement[,] _map;

		// Token: 0x04001FDD RID: 8157
		[Token(Token = "0x4001FDD")]
		[FieldOffset(Offset = "0x0")]
		private static bool _lastValue;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Map ---
		void Gameplay_Combat_View_GameField_Hint_HintPatternSO__get_Map
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int local_8;
		  int local_4;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a56766 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_GameField_Hint_PatternElement____TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_GameField_Hint_PatternElement_TypeInfo);
		    DAT_ram_00a56766 = '\x01';
		  }
		  local_8 = param2;
		  local_4 = param3;
		  uVar2 = unnamed_function_2396
		                    (Gameplay_Combat_View_GameField_Hint_PatternElement____TypeInfo,&local_8);
		  *(undefined4 *)(param1 + 0x2c) = uVar2;
		  if ((0 < param2) && (0 < param3)) {
		    do {
		      iVar1 = 0;
		      do {
		        iVar3 = *(int *)(param1 + 0x2c);
		        uVar2 = unnamed_function_1417(Gameplay_Combat_View_GameField_Hint_PatternElement_TypeInfo);
		        *(undefined4 *)(iVar3 + (*(int *)(*(int *)(iVar3 + 8) + 8) * iVar4 + iVar1) * 4 + 0x10) =
		             uVar2;
		        iVar1 = iVar1 + 1;
		      } while (iVar1 != param3);
		      iVar4 = iVar4 + 1;
		    } while (iVar4 != param2);
		  }
		  return;
		}
		*/

}
