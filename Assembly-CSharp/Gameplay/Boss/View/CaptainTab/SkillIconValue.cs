using System;
using Core.Data.Skills;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B86 RID: 2950
	[Token(Token = "0x2000B86")]
	[RequireComponent(typeof(SimpleIconValue))]
	public class SkillIconValue : MonoBehaviour
	{
		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x060047B5 RID: 18357 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E57")]
		protected SimpleIconValue SimpleIconValue
		{
			[Token(Token = "0x60047B5")]
			[Address(RVA = "0x9641", Offset = "0x9641", VA = "0x9641")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x060047B6 RID: 18358 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047B7 RID: 18359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E58")]
		public Skill Skill
		{
			[Token(Token = "0x60047B6")]
			[Address(RVA = "0x9642", Offset = "0x9642", VA = "0x9642")]
			get
			{
				return null;
			}
			[Token(Token = "0x60047B7")]
			[Address(RVA = "0x1BA1", Offset = "0x1BA1", VA = "0x1BA1")]
			set
			{
			}
		}

		// Token: 0x060047B8 RID: 18360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047B8")]
		[Address(RVA = "0x9643", Offset = "0x9643", VA = "0x9643")]
		public SkillIconValue()
		{
		}

		// Token: 0x0400276A RID: 10090
		[Token(Token = "0x400276A")]
		[FieldOffset(Offset = "0x10")]
		private SimpleIconValue _simpleIconValue;

		// Token: 0x0400276B RID: 10091
		[Token(Token = "0x400276B")]
		[FieldOffset(Offset = "0x14")]
		private Skill _skill;
	}
}
