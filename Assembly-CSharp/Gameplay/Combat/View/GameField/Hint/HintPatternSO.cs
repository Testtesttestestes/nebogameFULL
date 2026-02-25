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
}
