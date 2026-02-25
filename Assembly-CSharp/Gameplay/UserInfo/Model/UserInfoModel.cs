using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Skills;
using Core.Dict;
using Core.Dict.DictWrappers.Wrappers;
using Core.Gameplay;
using Gameplay.Inventory.Model;
using Gameplay.User.Model;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;

namespace Gameplay.UserInfo.Model
{
	// Token: 0x02000413 RID: 1043
	[Token(Token = "0x2000413")]
	public class UserInfoModel : AbstractModel
	{
		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x0600186C RID: 6252 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600186D RID: 6253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000451")]
		public UserModel UserModel
		{
			[Token(Token = "0x600186C")]
			[Address(RVA = "0x6A0C", Offset = "0x6A0C", VA = "0x6A0C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600186D")]
			[Address(RVA = "0x6A0D", Offset = "0x6A0D", VA = "0x6A0D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000452")]
		public UserData LoggedUser
		{
			[Token(Token = "0x600186E")]
			[Address(RVA = "0x6A0E", Offset = "0x6A0E", VA = "0x6A0E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x0600186F RID: 6255 RVA: 0x000056D0 File Offset: 0x000038D0
		[Token(Token = "0x17000453")]
		public bool IsGuest
		{
			[Token(Token = "0x600186F")]
			[Address(RVA = "0x6A0F", Offset = "0x6A0F", VA = "0x6A0F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001871 RID: 6257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000454")]
		public IGame Game
		{
			[Token(Token = "0x6001870")]
			[Address(RVA = "0x6A10", Offset = "0x6A10", VA = "0x6A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001871")]
			[Address(RVA = "0x6A11", Offset = "0x6A11", VA = "0x6A11")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000455")]
		public ServiceOptionsDic PriceOfChangeGenderAndCult
		{
			[Token(Token = "0x6001872")]
			[Address(RVA = "0x6A12", Offset = "0x6A12", VA = "0x6A12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001874 RID: 6260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000456")]
		public ResourceSet PriceOfChangeNick
		{
			[Token(Token = "0x6001873")]
			[Address(RVA = "0x6A13", Offset = "0x6A13", VA = "0x6A13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001874")]
			[Address(RVA = "0x6A14", Offset = "0x6A14", VA = "0x6A14")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001876 RID: 6262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000457")]
		public AprDicWrapper CurrentSelectedApr
		{
			[Token(Token = "0x6001875")]
			[Address(RVA = "0x6A15", Offset = "0x6A15", VA = "0x6A15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001876")]
			[Address(RVA = "0x6A16", Offset = "0x6A16", VA = "0x6A16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001877")]
		[Address(RVA = "0x6A17", Offset = "0x6A17", VA = "0x6A17", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001878")]
		[Address(RVA = "0x6A18", Offset = "0x6A18", VA = "0x6A18")]
		public UserInfoModel(IDictProvider dictProvider, UserData user, UserModel userModel, IGame gameInstance)
		{
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x000056E8 File Offset: 0x000038E8
		[Token(Token = "0x6001879")]
		[Address(RVA = "0x6A19", Offset = "0x6A19", VA = "0x6A19")]
		public bool TryGetExpRemainOnNextLevel(out ulong value)
		{
			return default(bool);
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x00005700 File Offset: 0x00003900
		[Token(Token = "0x17000458")]
		public float ExperienceProgress
		{
			[Token(Token = "0x600187A")]
			[Address(RVA = "0x6A1A", Offset = "0x6A1A", VA = "0x6A1A")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600187B")]
		[Address(RVA = "0x6A1B", Offset = "0x6A1B", VA = "0x6A1B")]
		public static SkillCollection GetUserSkills(SkillCollection skills)
		{
			return null;
		}

		// Token: 0x04000D10 RID: 3344
		[Token(Token = "0x4000D10")]
		[FieldOffset(Offset = "0x10")]
		public UserSkillsData SkillsData;

		// Token: 0x04000D11 RID: 3345
		[Token(Token = "0x4000D11")]
		[FieldOffset(Offset = "0x14")]
		public InventoryModel InventoryUserModel;

		// Token: 0x04000D12 RID: 3346
		[Token(Token = "0x4000D12")]
		[FieldOffset(Offset = "0x18")]
		public RepeatedField<CultDic> AvailableCults;

		// Token: 0x04000D13 RID: 3347
		[Token(Token = "0x4000D13")]
		[FieldOffset(Offset = "0x1C")]
		public SkillCollection UserSkills;

		// Token: 0x04000D14 RID: 3348
		[Token(Token = "0x4000D14")]
		[FieldOffset(Offset = "0x20")]
		public List<GenderDic> AvailableGenders;

		// Token: 0x04000D15 RID: 3349
		[Token(Token = "0x4000D15")]
		[FieldOffset(Offset = "0x24")]
		public Dictionary<Genders, Dictionary<uint, AprDicWrapper>> AvailableAprsByGender;

		// Token: 0x04000D17 RID: 3351
		[Token(Token = "0x4000D17")]
		[FieldOffset(Offset = "0x2C")]
		public readonly IDictProvider DictProvider;

		// Token: 0x02000414 RID: 1044
		[Token(Token = "0x2000414")]
		public class UserSkill : Skill
		{
			// Token: 0x0600187C RID: 6268 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600187C")]
			[Address(RVA = "0x6A1C", Offset = "0x6A1C", VA = "0x6A1C")]
			public UserSkill()
			{
			}

			// Token: 0x04000D1A RID: 3354
			[Token(Token = "0x4000D1A")]
			[FieldOffset(Offset = "0x18")]
			public UserSkillDic SkillDic;
		}
	}
}
