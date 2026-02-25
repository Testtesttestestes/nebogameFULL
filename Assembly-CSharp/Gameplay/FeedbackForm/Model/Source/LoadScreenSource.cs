using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Application.Managers;
using Core.Gameplay;
using Core.Gameplay.Managers.Configuration;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Gameplay.FeedbackForm.Model.Source
{
	// Token: 0x02000826 RID: 2086
	[Token(Token = "0x2000826")]
	public class LoadScreenSource : IFeedbackFormSource, IDisposable
	{
		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x0600311B RID: 12571 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009A8")]
		public Themes[] Themes
		{
			[Token(Token = "0x600311B")]
			[Address(RVA = "0x8174", Offset = "0x8174", VA = "0x8174", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x0600311C RID: 12572 RVA: 0x00009FA8 File Offset: 0x000081A8
		[Token(Token = "0x170009A9")]
		public Themes DefaultTheme
		{
			[Token(Token = "0x600311C")]
			[Address(RVA = "0x8175", Offset = "0x8175", VA = "0x8175", Slot = "5")]
			get
			{
				return Gameplay.FeedbackForm.Model.Themes.UNKNOWN;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x0600311D RID: 12573 RVA: 0x00009FC0 File Offset: 0x000081C0
		[Token(Token = "0x170009AA")]
		public uint RequiredFormFields
		{
			[Token(Token = "0x600311D")]
			[Address(RVA = "0x8176", Offset = "0x8176", VA = "0x8176", Slot = "6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x0600311E RID: 12574 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009AB")]
		public IPlatformConfigurationProvider ConfigurationProvider
		{
			[Token(Token = "0x600311E")]
			[Address(RVA = "0x8177", Offset = "0x8177", VA = "0x8177", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x0600311F RID: 12575 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003120 RID: 12576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009AC")]
		public IPlatformSigninProvider SigninProvider
		{
			[Token(Token = "0x600311F")]
			[Address(RVA = "0x8178", Offset = "0x8178", VA = "0x8178", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003120")]
			[Address(RVA = "0x8179", Offset = "0x8179", VA = "0x8179")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06003121 RID: 12577 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003122 RID: 12578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009AD")]
		public IAuthDataProvider AuthDataProvider
		{
			[Token(Token = "0x6003121")]
			[Address(RVA = "0x817A", Offset = "0x817A", VA = "0x817A", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003122")]
			[Address(RVA = "0x817B", Offset = "0x817B", VA = "0x817B")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06003123 RID: 12579 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009AE")]
		public IClientVersionProvider ClientVersionProvider
		{
			[Token(Token = "0x6003123")]
			[Address(RVA = "0x817C", Offset = "0x817C", VA = "0x817C", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06003124 RID: 12580 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009AF")]
		public Uri Endpoint
		{
			[Token(Token = "0x6003124")]
			[Address(RVA = "0x817D", Offset = "0x817D", VA = "0x817D", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003125")]
		[Address(RVA = "0x817E", Offset = "0x817E", VA = "0x817E", Slot = "12")]
		public void Dispose()
		{
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003126")]
		[Address(RVA = "0x817F", Offset = "0x817F", VA = "0x817F")]
		private LoadScreenSource(IPlatformConfigurationProvider cfgProvider, IClientVersionProvider clientVersionProvider, Uri endpoint)
		{
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003127")]
		[Address(RVA = "0x8180", Offset = "0x8180", VA = "0x8180")]
		public static IFeedbackFormSource Create(IApp app, [CanBeNull] IAuthDataProvider authDataProvider)
		{
			return null;
		}

		// Token: 0x04001ADD RID: 6877
		[Token(Token = "0x4001ADD")]
		[FieldOffset(Offset = "0x8")]
		private uint _requiredFormFields;
	}
}
