using System;
using Core.Application;
using Core.Gameplay.Managers;
using Core.Gameplay.Managers.Audio;
using Core.Gameplay.Managers.Billing;
using Core.Gameplay.Managers.EndlessPaymentOptionsList;
using Core.Gameplay.Managers.GameActivityRouting;
using Core.Gameplay.Managers.GdEvents;
using Core.Gameplay.Managers.Inventory;
using Core.Gameplay.Managers.Location;
using Core.Gameplay.Managers.Notifications;
using Core.Gameplay.Managers.Prefetch;
using Core.Gameplay.Managers.Requirements;
using Core.Gameplay.Managers.Skins;
using Core.Gameplay.Managers.Tutorial;
using Core.Gameplay.Managers.Tutorial.Guide;
using Il2CppDummyDll;

namespace Core.Gameplay
{
	// Token: 0x02001126 RID: 4390
	[Token(Token = "0x2001126")]
	public interface IGame
	{
		// Token: 0x14000249 RID: 585
		// (add) Token: 0x060066C2 RID: 26306
		// (remove) Token: 0x060066C3 RID: 26307
		[Token(Token = "0x14000249")]
		event Action<IGame> InitCompleteEvent;

		// Token: 0x1400024A RID: 586
		// (add) Token: 0x060066C4 RID: 26308
		// (remove) Token: 0x060066C5 RID: 26309
		[Token(Token = "0x1400024A")]
		event Action<IGame> DeinitCompleteEvent;

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x060066C6 RID: 26310
		[Token(Token = "0x170014E7")]
		IApp Application { [Token(Token = "0x60066C6")] get; }

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x060066C7 RID: 26311
		[Token(Token = "0x170014E8")]
		bool IsDeInitProcess { [Token(Token = "0x60066C7")] get; }

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x060066C8 RID: 26312
		[Token(Token = "0x170014E9")]
		bool IsInit { [Token(Token = "0x60066C8")] get; }

		// Token: 0x060066C9 RID: 26313
		[Token(Token = "0x60066C9")]
		void Init(IApp applications);

