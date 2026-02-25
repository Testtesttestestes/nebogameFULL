using System;
using System.Runtime.CompilerServices;
using Gameplay.Isles.Base.Controller;
using Gameplay.Isles.Base.Events;
using Gameplay.Isles.Base.Model;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Gameplay.Isles.Base
{
	// Token: 0x02000CF8 RID: 3320
	[Token(Token = "0x2000CF8")]
	public abstract class AbstractIsle<TEvents, TModel, TController, TTypeEnum> : IIsle, IDisposable where TEvents : BaseIsleEvents where TModel : BaseIsleModel where TController : BaseIsleController<TModel, TEvents> where TTypeEnum : Enum
	{
		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x060050DC RID: 20700 RVA: 0x0000EC58 File Offset: 0x0000CE58
		// (set) Token: 0x060050DD RID: 20701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001057")]
		public bool IsDisposed
		{
			[Token(Token = "0x60050DC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60050DD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x060050DE RID: 20702
		[Token(Token = "0x17001058")]
		public abstract LocationTypes LocationType { [Token(Token = "0x60050DE")] get; }

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x060050DF RID: 20703 RVA: 0x0000EC70 File Offset: 0x0000CE70
		[Token(Token = "0x17001059")]
		public bool IsCurrentIsle
		{
			[Token(Token = "0x60050DF")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x060050E0 RID: 20704 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060050E1 RID: 20705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700105A")]
		public TEvents Events
		{
			[Token(Token = "0x60050E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60050E1")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x060050E2 RID: 20706 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060050E3 RID: 20707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700105B")]
		public TModel Model
		{
			[Token(Token = "0x60050E2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60050E3")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x060050E4 RID: 20708 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060050E5 RID: 20709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700105C")]
		public TController Controller
		{
			[Token(Token = "0x60050E4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60050E5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x060050E6 RID: 20710 RVA: 0x0000EC88 File Offset: 0x0000CE88
		// (set) Token: 0x060050E7 RID: 20711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700105D")]
		public ulong Id
		{
			[Token(Token = "0x60050E6")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60050E7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x060050E8 RID: 20712 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
		// (set) Token: 0x060050E9 RID: 20713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700105E")]
		public bool WasViewed
		{
			[Token(Token = "0x60050E8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60050E9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060050EA RID: 20714
		[Token(Token = "0x60050EA")]
		public abstract bool TryOpenBuildingByType(uint type);

		// Token: 0x060050EB RID: 20715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050EB")]
		public void SetIsCurrentIsle(bool isCurrent)
		{
		}

		// Token: 0x060050EC RID: 20716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050EC")]
		protected AbstractIsle(ulong id)
		{
		}

		// Token: 0x060050ED RID: 20717 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
		[Token(Token = "0x60050ED")]
		public bool TryOpenBuildingByType(TTypeEnum type)
		{
			return default(bool);
		}

		// Token: 0x060050EE RID: 20718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050EE")]
		public virtual void Dispose()
		{
		}
	}
}
