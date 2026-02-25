using System;
using System.Runtime.CompilerServices;
using Gameplay.Experiments.Controller;
using Gameplay.Experiments.Events;
using Gameplay.Experiments.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001166 RID: 4454
	[Token(Token = "0x2001166")]
	public class ExperimentsManager : IGameManager, IBaseManager
	{
		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x06006917 RID: 26903 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001582")]
		public string Name
		{
			[Token(Token = "0x6006917")]
			[Address(RVA = "0xB43B", Offset = "0xB43B", VA = "0xB43B", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000284 RID: 644
		// (add) Token: 0x06006918 RID: 26904 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006919 RID: 26905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000284")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006918")]
			[Address(RVA = "0xB43C", Offset = "0xB43C", VA = "0xB43C", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006919")]
			[Address(RVA = "0xB43D", Offset = "0xB43D", VA = "0xB43D", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000285 RID: 645
		// (add) Token: 0x0600691A RID: 26906 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600691B RID: 26907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000285")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600691A")]
			[Address(RVA = "0xB43E", Offset = "0xB43E", VA = "0xB43E", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600691B")]
			[Address(RVA = "0xB43F", Offset = "0xB43F", VA = "0xB43F", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600691C RID: 26908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600691C")]
		[Address(RVA = "0xB440", Offset = "0xB440", VA = "0xB440")]
		public ExperimentsManager(IGame game)
		{
		}

		// Token: 0x0600691D RID: 26909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600691D")]
		[Address(RVA = "0xB441", Offset = "0xB441", VA = "0xB441", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x0600691E RID: 26910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600691E")]
		[Address(RVA = "0xB442", Offset = "0xB442", VA = "0xB442")]
		private void CreateMvc()
		{
		}

		// Token: 0x0600691F RID: 26911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600691F")]
		[Address(RVA = "0xB443", Offset = "0xB443", VA = "0xB443", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006920 RID: 26912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006920")]
		[Address(RVA = "0xB444", Offset = "0xB444", VA = "0xB444")]
		private void ControllerOnInitEvent()
		{
		}

		// Token: 0x040037CB RID: 14283
		[Token(Token = "0x40037CB")]
		[FieldOffset(Offset = "0x10")]
		private ExperimentsEvents _events;

		// Token: 0x040037CC RID: 14284
		[Token(Token = "0x40037CC")]
		[FieldOffset(Offset = "0x14")]
		private ExperimentsModel _model;

		// Token: 0x040037CD RID: 14285
		[Token(Token = "0x40037CD")]
		[FieldOffset(Offset = "0x18")]
		private ExperimentsController _controller;

		// Token: 0x040037CE RID: 14286
		[Token(Token = "0x40037CE")]
		[FieldOffset(Offset = "0x1C")]
		private IGame _game;
	}
}
