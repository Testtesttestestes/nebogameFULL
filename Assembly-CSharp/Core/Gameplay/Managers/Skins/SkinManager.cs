using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Dic;
using Utils.Timers;

namespace Core.Gameplay.Managers.Skins
{
	// Token: 0x0200118D RID: 4493
	[Token(Token = "0x200118D")]
	public class SkinManager : IGameManager, IBaseManager
	{
		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x06006AC2 RID: 27330 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015D6")]
		public string Name
		{
			[Token(Token = "0x6006AC2")]
			[Address(RVA = "0xB5D5", Offset = "0xB5D5", VA = "0xB5D5", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002B7 RID: 695
		// (add) Token: 0x06006AC3 RID: 27331 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006AC4 RID: 27332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002B7")]
		public event Action<SkinManager> SkinChangedEvent
		{
			[Token(Token = "0x6006AC3")]
			[Address(RVA = "0xB5D6", Offset = "0xB5D6", VA = "0xB5D6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006AC4")]
			[Address(RVA = "0xB5D7", Offset = "0xB5D7", VA = "0xB5D7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002B8 RID: 696
		// (add) Token: 0x06006AC5 RID: 27333 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006AC6 RID: 27334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002B8")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006AC5")]
			[Address(RVA = "0xB5D8", Offset = "0xB5D8", VA = "0xB5D8", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006AC6")]
			[Address(RVA = "0xB5D9", Offset = "0xB5D9", VA = "0xB5D9", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002B9 RID: 697
		// (add) Token: 0x06006AC7 RID: 27335 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006AC8 RID: 27336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002B9")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006AC7")]
			[Address(RVA = "0xB5DA", Offset = "0xB5DA", VA = "0xB5DA", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006AC8")]
			[Address(RVA = "0xB5DB", Offset = "0xB5DB", VA = "0xB5DB", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x06006AC9 RID: 27337 RVA: 0x00013AA0 File Offset: 0x00011CA0
		// (set) Token: 0x06006ACA RID: 27338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015D7")]
		public bool IsDisposed
		{
			[Token(Token = "0x6006AC9")]
			[Address(RVA = "0xB5DC", Offset = "0xB5DC", VA = "0xB5DC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006ACA")]
			[Address(RVA = "0xB5DD", Offset = "0xB5DD", VA = "0xB5DD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006ACB RID: 27339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006ACB")]
		[Address(RVA = "0xB5DE", Offset = "0xB5DE", VA = "0xB5DE")]
		public SkinManager(IGame game, Skin.Factory skinFactory, float nearestPackageDeltaTime)
		{
		}

		// Token: 0x06006ACC RID: 27340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006ACC")]
		[Address(RVA = "0xB5DF", Offset = "0xB5DF", VA = "0xB5DF", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006ACD RID: 27341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006ACD")]
		[Address(RVA = "0xB5E0", Offset = "0xB5E0", VA = "0xB5E0", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006ACE RID: 27342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006ACE")]
		[Address(RVA = "0xB5E1", Offset = "0xB5E1", VA = "0xB5E1")]
		private void ScheduledCallBack()
		{
		}

		// Token: 0x06006ACF RID: 27343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006ACF")]
		[Address(RVA = "0xB5E2", Offset = "0xB5E2", VA = "0xB5E2")]
		private void ResetCurrentPackageAndSkins()
		{
		}

		// Token: 0x06006AD0 RID: 27344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AD0")]
		[Address(RVA = "0xB5E3", Offset = "0xB5E3", VA = "0xB5E3")]
		private void ResetCurrentSkins()
		{
		}

		// Token: 0x06006AD1 RID: 27345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AD1")]
		[Address(RVA = "0xB5E4", Offset = "0xB5E4", VA = "0xB5E4")]
		private void HandleDictChangedEvent()
		{
		}

		// Token: 0x06006AD2 RID: 27346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AD2")]
		[Address(RVA = "0x4459", Offset = "0x4459", VA = "0x4459")]
		private void PlanePackage()
		{
		}

		// Token: 0x06006AD3 RID: 27347 RVA: 0x00013AB8 File Offset: 0x00011CB8
		[Token(Token = "0x6006AD3")]
		[Address(RVA = "0xB5E5", Offset = "0xB5E5", VA = "0xB5E5")]
		private bool TryGetNearest(long timestamp, out SkinPackageDic package)
		{
			return default(bool);
		}

		// Token: 0x06006AD4 RID: 27348 RVA: 0x00013AD0 File Offset: 0x00011CD0
		[Token(Token = "0x6006AD4")]
		[Address(RVA = "0xB5E6", Offset = "0xB5E6", VA = "0xB5E6")]
		private bool TryGetCurrent(long timestamp, out SkinPackageDic package)
		{
			return default(bool);
		}

		// Token: 0x06006AD5 RID: 27349 RVA: 0x00013AE8 File Offset: 0x00011CE8
		[Token(Token = "0x6006AD5")]
		[Address(RVA = "0xB5E7", Offset = "0xB5E7", VA = "0xB5E7")]
		private bool TryGetSkins([CanBeNull] SkinPackageDic package, out IList<Skin> skins)
		{
			return default(bool);
		}

		// Token: 0x06006AD6 RID: 27350 RVA: 0x00013B00 File Offset: 0x00011D00
		[Token(Token = "0x6006AD6")]
		[Address(RVA = "0xB5E8", Offset = "0xB5E8", VA = "0xB5E8")]
		public bool TryGetAssets(out AssetDic[] assets)
		{
			return default(bool);
		}

		// Token: 0x06006AD7 RID: 27351 RVA: 0x00013B18 File Offset: 0x00011D18
		[Token(Token = "0x6006AD7")]
		[Address(RVA = "0x37C7", Offset = "0x37C7", VA = "0x37C7")]
		public bool TryGetSkin(string assetName, out Skin skin)
		{
			return default(bool);
		}

		// Token: 0x06006AD8 RID: 27352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AD8")]
		[Address(RVA = "0xB5E9", Offset = "0xB5E9", VA = "0xB5E9")]
		public void RePlane()
		{
		}

		// Token: 0x04003875 RID: 14453
		[Token(Token = "0x4003875")]
		[FieldOffset(Offset = "0x14")]
		[NotNull]
		private readonly CancellationTokenSource _cancellationTokenSource;

		// Token: 0x04003876 RID: 14454
		[Token(Token = "0x4003876")]
		[FieldOffset(Offset = "0x18")]
		[NotNull]
		private readonly DelayedCall _delayedCall;

		// Token: 0x04003877 RID: 14455
		[Token(Token = "0x4003877")]
		[FieldOffset(Offset = "0x1C")]
		[NotNull]
		private readonly IGame _game;

		// Token: 0x04003878 RID: 14456
		[Token(Token = "0x4003878")]
		[FieldOffset(Offset = "0x20")]
		[NotNull]
		private readonly List<Skin> _currentSkins;

		// Token: 0x04003879 RID: 14457
		[Token(Token = "0x4003879")]
		[FieldOffset(Offset = "0x24")]
		[NotNull]
		private readonly Skin.Factory _skinFactory;

		// Token: 0x0400387A RID: 14458
		[Token(Token = "0x400387A")]
		[FieldOffset(Offset = "0x28")]
		[CanBeNull]
		private SkinPackageDic _currentPackage;

		// Token: 0x0400387B RID: 14459
		[Token(Token = "0x400387B")]
		[FieldOffset(Offset = "0x2C")]
		private readonly float _nearestPackageDeltaTime;
	}
}