		// Token: 0x060066CA RID: 26314
		[Token(Token = "0x60066CA")]
		void Deinit();

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x060066CB RID: 26315
		[Token(Token = "0x170014EA")]
		ShopManager ShopManager { [Token(Token = "0x60066CB")] get; }

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x060066CC RID: 26316
		[Token(Token = "0x170014EB")]
		WorldManager WorldManager { [Token(Token = "0x60066CC")] get; }

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x060066CD RID: 26317
		[Token(Token = "0x170014EC")]
		LocationManager LocationManager { [Token(Token = "0x60066CD")] get; }

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x060066CE RID: 26318
		[Token(Token = "0x170014ED")]
		InventoryManager InventoryManager { [Token(Token = "0x60066CE")] get; }

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x060066CF RID: 26319
		[Token(Token = "0x170014EE")]
		SchoolManager SchoolManager { [Token(Token = "0x60066CF")] get; }

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x060066D0 RID: 26320
		[Token(Token = "0x170014EF")]
		MedalsManager MedalsManager { [Token(Token = "0x60066D0")] get; }

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x060066D1 RID: 26321
		[Token(Token = "0x170014F0")]
		AprsManager AprsManager { [Token(Token = "0x60066D1")] get; }

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x060066D2 RID: 26322
		[Token(Token = "0x170014F1")]
		UserManager UserManager { [Token(Token = "0x60066D2")] get; }

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x060066D3 RID: 26323
		[Token(Token = "0x170014F2")]
		InitCompleteManager InitCompleteManager { [Token(Token = "0x60066D3")] get; }

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x060066D4 RID: 26324
		[Token(Token = "0x170014F3")]
		ArtifactDropManager ArtifactDropManager { [Token(Token = "0x60066D4")] get; }

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x060066D5 RID: 26325
		[Token(Token = "0x170014F4")]
		CacheManager CacheManager { [Token(Token = "0x60066D5")] get; }

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x060066D6 RID: 26326
		[Token(Token = "0x170014F5")]
		RequirementsManager RequirementsManager { [Token(Token = "0x60066D6")] get; }

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x060066D7 RID: 26327
		[Token(Token = "0x170014F6")]
		GameEventsManager GameEventsManager { [Token(Token = "0x60066D7")] get; }

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x060066D8 RID: 26328
		[Token(Token = "0x170014F7")]
		DailyQuestsManager DailyQuestsManager { [Token(Token = "0x60066D8")] get; }

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x060066D9 RID: 26329
		[Token(Token = "0x170014F8")]
		DictManager DictManager { [Token(Token = "0x60066D9")] get; }

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x060066DA RID: 26330
		[Token(Token = "0x170014F9")]
		ClientStateManager ClientStateManager { [Token(Token = "0x60066DA")] get; }

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x060066DB RID: 26331
		[Token(Token = "0x170014FA")]
		AbstractPrefetchManager AssetsPrefetchManager { [Token(Token = "0x60066DB")] get; }

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x060066DC RID: 26332
		[Token(Token = "0x170014FB")]
		BankManager BankManager { [Token(Token = "0x60066DC")] get; }

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x060066DD RID: 26333
		[Token(Token = "0x170014FC")]
		BillingManager BillingManager { [Token(Token = "0x60066DD")] get; }

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x060066DE RID: 26334
		[Token(Token = "0x170014FD")]
		ITutorialManager TutorialManager { [Token(Token = "0x60066DE")] get; }

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x060066DF RID: 26335
		[Token(Token = "0x170014FE")]
		ProgressSaverManager SaverProgressManager { [Token(Token = "0x60066DF")] get; }

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x060066E0 RID: 26336
		[Token(Token = "0x170014FF")]
		GameFeatureRouterManager GameFeatureRouterManager { [Token(Token = "0x60066E0")] get; }

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x060066E1 RID: 26337
		[Token(Token = "0x17001500")]
		SmallGamesManager SmallGamesManager { [Token(Token = "0x60066E1")] get; }

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x060066E2 RID: 26338
		[Token(Token = "0x17001501")]
		BlitzTournamentManager BlitzTournamentManager { [Token(Token = "0x60066E2")] get; }

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x060066E3 RID: 26339
		[Token(Token = "0x17001502")]
		TournamentsManager TournamentsManager { [Token(Token = "0x60066E3")] get; }

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x060066E4 RID: 26340
		[Token(Token = "0x17001503")]
		ClientStateResolver ClientStateResolver { [Token(Token = "0x60066E4")] get; }

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x060066E5 RID: 26341
		[Token(Token = "0x17001504")]
		ChatManager ChatManager { [Token(Token = "0x60066E5")] get; }

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x060066E6 RID: 26342
		[Token(Token = "0x17001505")]
		BossManager BossManager { [Token(Token = "0x60066E6")] get; }

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x060066E7 RID: 26343
		[Token(Token = "0x17001506")]
		GuideManager GuideManager { [Token(Token = "0x60066E7")] get; }

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x060066E8 RID: 26344
		[Token(Token = "0x17001507")]
		BattlesManager BattlesManager { [Token(Token = "0x60066E8")] get; }

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x060066E9 RID: 26345
		[Token(Token = "0x17001508")]
		AccountsManager AccountsManager { [Token(Token = "0x60066E9")] get; }

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x060066EA RID: 26346
		[Token(Token = "0x17001509")]
		SpecialOffersManager SpecialOffersManager { [Token(Token = "0x60066EA")] get; }

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x060066EB RID: 26347
		[Token(Token = "0x1700150A")]
		PopupScheduleManager PopupScheduleManager { [Token(Token = "0x60066EB")] get; }

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x060066EC RID: 26348
		[Token(Token = "0x1700150B")]
		AssistantsManager AssistantsManager { [Token(Token = "0x60066EC")] get; }

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x060066ED RID: 26349
		[Token(Token = "0x1700150C")]
		ICombatManager CombatManager { [Token(Token = "0x60066ED")] get; }

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x060066EE RID: 26350
		[Token(Token = "0x1700150D")]
		AudioManager AudioManager { [Token(Token = "0x60066EE")] get; }

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x060066EF RID: 26351
		[Token(Token = "0x1700150E")]
		DuelManager DuelManager { [Token(Token = "0x60066EF")] get; }

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x060066F0 RID: 26352
		[Token(Token = "0x1700150F")]
		ClansManager ClansManager { [Token(Token = "0x60066F0")] get; }

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x060066F1 RID: 26353
		[Token(Token = "0x17001510")]
		GolemInventoryManager GolemInventoryManager { [Token(Token = "0x60066F1")] get; }

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x060066F2 RID: 26354
		[Token(Token = "0x17001511")]
		ClanWarsManager ClanWarsManager { [Token(Token = "0x60066F2")] get; }

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x060066F3 RID: 26355
		[Token(Token = "0x17001512")]
		DiscountsManager DiscountsManager { [Token(Token = "0x60066F3")] get; }

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x060066F4 RID: 26356
		[Token(Token = "0x17001513")]
		RateGameManager RateGameManager { [Token(Token = "0x60066F4")] get; }

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x060066F5 RID: 26357
		[Token(Token = "0x17001514")]
		WorldAxisManager WorldAxisManager { [Token(Token = "0x60066F5")] get; }

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x060066F6 RID: 26358
		[Token(Token = "0x17001515")]
		GameNotificationsManager GameNotificationsManager { [Token(Token = "0x60066F6")] get; }

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x060066F7 RID: 26359
		[Token(Token = "0x17001516")]
		AdManager AdManager { [Token(Token = "0x60066F7")] get; }

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x060066F8 RID: 26360
		[Token(Token = "0x17001517")]
		ServerTimeManager ServerTimeManager { [Token(Token = "0x60066F8")] get; }

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x060066F9 RID: 26361
		[Token(Token = "0x17001518")]
		GdEventsManager GdEventsManager { [Token(Token = "0x60066F9")] get; }

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x060066FA RID: 26362
		[Token(Token = "0x17001519")]
		CollectionsManager CollectionsManager { [Token(Token = "0x60066FA")] get; }

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x060066FB RID: 26363
		[Token(Token = "0x1700151A")]
		ThemeDuelStateManager ThemeDuelStateManager { [Token(Token = "0x60066FB")] get; }

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x060066FC RID: 26364
		[Token(Token = "0x1700151B")]
		PortalsManager PortalsManager { [Token(Token = "0x60066FC")] get; }

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x060066FD RID: 26365
		[Token(Token = "0x1700151C")]
		EndlessPaymentOptionsListManager EndlessPaymentOptionsListManager { [Token(Token = "0x60066FD")] get; }

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x060066FE RID: 26366
		[Token(Token = "0x1700151D")]
		CompetitionManager CompetitionManager { [Token(Token = "0x60066FE")] get; }

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x060066FF RID: 26367
		[Token(Token = "0x1700151E")]
		FrescoManager FrescoManager { [Token(Token = "0x60066FF")] get; }

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x06006700 RID: 26368
		[Token(Token = "0x1700151F")]
		IRouter Router { [Token(Token = "0x6006700")] get; }

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x06006701 RID: 26369
		[Token(Token = "0x17001520")]
		SkinManager Skins { [Token(Token = "0x6006701")] get; }

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x06006702 RID: 26370
		[Token(Token = "0x17001521")]
		ExperimentsManager ExperimentsManager { [Token(Token = "0x6006702")] get; }
	}
}
