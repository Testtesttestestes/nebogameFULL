using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Common;
using Protocol.Dic;

namespace Gameplay.School.Model
{
	// Token: 0x02000647 RID: 1607
	[Token(Token = "0x2000647")]
	public class SchoolModel : AbstractModel
	{
		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060026E6 RID: 9958 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060026E7 RID: 9959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700074B")]
		[CanBeNull]
		public IDiscountHandler DiscountHandler
		{
			[Token(Token = "0x60026E6")]
			[Address(RVA = "0x781B", Offset = "0x781B", VA = "0x781B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026E7")]
			[Address(RVA = "0x781C", Offset = "0x781C", VA = "0x781C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060026E8 RID: 9960 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700074C")]
		public Dictionaries Dict
		{
			[Token(Token = "0x60026E8")]
			[Address(RVA = "0x781D", Offset = "0x781D", VA = "0x781D")]
			get
			{
				return null;
			}
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026E9")]
		[Address(RVA = "0x781E", Offset = "0x781E", VA = "0x781E")]
		public SchoolModel(UserData user, UserData loggedUser)
		{
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060026EA RID: 9962 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060026EB RID: 9963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700074D")]
		public UserData LoggedUser
		{
			[Token(Token = "0x60026EA")]
			[Address(RVA = "0x781F", Offset = "0x781F", VA = "0x781F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026EB")]
			[Address(RVA = "0x7820", Offset = "0x7820", VA = "0x7820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060026EC RID: 9964 RVA: 0x00007728 File Offset: 0x00005928
		// (set) Token: 0x060026ED RID: 9965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700074E")]
		public int RequestFlags
		{
			[Token(Token = "0x60026EC")]
			[Address(RVA = "0x7821", Offset = "0x7821", VA = "0x7821")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60026ED")]
			[Address(RVA = "0x7822", Offset = "0x7822", VA = "0x7822")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060026EE RID: 9966 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060026EF RID: 9967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700074F")]
		public List<SpellModifierInfo> Modifiers
		{
			[Token(Token = "0x60026EE")]
			[Address(RVA = "0x7823", Offset = "0x7823", VA = "0x7823")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026EF")]
			[Address(RVA = "0x7824", Offset = "0x7824", VA = "0x7824")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060026F0 RID: 9968 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060026F1 RID: 9969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000750")]
		public Dictionary<uint, SchoolSpellData> Spells
		{
			[Token(Token = "0x60026F0")]
			[Address(RVA = "0x7825", Offset = "0x7825", VA = "0x7825")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026F1")]
			[Address(RVA = "0x7826", Offset = "0x7826", VA = "0x7826")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060026F2 RID: 9970 RVA: 0x00007740 File Offset: 0x00005940
		[Token(Token = "0x17000751")]
		public double LearnCancelRecoilCoeff
		{
			[Token(Token = "0x60026F2")]
			[Address(RVA = "0x7827", Offset = "0x7827", VA = "0x7827")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026F3")]
		[Address(RVA = "0x7828", Offset = "0x7828", VA = "0x7828", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x04001554 RID: 5460
		[Token(Token = "0x4001554")]
		[FieldOffset(Offset = "0x10")]
		private readonly IDictProvider _dictProvider;
	}
}
