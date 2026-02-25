using System;
using System.Runtime.CompilerServices;
using Gameplay.MageSchool.Events;
using Gameplay.School.Controller;
using Gameplay.School.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001176 RID: 4470
	[Token(Token = "0x2001176")]
	public class SchoolManager : IGameManager, IBaseManager
	{
		// Token: 0x14000298 RID: 664
		// (add) Token: 0x060069B1 RID: 27057 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069B2 RID: 27058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000298")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60069B1")]
			[Address(RVA = "0xB4D1", Offset = "0xB4D1", VA = "0xB4D1", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069B2")]
			[Address(RVA = "0xB4D2", Offset = "0xB4D2", VA = "0xB4D2", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000299 RID: 665
		// (add) Token: 0x060069B3 RID: 27059 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069B4 RID: 27060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000299")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60069B3")]
			[Address(RVA = "0xB4D3", Offset = "0xB4D3", VA = "0xB4D3", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069B4")]
			[Address(RVA = "0xB4D4", Offset = "0xB4D4", VA = "0xB4D4", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x060069B5 RID: 27061 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700159F")]
		public SchoolEvents Events
		{
			[Token(Token = "0x60069B5")]
			[Address(RVA = "0xB4D5", Offset = "0xB4D5", VA = "0xB4D5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x060069B6 RID: 27062 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015A0")]
		public SchoolModel Model
		{
			[Token(Token = "0x60069B6")]
			[Address(RVA = "0xB4D6", Offset = "0xB4D6", VA = "0xB4D6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x060069B7 RID: 27063 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015A1")]
		public SchoolController Controller
		{
			[Token(Token = "0x60069B7")]
			[Address(RVA = "0xB4D7", Offset = "0xB4D7", VA = "0xB4D7")]
			get
			{
				return null;
			}
		}

		// Token: 0x060069B8 RID: 27064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069B8")]
		[Address(RVA = "0xB4D8", Offset = "0xB4D8", VA = "0xB4D8", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x060069B9 RID: 27065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069B9")]
		[Address(RVA = "0xB4D9", Offset = "0xB4D9", VA = "0xB4D9")]
		private void ControllerInitEvent()
		{
		}

		// Token: 0x060069BA RID: 27066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069BA")]
		[Address(RVA = "0xB4DA", Offset = "0xB4DA", VA = "0xB4DA", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x060069BB RID: 27067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069BB")]
		[Address(RVA = "0xB4DB", Offset = "0xB4DB", VA = "0xB4DB")]
		private void SetupMvc()
		{
		}

		// Token: 0x060069BC RID: 27068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069BC")]
		[Address(RVA = "0xB4DC", Offset = "0xB4DC", VA = "0xB4DC")]
		private void DestroyMvc()
		{
		}

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x060069BD RID: 27069 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015A2")]
		public string Name
		{
			[Token(Token = "0x60069BD")]
			[Address(RVA = "0xB4DD", Offset = "0xB4DD", VA = "0xB4DD", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060069BE RID: 27070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069BE")]
		[Address(RVA = "0xB4DE", Offset = "0xB4DE", VA = "0xB4DE")]
		public SchoolManager()
		{
		}

		// Token: 0x04003810 RID: 14352
		[Token(Token = "0x4003810")]
		[FieldOffset(Offset = "0x10")]
		private SchoolEvents _events;

		// Token: 0x04003811 RID: 14353
		[Token(Token = "0x4003811")]
		[FieldOffset(Offset = "0x14")]
		private SchoolModel _model;

		// Token: 0x04003812 RID: 14354
		[Token(Token = "0x4003812")]
		[FieldOffset(Offset = "0x18")]
		private SchoolController _controller;
	}
}
