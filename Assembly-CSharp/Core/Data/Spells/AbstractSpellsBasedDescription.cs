using System;
using System.Runtime.InteropServices;
using Core.Data.Effect;
using Core.Data.Skills;
using Il2CppDummyDll;

namespace Core.Data.Spells
{
	// Token: 0x020010CD RID: 4301
	[Token(Token = "0x20010CD")]
	public abstract class AbstractSpellsBasedDescription : IDisposable
	{
		// Token: 0x060064B9 RID: 25785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064B9")]
		[Address(RVA = "0xB0A1", Offset = "0xB0A1", VA = "0xB0A1", Slot = "5")]
		public virtual void Dispose()
		{
		}

		// Token: 0x060064BA RID: 25786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064BA")]
		[Address(RVA = "0xB0A2", Offset = "0xB0A2", VA = "0xB0A2")]
		protected AbstractSpellsBasedDescription(string sourceText, SpellData[] spells, [Optional] Skills userSkills)
		{
		}

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x060064BB RID: 25787 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001461")]
		public string Text
		{
			[Token(Token = "0x60064BB")]
			[Address(RVA = "0xB0A3", Offset = "0xB0A3", VA = "0xB0A3")]
			get
			{
				return null;
			}
		}

		// Token: 0x060064BC RID: 25788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064BC")]
		[Address(RVA = "0xB0A4", Offset = "0xB0A4", VA = "0xB0A4")]
		public void Reset()
		{
		}

		// Token: 0x060064BD RID: 25789 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064BD")]
		[Address(RVA = "0xB0A5", Offset = "0xB0A5", VA = "0xB0A5", Slot = "6")]
		protected virtual string GetText(string text)
		{
			return null;
		}

		// Token: 0x040035BF RID: 13759
		[Token(Token = "0x40035BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string _text;

		// Token: 0x040035C0 RID: 13760
		[Token(Token = "0x40035C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private string _sourceText;

		// Token: 0x040035C1 RID: 13761
		[Token(Token = "0x40035C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private SpellData[] _spells;

		// Token: 0x040035C2 RID: 13762
		[Token(Token = "0x40035C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected AbstractEffectDescription _effectsDescription;
	}
}
