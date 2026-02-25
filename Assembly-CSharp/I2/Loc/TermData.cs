using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200139C RID: 5020
	[Token(Token = "0x200139C")]
	[Serializable]
	public class TermData
	{
		// Token: 0x06007790 RID: 30608 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007790")]
		[Address(RVA = "0xC0F1", Offset = "0xC0F1", VA = "0xC0F1")]
		public string GetTranslation(int idx, [Optional] string specialization, bool editMode = false)
		{
			return null;
		}

		// Token: 0x06007791 RID: 30609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007791")]
		[Address(RVA = "0x361E", Offset = "0x361E", VA = "0x361E")]
		public void SetTranslation(int idx, string translation, [Optional] string specialization)
		{
		}

		// Token: 0x06007792 RID: 30610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007792")]
		[Address(RVA = "0xC0F2", Offset = "0xC0F2", VA = "0xC0F2")]
		public void RemoveSpecialization(string specialization)
		{
		}

		// Token: 0x06007793 RID: 30611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007793")]
		[Address(RVA = "0xC0F3", Offset = "0xC0F3", VA = "0xC0F3")]
		public void RemoveSpecialization(int idx, string specialization)
		{
		}

		// Token: 0x06007794 RID: 30612 RVA: 0x00015F18 File Offset: 0x00014118
		[Token(Token = "0x6007794")]
		[Address(RVA = "0xC0F4", Offset = "0xC0F4", VA = "0xC0F4")]
		public bool IsAutoTranslated(int idx, bool IsTouch)
		{
			return default(bool);
		}

		// Token: 0x06007795 RID: 30613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007795")]
		[Address(RVA = "0xC0F5", Offset = "0xC0F5", VA = "0xC0F5")]
		public void Validate()
		{
		}

		// Token: 0x06007796 RID: 30614 RVA: 0x00015F30 File Offset: 0x00014130
		[Token(Token = "0x6007796")]
		[Address(RVA = "0x35EC", Offset = "0x35EC", VA = "0x35EC")]
		public bool IsTerm(string name, bool allowCategoryMistmatch)
		{
			return default(bool);
		}

		// Token: 0x06007797 RID: 30615 RVA: 0x00015F48 File Offset: 0x00014148
		[Token(Token = "0x6007797")]
		[Address(RVA = "0xC0F6", Offset = "0xC0F6", VA = "0xC0F6")]
		public bool HasSpecializations()
		{
			return default(bool);
		}

		// Token: 0x06007798 RID: 30616 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007798")]
		[Address(RVA = "0x35F2", Offset = "0x35F2", VA = "0x35F2")]
		public List<string> GetAllSpecializations()
		{
			return null;
		}

		// Token: 0x06007799 RID: 30617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007799")]
		[Address(RVA = "0xC0F7", Offset = "0xC0F7", VA = "0xC0F7")]
		public TermData()
		{
		}

		// Token: 0x04003E6A RID: 15978
		[Token(Token = "0x4003E6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Term;

		// Token: 0x04003E6B RID: 15979
		[Token(Token = "0x4003E6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public eTermType TermType;

		// Token: 0x04003E6C RID: 15980
		[Token(Token = "0x4003E6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[NonSerialized]
		public string Description;

		// Token: 0x04003E6D RID: 15981
		[Token(Token = "0x4003E6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public string[] Languages;

		// Token: 0x04003E6E RID: 15982
		[Token(Token = "0x4003E6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte[] Flags;

		// Token: 0x04003E6F RID: 15983
		[Token(Token = "0x4003E6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private string[] Languages_Touch;
	}
}
