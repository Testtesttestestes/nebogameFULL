using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Il2CppDummyDll;
using MVC;
using Protocol.DailyQuests;
using Protocol.Dic;
using Utils;

namespace Gameplay.DailyQuests.Model
{
	// Token: 0x0200087A RID: 2170
	[Token(Token = "0x200087A")]
	public class DailyQuestsModel : AbstractModel
	{
		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06003300 RID: 13056 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003301 RID: 13057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A18")]
		public List<IDailyQuest> CurrentDailyQuests
		{
			[Token(Token = "0x6003300")]
			[Address(RVA = "0x8352", Offset = "0x8352", VA = "0x8352")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003301")]
			[Address(RVA = "0x8353", Offset = "0x8353", VA = "0x8353")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06003302 RID: 13058 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003303 RID: 13059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A19")]
		public List<IGoal> CurrentGoals
		{
			[Token(Token = "0x6003302")]
			[Address(RVA = "0x8354", Offset = "0x8354", VA = "0x8354")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003303")]
			[Address(RVA = "0x8355", Offset = "0x8355", VA = "0x8355")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06003304 RID: 13060 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003305 RID: 13061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A1A")]
		public IList<DailyQuestCategoriesDic> Categories
		{
			[Token(Token = "0x6003304")]
			[Address(RVA = "0x8356", Offset = "0x8356", VA = "0x8356")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003305")]
			[Address(RVA = "0x8357", Offset = "0x8357", VA = "0x8357")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x0000A500 File Offset: 0x00008700
		[Token(Token = "0x6003306")]
		[Address(RVA = "0x8358", Offset = "0x8358", VA = "0x8358")]
		public int GetCompletedQuestsWithPendingRewardCount()
		{
			return 0;
		}

		// Token: 0x06003307 RID: 13063 RVA: 0x0000A518 File Offset: 0x00008718
		[Token(Token = "0x6003307")]
		[Address(RVA = "0x8359", Offset = "0x8359", VA = "0x8359")]
		public int GetCompletedQuestsWithPendingRewardCount(uint categoryId)
		{
			return 0;
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x0000A530 File Offset: 0x00008730
		[Token(Token = "0x6003308")]
		[Address(RVA = "0x835A", Offset = "0x835A", VA = "0x835A")]
		public int GetNotCompletedQuestsCount(uint categoryId)
		{
			return 0;
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003309")]
		[Address(RVA = "0x835B", Offset = "0x835B", VA = "0x835B", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600330A")]
		[Address(RVA = "0x835C", Offset = "0x835C", VA = "0x835C")]
		public DailyQuestsModel(UserData user, IDictProvider dictProvider, IGame game)
		{
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600330B")]
		[Address(RVA = "0x835D", Offset = "0x835D", VA = "0x835D")]
		private void PopulateCategories()
		{
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600330C")]
		[Address(RVA = "0x835E", Offset = "0x835E", VA = "0x835E")]
		private IDailyQuest CreateDailyQuest(ProtoGetQuestsAns.Types.UserQuest quest)
		{
			return null;
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600330D")]
		[Address(RVA = "0x835F", Offset = "0x835F", VA = "0x835F")]
		private IGoal CreateGoal(ProtoGetQuestsAns.Types.UserQuest quest)
		{
			return null;
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600330E")]
		[Address(RVA = "0x8360", Offset = "0x8360", VA = "0x8360")]
		public void RemoveGoals(IList<IGoal> goals)
		{
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600330F")]
		[Address(RVA = "0x8361", Offset = "0x8361", VA = "0x8361")]
		public void ResetDailyQuestsCategories()
		{
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003310")]
		[Address(RVA = "0x8362", Offset = "0x8362", VA = "0x8362")]
		public void PopulateGoals(IEnumerable<ProtoGetQuestsAns.Types.UserQuest> userDailyQuests)
		{
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003311")]
		[Address(RVA = "0x8363", Offset = "0x8363", VA = "0x8363")]
		public void PopulateDailyQuests(IEnumerable<ProtoGetQuestsAns.Types.UserQuest> userDailyQuests)
		{
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003312")]
		[Address(RVA = "0x8364", Offset = "0x8364", VA = "0x8364")]
		public IDailyQuest[] AddDailyQuests(IEnumerable<ProtoGetQuestsAns.Types.UserQuest> userDailyQuests)
		{
			return null;
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003313")]
		[Address(RVA = "0x8365", Offset = "0x8365", VA = "0x8365")]
		public IGoal[] AddGoals(IEnumerable<ProtoGetQuestsAns.Types.UserQuest> userDailyQuests)
		{
			return null;
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003314")]
		[Address(RVA = "0x8366", Offset = "0x8366", VA = "0x8366")]
		public IDailyQuest GetQuest(uint id)
		{
			return null;
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003315")]
		[Address(RVA = "0x8367", Offset = "0x8367", VA = "0x8367")]
		public IGoal GetGoal(uint id)
		{
			return null;
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003316")]
		[Address(RVA = "0x8368", Offset = "0x8368", VA = "0x8368")]
		public List<IQuest> GetQuestsByCategory(uint categoryId, bool activeOnly = false)
		{
			return null;
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003317")]
		[Address(RVA = "0x8369", Offset = "0x8369", VA = "0x8369")]
		public BackTime GetLowestBackTime()
		{
			return null;
		}

		// Token: 0x04001BE9 RID: 7145
		[Token(Token = "0x4001BE9")]
		[FieldOffset(Offset = "0xC")]
		public readonly IDictProvider DictProvider;

		// Token: 0x04001BEA RID: 7146
		[Token(Token = "0x4001BEA")]
		[FieldOffset(Offset = "0x10")]
		public readonly IGame Game;

		// Token: 0x04001BEE RID: 7150
		[Token(Token = "0x4001BEE")]
		[FieldOffset(Offset = "0x20")]
		public IQuest CurrentQuest;

		// Token: 0x04001BEF RID: 7151
		[Token(Token = "0x4001BEF")]
		[FieldOffset(Offset = "0x24")]
		private readonly Dictionary<uint, List<IQuest>> _questsByCategories;
	}
}
