using System;
using System.Runtime.CompilerServices;
using Core.Application.Managers;
using Core.Gameplay;
using Core.Gameplay.Managers.Configuration;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Gameplay.FeedbackForm.Model.Source
{
	// Token: 0x02000824 RID: 2084
	[Token(Token = "0x2000824")]
	public class DefaultSource : IFeedbackFormSource, IDisposable
	{
		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06003106 RID: 12550 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000998")]
		public Themes[] Themes
		{
			[Token(Token = "0x6003106")]
			[Address(RVA = "0x8167", Offset = "0x8167", VA = "0x8167", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06003107 RID: 12551 RVA: 0x00009F78 File Offset: 0x00008178
		[Token(Token = "0x17000999")]
		public Themes DefaultTheme
		{
			[Token(Token = "0x6003107")]
			[Address(RVA = "0x8168", Offset = "0x8168", VA = "0x8168", Slot = "5")]
			get
			{
				return Gameplay.FeedbackForm.Model.Themes.UNKNOWN;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06003108 RID: 12552 RVA: 0x00009F90 File Offset: 0x00008190
		[Token(Token = "0x1700099A")]
		public uint RequiredFormFields
		{
			[Token(Token = "0x6003108")]
			[Address(RVA = "0x8169", Offset = "0x8169", VA = "0x8169", Slot = "6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06003109 RID: 12553 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700099B")]
		public IPlatformConfigurationProvider ConfigurationProvider
		{
			[Token(Token = "0x6003109")]
			[Address(RVA = "0x816A", Offset = "0x816A", VA = "0x816A", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x0600310A RID: 12554 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600310B RID: 12555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700099C")]
		public IPlatformSigninProvider SigninProvider
		{
			[Token(Token = "0x600310A")]
			[Address(RVA = "0x816B", Offset = "0x816B", VA = "0x816B", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600310B")]
			[Address(RVA = "0x816C", Offset = "0x816C", VA = "0x816C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x0600310C RID: 12556 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600310D RID: 12557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700099D")]
		public IAuthDataProvider AuthDataProvider
		{
			[Token(Token = "0x600310C")]
			[Address(RVA = "0x816D", Offset = "0x816D", VA = "0x816D", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600310D")]
			[Address(RVA = "0x816E", Offset = "0x816E", VA = "0x816E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x0600310E RID: 12558 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700099E")]
		public IClientVersionProvider ClientVersionProvider
		{
			[Token(Token = "0x600310E")]
			[Address(RVA = "0x816F", Offset = "0x816F", VA = "0x816F", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x0600310F RID: 12559 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700099F")]
		public Uri Endpoint
		{
			[Token(Token = "0x600310F")]
			[Address(RVA = "0x8170", Offset = "0x8170", VA = "0x8170", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003110")]
		[Address(RVA = "0x8171", Offset = "0x8171", VA = "0x8171", Slot = "12")]
		public void Dispose()
		{
		}

		// Token: 0x06003111 RID: 12561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003111")]
		[Address(RVA = "0x8172", Offset = "0x8172", VA = "0x8172")]
		private DefaultSource(IPlatformConfigurationProvider cfgProvider, IClientVersionProvider clientVersionProvider, Uri endpoint)
		{
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003112")]
		[Address(RVA = "0x8173", Offset = "0x8173", VA = "0x8173")]
		public static IFeedbackFormSource Create(IGame game, [CanBeNull] IAuthDataProvider authDataProvider)
		{
			return null;
		}

		// Token: 0x04001AD6 RID: 6870
		[Token(Token = "0x4001AD6")]
		[FieldOffset(Offset = "0x8")]
		private Themes[] _themes;

		// Token: 0x04001AD7 RID: 6871
		[Token(Token = "0x4001AD7")]
		[FieldOffset(Offset = "0xC")]
		private uint _requiredFormFields;
	}
}
