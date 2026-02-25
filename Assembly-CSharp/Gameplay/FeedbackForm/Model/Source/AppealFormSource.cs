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
	// Token: 0x02000823 RID: 2083
	[Token(Token = "0x2000823")]
	public class AppealFormSource : IFeedbackFormSource, IDisposable
	{
		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x060030F9 RID: 12537 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000990")]
		public Themes[] Themes
		{
			[Token(Token = "0x60030F9")]
			[Address(RVA = "0x815A", Offset = "0x815A", VA = "0x815A", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x060030FA RID: 12538 RVA: 0x00009F48 File Offset: 0x00008148
		[Token(Token = "0x17000991")]
		public Themes DefaultTheme
		{
			[Token(Token = "0x60030FA")]
			[Address(RVA = "0x815B", Offset = "0x815B", VA = "0x815B", Slot = "5")]
			get
			{
				return Gameplay.FeedbackForm.Model.Themes.UNKNOWN;
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x060030FB RID: 12539 RVA: 0x00009F60 File Offset: 0x00008160
		[Token(Token = "0x17000992")]
		public uint RequiredFormFields
		{
			[Token(Token = "0x60030FB")]
			[Address(RVA = "0x815C", Offset = "0x815C", VA = "0x815C", Slot = "6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x060030FC RID: 12540 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000993")]
		public IPlatformConfigurationProvider ConfigurationProvider
		{
			[Token(Token = "0x60030FC")]
			[Address(RVA = "0x815D", Offset = "0x815D", VA = "0x815D", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x060030FD RID: 12541 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060030FE RID: 12542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000994")]
		public IPlatformSigninProvider SigninProvider
		{
			[Token(Token = "0x60030FD")]
			[Address(RVA = "0x815E", Offset = "0x815E", VA = "0x815E", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60030FE")]
			[Address(RVA = "0x815F", Offset = "0x815F", VA = "0x815F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x060030FF RID: 12543 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003100 RID: 12544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000995")]
		public IAuthDataProvider AuthDataProvider
		{
			[Token(Token = "0x60030FF")]
			[Address(RVA = "0x8160", Offset = "0x8160", VA = "0x8160", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003100")]
			[Address(RVA = "0x8161", Offset = "0x8161", VA = "0x8161")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06003101 RID: 12545 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000996")]
		public IClientVersionProvider ClientVersionProvider
		{
			[Token(Token = "0x6003101")]
			[Address(RVA = "0x8162", Offset = "0x8162", VA = "0x8162", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06003102 RID: 12546 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000997")]
		public Uri Endpoint
		{
			[Token(Token = "0x6003102")]
			[Address(RVA = "0x8163", Offset = "0x8163", VA = "0x8163", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003103")]
		[Address(RVA = "0x8164", Offset = "0x8164", VA = "0x8164", Slot = "12")]
		public void Dispose()
		{
		}

		// Token: 0x06003104 RID: 12548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003104")]
		[Address(RVA = "0x8165", Offset = "0x8165", VA = "0x8165")]
		public AppealFormSource(IPlatformConfigurationProvider cfgProvider, IClientVersionProvider clientVersionProvider, Uri endpoint)
		{
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003105")]
		[Address(RVA = "0x8166", Offset = "0x8166", VA = "0x8166")]
		public static IFeedbackFormSource Create(IApp app, [CanBeNull] IAuthDataProvider authDataProvider)
		{
			return null;
		}

		// Token: 0x04001AD0 RID: 6864
		[Token(Token = "0x4001AD0")]
		[FieldOffset(Offset = "0x8")]
		private uint _requiredFormFields;
	}
}
