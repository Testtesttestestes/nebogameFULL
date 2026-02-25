using System;
using System.Runtime.CompilerServices;
using Gameplay.DailyQuests;
using Gameplay.DailyQuests.Controller;
using Gameplay.DailyQuests.Events;
using Gameplay.DailyQuests.Model;
using Gameplay.DailyQuests.View;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001162 RID: 4450
	[Token(Token = "0x2001162")]
	public class DailyQuestsManager : IGameManager, IBaseManager, IDailyQuestExtInfoPresenter
	{
		// Token: 0x1400027B RID: 635
		// (add) Token: 0x060068CA RID: 26826 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068CB RID: 26827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400027B")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60068CA")]
			[Address(RVA = "0xB3F0", Offset = "0xB3F0", VA = "0xB3F0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068CB")]
			[Address(RVA = "0xB3F1", Offset = "0xB3F1", VA = "0xB3F1", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400027C RID: 636
		// (add) Token: 0x060068CC RID: 26828 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068CD RID: 26829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400027C")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60068CC")]
			[Address(RVA = "0xB3F2", Offset = "0xB3F2", VA = "0xB3F2", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068CD")]
			[Address(RVA = "0xB3F3", Offset = "0xB3F3", VA = "0xB3F3", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060068CE RID: 26830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068CE")]
		[Address(RVA = "0xB3F4", Offset = "0xB3F4", VA = "0xB3F4", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x060068CF RID: 26831 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068D0 RID: 26832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001570")]
		public DailyQuestsController Controller
		{
			[Token(Token = "0x60068CF")]
			[Address(RVA = "0xB3F5", Offset = "0xB3F5", VA = "0xB3F5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068D0")]
			[Address(RVA = "0xB3F6", Offset = "0xB3F6", VA = "0xB3F6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x060068D1 RID: 26833 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068D2 RID: 26834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001571")]
		public DailyQuestEvents Events
		{
			[Token(Token = "0x60068D1")]
			[Address(RVA = "0xB3F7", Offset = "0xB3F7", VA = "0xB3F7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068D2")]
			[Address(RVA = "0xB3F8", Offset = "0xB3F8", VA = "0xB3F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x060068D3 RID: 26835 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068D4 RID: 26836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001572")]
		public DailyQuestsModel Model
		{
			[Token(Token = "0x60068D3")]
			[Address(RVA = "0xB3F9", Offset = "0xB3F9", VA = "0xB3F9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068D4")]
			[Address(RVA = "0xB3FA", Offset = "0xB3FA", VA = "0xB3FA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060068D5 RID: 26837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068D5")]
		[Address(RVA = "0xB3FB", Offset = "0xB3FB", VA = "0xB3FB", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x060068D6 RID: 26838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068D6")]
		[Address(RVA = "0xB3FC", Offset = "0xB3FC", VA = "0xB3FC")]
		public void SetView(UserInterfaceView view)
		{
		}

		// Token: 0x060068D7 RID: 26839 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60068D7")]
		[Address(RVA = "0xB3FD", Offset = "0xB3FD", VA = "0xB3FD")]
		public DailyQuestsWindow ShowDailyQuestsWindow(uint categoryId = 0U)
		{
			return null;
		}

		// Token: 0x060068D8 RID: 26840 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60068D8")]
		[Address(RVA = "0xB3FE", Offset = "0xB3FE", VA = "0xB3FE", Slot = "11")]
		public DailyQuestReadViewWindow ShowDailyQuestInfoWindow(IQuest quest)
		{
			return null;
		}

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x060068D9 RID: 26841 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001573")]
		public string Name
		{
			[Token(Token = "0x60068D9")]
			[Address(RVA = "0xB3FF", Offset = "0xB3FF", VA = "0xB3FF", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060068DA RID: 26842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068DA")]
		[Address(RVA = "0xB400", Offset = "0xB400", VA = "0xB400")]
		public DailyQuestsManager()
		{
		}

		// Token: 0x040037AE RID: 14254
		[Token(Token = "0x40037AE")]
		[FieldOffset(Offset = "0x10")]
		private DailyQuestsEnterPointViewMediator _mediator;
	}
}
