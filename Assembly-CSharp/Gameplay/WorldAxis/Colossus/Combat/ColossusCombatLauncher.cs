using System;
using System.Runtime.CompilerServices;
using Core.Gameplay;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Combat;
using Protocol.Dic;
using Protocol.Partycombat;
using ServicesNamespace;
using Utils;

namespace Gameplay.WorldAxis.Colossus.Combat
{
	// Token: 0x02000337 RID: 823
	[Token(Token = "0x2000337")]
	public class ColossusCombatLauncher : IDisposable, IColossusCombatLauncher
	{
		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x00004A28 File Offset: 0x00002C28
		// (set) Token: 0x060012EE RID: 4846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002ED")]
		public bool IsRun
		{
			[Token(Token = "0x60012ED")]
			[Address(RVA = "0x64E7", Offset = "0x64E7", VA = "0x64E7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60012EE")]
			[Address(RVA = "0x64E8", Offset = "0x64E8", VA = "0x64E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012EF")]
		[Address(RVA = "0x64E9", Offset = "0x64E9", VA = "0x64E9")]
		public ColossusCombatLauncher(IGame game, PartyCombatService service)
		{
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F0")]
		[Address(RVA = "0x64EA", Offset = "0x64EA", VA = "0x64EA")]
		public void Run()
		{
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F1")]
		[Address(RVA = "0x64EB", Offset = "0x64EB", VA = "0x64EB")]
		public void Stop()
		{
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F2")]
		[Address(RVA = "0x64EC", Offset = "0x64EC", VA = "0x64EC", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F3")]
		[Address(RVA = "0x64ED", Offset = "0x64ED", VA = "0x64ED")]
		private void SetAwaitJumpToCombat(ProtoJumpToCombatEvt value)
		{
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F4")]
		[Address(RVA = "0x64EE", Offset = "0x64EE", VA = "0x64EE")]
		private void HandleCombatCompleteEvent(Protocol.Partycombat.ProtoCombatCompleteEvt msg)
		{
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F5")]
		[Address(RVA = "0x64EF", Offset = "0x64EF", VA = "0x64EF")]
		private void HandleJumpToCombatEvent(ProtoJumpToCombatEvt msg)
		{
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00004A40 File Offset: 0x00002C40
		[Token(Token = "0x60012F6")]
		[Address(RVA = "0x64F0", Offset = "0x64F0", VA = "0x64F0")]
		private bool TryRun_Internal([CanBeNull] ColossusDic colossus, [CanBeNull] BackTime backTime)
		{
			return default(bool);
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F7")]
		[Address(RVA = "0x64F1", Offset = "0x64F1", VA = "0x64F1", Slot = "5")]
		public void NotifyAboutStop()
		{
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00004A58 File Offset: 0x00002C58
		[Token(Token = "0x60012F8")]
		[Address(RVA = "0x64F2", Offset = "0x64F2", VA = "0x64F2", Slot = "6")]
		public bool TryRun()
		{
			return default(bool);
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00004A70 File Offset: 0x00002C70
		[Token(Token = "0x60012F9")]
		[Address(RVA = "0x64F3", Offset = "0x64F3", VA = "0x64F3", Slot = "7")]
		public bool TryRun(BackTime backTime)
		{
			return default(bool);
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00004A88 File Offset: 0x00002C88
		[Token(Token = "0x60012FA")]
		[Address(RVA = "0x64F4", Offset = "0x64F4", VA = "0x64F4", Slot = "8")]
		public bool TryRun(ColossusDic colossus)
		{
			return default(bool);
		}

		// Token: 0x04000A2D RID: 2605
		[Token(Token = "0x4000A2D")]
		[FieldOffset(Offset = "0x8")]
		private IGame _game;

		// Token: 0x04000A2E RID: 2606
		[Token(Token = "0x4000A2E")]
		[FieldOffset(Offset = "0xC")]
		private PartyCombatService _service;

		// Token: 0x04000A2F RID: 2607
		[Token(Token = "0x4000A2F")]
		[FieldOffset(Offset = "0x10")]
		private ProtoJumpToCombatEvt _jumpToCombatMsg;
	}
}
