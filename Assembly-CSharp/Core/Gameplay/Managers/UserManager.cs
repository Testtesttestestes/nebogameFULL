using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.User.Controller;
using Gameplay.User.Events;
using Gameplay.User.Model;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using Utils.Accumulators;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200117E RID: 4478
	[Token(Token = "0x200117E")]
	public class UserManager : IGameManager, IBaseManager
	{
		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x06006A1F RID: 27167 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015B7")]
		public string Name
		{
			[Token(Token = "0x6006A1F")]
			[Address(RVA = "0xB53F", Offset = "0xB53F", VA = "0xB53F", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002A8 RID: 680
		// (add) Token: 0x06006A20 RID: 27168 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A21 RID: 27169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002A8")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006A20")]
			[Address(RVA = "0xB540", Offset = "0xB540", VA = "0xB540", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A21")]
			[Address(RVA = "0xB541", Offset = "0xB541", VA = "0xB541", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002A9 RID: 681
		// (add) Token: 0x06006A22 RID: 27170 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A23 RID: 27171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002A9")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006A22")]
			[Address(RVA = "0xB542", Offset = "0xB542", VA = "0xB542", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A23")]
			[Address(RVA = "0xB543", Offset = "0xB543", VA = "0xB543", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x06006A24 RID: 27172 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015B8")]
		public UserEvents Events
		{
			[Token(Token = "0x6006A24")]
			[Address(RVA = "0xB544", Offset = "0xB544", VA = "0xB544")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x06006A25 RID: 27173 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015B9")]
		public UserModel Model
		{
			[Token(Token = "0x6006A25")]
			[Address(RVA = "0xB545", Offset = "0xB545", VA = "0xB545")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x06006A26 RID: 27174 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015BA")]
		public UserController Controller
		{
			[Token(Token = "0x6006A26")]
			[Address(RVA = "0xB546", Offset = "0xB546", VA = "0xB546")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x06006A27 RID: 27175 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015BB")]
		public UserData User
		{
			[Token(Token = "0x6006A27")]
			[Address(RVA = "0x1BC9", Offset = "0x1BC9", VA = "0x1BC9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006A28 RID: 27176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A28")]
		[Address(RVA = "0xB547", Offset = "0xB547", VA = "0xB547")]
		public UserManager(IGame game)
		{
		}

		// Token: 0x06006A29 RID: 27177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A29")]
		[Address(RVA = "0xB548", Offset = "0xB548", VA = "0xB548", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006A2A RID: 27178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A2A")]
		[Address(RVA = "0xB549", Offset = "0xB549", VA = "0xB549")]
		private void HandleGetUser(long operationIndex, UserData[] data)
		{
		}

		// Token: 0x06006A2B RID: 27179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A2B")]
		[Address(RVA = "0xB54A", Offset = "0xB54A", VA = "0xB54A")]
		private void CreateMvc(UserData user)
		{
		}

		// Token: 0x06006A2C RID: 27180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A2C")]
		[Address(RVA = "0xB54B", Offset = "0xB54B", VA = "0xB54B")]
		private void ControllerOnInitEvent()
		{
		}

		// Token: 0x06006A2D RID: 27181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A2D")]
		[Address(RVA = "0xB54C", Offset = "0xB54C", VA = "0xB54C", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x04003837 RID: 14391
		[Token(Token = "0x4003837")]
		[FieldOffset(Offset = "0x10")]
		private UserEvents _events;

		// Token: 0x04003838 RID: 14392
		[Token(Token = "0x4003838")]
		[FieldOffset(Offset = "0x14")]
		private UserModel _model;

		// Token: 0x04003839 RID: 14393
		[Token(Token = "0x4003839")]
		[FieldOffset(Offset = "0x18")]
		private UserController _controller;

		// Token: 0x0400383A RID: 14394
		[Token(Token = "0x400383A")]
		[FieldOffset(Offset = "0x1C")]
		private UserManager.UserEventBusHelper _userEventBusHelper;

		// Token: 0x0400383B RID: 14395
		[Token(Token = "0x400383B")]
		[FieldOffset(Offset = "0x20")]
		private IGame _game;

		// Token: 0x0200117F RID: 4479
		[Token(Token = "0x200117F")]
		public class UserEventBusHelper : IDisposable
		{
			// Token: 0x06006A2E RID: 27182 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A2E")]
			[Address(RVA = "0xB54D", Offset = "0xB54D", VA = "0xB54D")]
			public UserEventBusHelper(UserManager userManager)
			{
			}

			// Token: 0x06006A2F RID: 27183 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A2F")]
			[Address(RVA = "0xB54E", Offset = "0xB54E", VA = "0xB54E")]
			private void BuyTreeLicenceSuccessEvent()
			{
			}

			// Token: 0x06006A30 RID: 27184 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A30")]
			[Address(RVA = "0xB54F", Offset = "0xB54F", VA = "0xB54F")]
			private void UserOnOnUserLicenseCountChangedEvent(uint arg1, uint arg2)
			{
			}

			// Token: 0x06006A31 RID: 27185 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A31")]
			[Address(RVA = "0xB550", Offset = "0xB550", VA = "0xB550")]
			private void AccountsOnAccountsChangedEvent()
			{
			}

			// Token: 0x06006A32 RID: 27186 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A32")]
			[Address(RVA = "0xB551", Offset = "0xB551", VA = "0xB551")]
			private void UserOnOnUserExperienceChangedEvent()
			{
			}

			// Token: 0x06006A33 RID: 27187 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A33")]
			[Address(RVA = "0xB552", Offset = "0xB552", VA = "0xB552")]
			private void UserOnOnUserLevelChangedEvent()
			{
			}

			// Token: 0x06006A34 RID: 27188 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A34")]
			[Address(RVA = "0xB553", Offset = "0xB553", VA = "0xB553")]
			private void UserOnOnUserAprChangedEvent(AprDicWrapper apr)
			{
			}

			// Token: 0x06006A35 RID: 27189 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A35")]
			[Address(RVA = "0xB554", Offset = "0xB554", VA = "0xB554")]
			private void UserOnOnUserGenderChangedEvent()
			{
			}

			// Token: 0x06006A36 RID: 27190 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A36")]
			[Address(RVA = "0xB555", Offset = "0xB555", VA = "0xB555")]
			private void UserOnOnUserCultChangedEvent(CultDic obj)
			{
			}

			// Token: 0x06006A37 RID: 27191 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A37")]
			[Address(RVA = "0xB556", Offset = "0xB556", VA = "0xB556")]
			private void UserOnUserSkillsChangedEvent()
			{
			}

			// Token: 0x06006A38 RID: 27192 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A38")]
			[Address(RVA = "0xB557", Offset = "0xB557", VA = "0xB557")]
			private void UserOnOnUserNickChangedEvent()
			{
			}

			// Token: 0x06006A39 RID: 27193 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A39")]
			[Address(RVA = "0xB558", Offset = "0xB558", VA = "0xB558")]
			private void UserOnOnTriggerChangedEvent(IEnumerable<TriggerValue> changes, AccumulatorBase<int, TriggerValue> accumulator)
			{
			}

			// Token: 0x06006A3A RID: 27194 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A3A")]
			[Address(RVA = "0xB559", Offset = "0xB559", VA = "0xB559")]
			private void UserOnOnUserBalanceChangedEvent(ResourceSet balance, ResourceSet delta)
			{
			}

			// Token: 0x06006A3B RID: 27195 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A3B")]
			[Address(RVA = "0xB55A", Offset = "0xB55A", VA = "0xB55A", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x0400383C RID: 14396
			[Token(Token = "0x400383C")]
			[FieldOffset(Offset = "0x8")]
			private UserData _user;

			// Token: 0x0400383D RID: 14397
			[Token(Token = "0x400383D")]
			[FieldOffset(Offset = "0xC")]
			private UserManager _userManager;
		}
	}
}
