using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements.Base.Controller;
using Core.Gameplay.Managers.Ad.Placements.Base.Events;
using Core.Gameplay.Managers.Ad.Placements.Base.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Placements
{
	// Token: 0x02001208 RID: 4616
	[Token(Token = "0x2001208")]
	public abstract class AbstractAdPlacementManager<M, C, E> : AbstractAdPlacementManager, IDisposable where M : AbstractAdPlacementModel where C : AbstractAdPlacementController<M, E> where E : AdPlacementEvents
	{
		// Token: 0x06006D80 RID: 28032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D80")]
		public override void Dispose()
		{
		}

		// Token: 0x06006D81 RID: 28033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D81")]
		protected AbstractAdPlacementManager(IAdPlacementData adPlacementData, IAdController adController, AdEvents adEvents, UserData user)
		{
		}

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x06006D82 RID: 28034 RVA: 0x000141F0 File Offset: 0x000123F0
		[Token(Token = "0x17001641")]
		public override bool AdAvailableByServer
		{
			[Token(Token = "0x6006D82")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x06006D83 RID: 28035 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006D84 RID: 28036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001642")]
		public C Controller
		{
			[Token(Token = "0x6006D83")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D84")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x06006D85 RID: 28037 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006D86 RID: 28038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001643")]
		public M Model
		{
			[Token(Token = "0x6006D85")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D86")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x06006D87 RID: 28039 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006D88 RID: 28040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001644")]
		public E Events
		{
			[Token(Token = "0x6006D87")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006D89 RID: 28041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D89")]
		protected void Initialize()
		{
		}

		// Token: 0x06006D8A RID: 28042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D8A")]
		private void DestroyMvc()
		{
		}

		// Token: 0x06006D8B RID: 28043
		[Token(Token = "0x6006D8B")]
		protected abstract C CreateController(E events, M model, IAdController adController, AdEvents adEvents);

		// Token: 0x06006D8C RID: 28044
		[Token(Token = "0x6006D8C")]
		protected abstract M CreateModel(UserData user, IAdPlacementData adPlacementData);

		// Token: 0x06006D8D RID: 28045
		[Token(Token = "0x6006D8D")]
		protected abstract E CreateEvents();

		// Token: 0x0400395C RID: 14684
		[Token(Token = "0x400395C")]
		[FieldOffset(Offset = "0x0")]
		private readonly IAdPlacementData _adPlacementData;

		// Token: 0x0400395D RID: 14685
		[Token(Token = "0x400395D")]
		[FieldOffset(Offset = "0x0")]
		private readonly IAdController _adController;

		// Token: 0x0400395E RID: 14686
		[Token(Token = "0x400395E")]
		[FieldOffset(Offset = "0x0")]
		private readonly AdEvents _adEvents;

		// Token: 0x0400395F RID: 14687
		[Token(Token = "0x400395F")]
		[FieldOffset(Offset = "0x0")]
		private readonly UserData _user;
	}
}
