using System;
using Gameplay.Boss.Controller;
using Gameplay.Boss.Events;
using Il2CppDummyDll;
using Protocol.Boss;

namespace Gameplay.Boss.Model
{
	// Token: 0x02000B90 RID: 2960
	[Token(Token = "0x2000B90")]
	public class BossInstance : IDisposable
	{
		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x0600481D RID: 18461 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E89")]
		public BossInstanceModel Model
		{
			[Token(Token = "0x600481D")]
			[Address(RVA = "0x96A0", Offset = "0x96A0", VA = "0x96A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x0600481E RID: 18462 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E8A")]
		public BossInstanceController Controller
		{
			[Token(Token = "0x600481E")]
			[Address(RVA = "0x96A1", Offset = "0x96A1", VA = "0x96A1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x0600481F RID: 18463 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E8B")]
		public BossInstanceEvents Events
		{
			[Token(Token = "0x600481F")]
			[Address(RVA = "0x96A2", Offset = "0x96A2", VA = "0x96A2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06004820 RID: 18464 RVA: 0x0000D4A0 File Offset: 0x0000B6A0
		// (set) Token: 0x06004821 RID: 18465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E8C")]
		public ulong CurrentHealth
		{
			[Token(Token = "0x6004820")]
			[Address(RVA = "0x96A3", Offset = "0x96A3", VA = "0x96A3")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6004821")]
			[Address(RVA = "0x96A4", Offset = "0x96A4", VA = "0x96A4")]
			set
			{
			}
		}

		// Token: 0x06004822 RID: 18466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004822")]
		[Address(RVA = "0x96A5", Offset = "0x96A5", VA = "0x96A5")]
		public BossInstance(InstanceInfo instanceInfo)
		{
		}

		// Token: 0x06004823 RID: 18467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004823")]
		[Address(RVA = "0x96A6", Offset = "0x96A6", VA = "0x96A6")]
		private void SetupMvc()
		{
		}

		// Token: 0x06004824 RID: 18468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004824")]
		[Address(RVA = "0x96A7", Offset = "0x96A7", VA = "0x96A7")]
		private void DisposeMvc()
		{
		}

		// Token: 0x06004825 RID: 18469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004825")]
		[Address(RVA = "0x96A8", Offset = "0x96A8", VA = "0x96A8", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04002793 RID: 10131
		[Token(Token = "0x4002793")]
		[FieldOffset(Offset = "0x8")]
		private BossInstanceModel _model;

		// Token: 0x04002794 RID: 10132
		[Token(Token = "0x4002794")]
		[FieldOffset(Offset = "0xC")]
		private BossInstanceController _controller;

		// Token: 0x04002795 RID: 10133
		[Token(Token = "0x4002795")]
		[FieldOffset(Offset = "0x10")]
		private BossInstanceEvents _events;
	}
}
