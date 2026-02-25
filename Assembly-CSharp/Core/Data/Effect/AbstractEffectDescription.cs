using System;
using System.Collections.Generic;
using Core.Data.Skills;
using Il2CppDummyDll;

namespace Core.Data.Effect
{
	// Token: 0x020010E8 RID: 4328
	[Token(Token = "0x20010E8")]
	public abstract class AbstractEffectDescription : IDisposable
	{
		// Token: 0x0600652D RID: 25901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600652D")]
		[Address(RVA = "0xB0FA", Offset = "0xB0FA", VA = "0xB0FA")]
		public void SetEffects(EffectData[] value)
		{
		}

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x0600652E RID: 25902 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600652F RID: 25903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700147C")]
		public string SourceText
		{
			[Token(Token = "0x600652E")]
			[Address(RVA = "0xB0FB", Offset = "0xB0FB", VA = "0xB0FB")]
			get
			{
				return null;
			}
			[Token(Token = "0x600652F")]
			[Address(RVA = "0xB0FC", Offset = "0xB0FC", VA = "0xB0FC")]
			set
			{
			}
		}

		// Token: 0x06006530 RID: 25904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006530")]
		[Address(RVA = "0xB0FD", Offset = "0xB0FD", VA = "0xB0FD", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06006531 RID: 25905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006531")]
		[Address(RVA = "0xB0FE", Offset = "0xB0FE", VA = "0xB0FE")]
		protected AbstractEffectDescription(string sourceText, EffectData[] effects, Skills userSkills)
		{
		}

		// Token: 0x06006532 RID: 25906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006532")]
		[Address(RVA = "0xB0FF", Offset = "0xB0FF", VA = "0xB0FF")]
		public void Reset()
		{
		}

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x06006533 RID: 25907 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700147D")]
		public string Text
		{
			[Token(Token = "0x6006533")]
			[Address(RVA = "0xB100", Offset = "0xB100", VA = "0xB100")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006534 RID: 25908 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006534")]
		[Address(RVA = "0xB101", Offset = "0xB101", VA = "0xB101", Slot = "5")]
		protected virtual string GetText(string text)
		{
			return null;
		}

		// Token: 0x06006535 RID: 25909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006535")]
		[Address(RVA = "0xB102", Offset = "0xB102", VA = "0xB102", Slot = "6")]
		protected virtual void WriteValue(Dictionary<string, string> source, uint effectId, string textVarName, string value)
		{
		}

		// Token: 0x06006536 RID: 25910
		[Token(Token = "0x6006536")]
		protected abstract string FormatUserSkillValue(long validValue, long rawValue);

		// Token: 0x0400361A RID: 13850
		[Token(Token = "0x400361A")]
		public const string CASTER_SKILLS_SCALER_KEY = "caster_skills_scaler_";

		// Token: 0x0400361B RID: 13851
		[Token(Token = "0x400361B")]
		[FieldOffset(Offset = "0x8")]
		private string _text;

		// Token: 0x0400361C RID: 13852
		[Token(Token = "0x400361C")]
		[FieldOffset(Offset = "0xC")]
		private string _sourceText;

		// Token: 0x0400361D RID: 13853
		[Token(Token = "0x400361D")]
		[FieldOffset(Offset = "0x10")]
		private EffectData[] _effects;

		// Token: 0x0400361E RID: 13854
		[Token(Token = "0x400361E")]
		[FieldOffset(Offset = "0x14")]
		private Skills _userSkills;
	}
}
