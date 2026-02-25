using System;
using Core.Data.Effect;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Combat
{
	// Token: 0x02000159 RID: 345
	[Token(Token = "0x2000159")]
	public class CombatLongEffectToolTipItemView : MonoBehaviour
	{
		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x000037E0 File Offset: 0x000019E0
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000149")]
		public bool BackgroundEnabled
		{
			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x5D41", Offset = "0x5D41", VA = "0x5D41")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x5D42", Offset = "0x5D42", VA = "0x5D42")]
			set
			{
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x000037F8 File Offset: 0x000019F8
		// (set) Token: 0x060009E4 RID: 2532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014A")]
		public int Index
		{
			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x5D43", Offset = "0x5D43", VA = "0x5D43")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x5D44", Offset = "0x5D44", VA = "0x5D44")]
			set
			{
			}
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x5D45", Offset = "0x5D45", VA = "0x5D45")]
		private void HandleIndexChanged()
		{
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014B")]
		public EffectData Data
		{
			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x5D46", Offset = "0x5D46", VA = "0x5D46")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x5D47", Offset = "0x5D47", VA = "0x5D47")]
			set
			{
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x5D48", Offset = "0x5D48", VA = "0x5D48")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x5D49", Offset = "0x5D49", VA = "0x5D49")]
		public CombatLongEffectToolTipItemView()
		{
		}

		// Token: 0x0400040B RID: 1035
		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400040C RID: 1036
		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x0400040D RID: 1037
		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _level;

		// Token: 0x0400040E RID: 1038
		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _turns;

		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x400040F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _background;

		// Token: 0x04000410 RID: 1040
		[Token(Token = "0x4000410")]
		public const string VALUE_TEXT_VAR = "value";

		// Token: 0x04000411 RID: 1041
		[Token(Token = "0x4000411")]
		[FieldOffset(Offset = "0x24")]
		private bool _backgroundEnabled;

		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x28")]
		private int _index;

		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x2C")]
		private EffectData _data;
	}
}
