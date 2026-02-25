using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Core.Gameplay.Managers;
using Core.Gameplay.Managers.Requirements;
using DefaultNamespace;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.UserInterface.Model
{
	// Token: 0x020003D7 RID: 983
	[Token(Token = "0x20003D7")]
	public class UserInterfaceModel : AbstractModel
	{
		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001708 RID: 5896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F3")]
		public IAuthDataProvider Auth
		{
			[Token(Token = "0x6001707")]
			[Address(RVA = "0x68C6", Offset = "0x68C6", VA = "0x68C6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001708")]
			[Address(RVA = "0x68C7", Offset = "0x68C7", VA = "0x68C7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001709 RID: 5897 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600170A RID: 5898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F4")]
		public IDictProvider DictProvider
		{
			[Token(Token = "0x6001709")]
			[Address(RVA = "0x68C8", Offset = "0x68C8", VA = "0x68C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600170A")]
			[Address(RVA = "0x68C9", Offset = "0x68C9", VA = "0x68C9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x0600170B RID: 5899 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600170C RID: 5900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F5")]
		public IRequirementValidator RequirementValidator
		{
			[Token(Token = "0x600170B")]
			[Address(RVA = "0x68CA", Offset = "0x68CA", VA = "0x68CA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600170C")]
			[Address(RVA = "0x68CB", Offset = "0x68CB", VA = "0x68CB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x0600170D RID: 5901 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600170E RID: 5902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F6")]
		public IDiscountHandler DiscountHandler
		{
			[Token(Token = "0x600170D")]
			[Address(RVA = "0x68CC", Offset = "0x68CC", VA = "0x68CC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600170E")]
			[Address(RVA = "0x68CD", Offset = "0x68CD", VA = "0x68CD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x0600170F RID: 5903 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001710 RID: 5904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F7")]
		public PopupScheduleManager.Args UserGoNewLevelPopupScheduleArgs
		{
			[Token(Token = "0x600170F")]
			[Address(RVA = "0x68CE", Offset = "0x68CE", VA = "0x68CE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001710")]
			[Address(RVA = "0x68CF", Offset = "0x68CF", VA = "0x68CF")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001711 RID: 5905 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001712 RID: 5906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F8")]
		public IGame Game
		{
			[Token(Token = "0x6001711")]
			[Address(RVA = "0x68D0", Offset = "0x68D0", VA = "0x68D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001712")]
			[Address(RVA = "0x68D1", Offset = "0x68D1", VA = "0x68D1")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001713 RID: 5907 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001714 RID: 5908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F9")]
		public SceneAppManager SceneAppManager
		{
			[Token(Token = "0x6001713")]
			[Address(RVA = "0x68D2", Offset = "0x68D2", VA = "0x68D2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001714")]
			[Address(RVA = "0x68D3", Offset = "0x68D3", VA = "0x68D3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001715")]
		[Address(RVA = "0x68D4", Offset = "0x68D4", VA = "0x68D4", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001716")]
		[Address(RVA = "0x68D5", Offset = "0x68D5", VA = "0x68D5")]
		public UserInterfaceModel(IGame game, IAuthDataProvider authDataProvider, IDictProvider dictProvider, IRequirementValidator requirementValidator, IDiscountHandler discountHandler, SceneAppManager sceneAppManager, UserData user)
		{
		}
	}
}
