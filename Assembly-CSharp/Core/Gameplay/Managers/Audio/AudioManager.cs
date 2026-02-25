using System;
using System.Runtime.CompilerServices;
using Gameplay.Sound.Control;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Audio
{
	// Token: 0x020011F6 RID: 4598
	[Token(Token = "0x20011F6")]
	public class AudioManager : IGameManager, IBaseManager
	{
		// Token: 0x140002D1 RID: 721
		// (add) Token: 0x06006D32 RID: 27954 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D33 RID: 27955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002D1")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006D32")]
			[Address(RVA = "0xB81A", Offset = "0xB81A", VA = "0xB81A", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D33")]
			[Address(RVA = "0xB81B", Offset = "0xB81B", VA = "0xB81B", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002D2 RID: 722
		// (add) Token: 0x06006D34 RID: 27956 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D35 RID: 27957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002D2")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006D34")]
			[Address(RVA = "0xB81C", Offset = "0xB81C", VA = "0xB81C", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D35")]
			[Address(RVA = "0xB81D", Offset = "0xB81D", VA = "0xB81D", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x06006D36 RID: 27958 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006D37 RID: 27959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001636")]
		public IGame Game
		{
			[Token(Token = "0x6006D36")]
			[Address(RVA = "0xB81E", Offset = "0xB81E", VA = "0xB81E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D37")]
			[Address(RVA = "0xB81F", Offset = "0xB81F", VA = "0xB81F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006D38 RID: 27960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D38")]
		[Address(RVA = "0xB820", Offset = "0xB820", VA = "0xB820")]
		public AudioManager(IGame game)
		{
		}

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x06006D39 RID: 27961 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006D3A RID: 27962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001637")]
		public AudioController Controller
		{
			[Token(Token = "0x6006D39")]
			[Address(RVA = "0xB821", Offset = "0xB821", VA = "0xB821")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D3A")]
			[Address(RVA = "0xB822", Offset = "0xB822", VA = "0xB822")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006D3B RID: 27963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D3B")]
		[Address(RVA = "0xB823", Offset = "0xB823", VA = "0xB823", Slot = "11")]
		public virtual void Init()
		{
		}

		// Token: 0x06006D3C RID: 27964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D3C")]
		[Address(RVA = "0xB824", Offset = "0xB824", VA = "0xB824")]
		protected void HandleInitEvent()
		{
		}

		// Token: 0x06006D3D RID: 27965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D3D")]
		[Address(RVA = "0xB825", Offset = "0xB825", VA = "0xB825", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x06006D3E RID: 27966 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001638")]
		public string Name
		{
			[Token(Token = "0x6006D3E")]
			[Address(RVA = "0xB826", Offset = "0xB826", VA = "0xB826", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400392B RID: 14635
		[Token(Token = "0x400392B")]
		[FieldOffset(Offset = "0x14")]
		protected AudioSourceMediator _meditor;
	}
}
