using System;
using Gameplay.Battles.Events;
using Gameplay.Battles.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Battles.Controller
{
	// Token: 0x02000C2F RID: 3119
	[Token(Token = "0x2000C2F")]
	public class BattlesController : AbstractController<BattlesModel, BattlesEvents>
	{
		// Token: 0x06004C00 RID: 19456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C00")]
		[Address(RVA = "0x9A44", Offset = "0x9A44", VA = "0x9A44")]
		public BattlesController(BattlesModel model, BattlesEvents events)
		{
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06004C01 RID: 19457 RVA: 0x0000E040 File Offset: 0x0000C240
		[Token(Token = "0x17000F54")]
		private bool ArenaBuilt
		{
			[Token(Token = "0x6004C01")]
			[Address(RVA = "0x9A45", Offset = "0x9A45", VA = "0x9A45")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004C02 RID: 19458 RVA: 0x0000E058 File Offset: 0x0000C258
		[Token(Token = "0x6004C02")]
		[Address(RVA = "0x9A46", Offset = "0x9A46", VA = "0x9A46")]
		public bool TryRunArenaEqualLevel()
		{
			return default(bool);
		}

		// Token: 0x06004C03 RID: 19459 RVA: 0x0000E070 File Offset: 0x0000C270
		[Token(Token = "0x6004C03")]
		[Address(RVA = "0x9A47", Offset = "0x9A47", VA = "0x9A47")]
		public bool TryRunArenaEqualPower()
		{
			return default(bool);
		}

		// Token: 0x06004C04 RID: 19460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C04")]
		[Address(RVA = "0x9A48", Offset = "0x9A48", VA = "0x9A48")]
		public void ShowArenaTournamentAdepts()
		{
		}

		// Token: 0x06004C05 RID: 19461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C05")]
		[Address(RVA = "0x9A49", Offset = "0x9A49", VA = "0x9A49")]
		public void ShowArenaTournamentGladiators()
		{
		}

		// Token: 0x06004C06 RID: 19462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C06")]
		[Address(RVA = "0x9A4A", Offset = "0x9A4A", VA = "0x9A4A")]
		public void ShowMarshals()
		{
		}

		// Token: 0x06004C07 RID: 19463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C07")]
		[Address(RVA = "0x9A4B", Offset = "0x9A4B", VA = "0x9A4B")]
		public void ShowBosses()
		{
		}

		// Token: 0x06004C08 RID: 19464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C08")]
		[Address(RVA = "0x9A4C", Offset = "0x9A4C", VA = "0x9A4C")]
		public void ShowVortex()
		{
		}

		// Token: 0x06004C09 RID: 19465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C09")]
		[Address(RVA = "0x9A4D", Offset = "0x9A4D", VA = "0x9A4D")]
		public void ShowThemeDuel()
		{
		}

		// Token: 0x06004C0A RID: 19466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C0A")]
		[Address(RVA = "0x9A4E", Offset = "0x9A4E", VA = "0x9A4E")]
		public void ShowWorldAxis()
		{
		}

		// Token: 0x06004C0B RID: 19467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C0B")]
		[Address(RVA = "0x9A4F", Offset = "0x9A4F", VA = "0x9A4F")]
		private void ShowBuildArenaToast()
		{
		}

		// Token: 0x06004C0C RID: 19468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C0C")]
		[Address(RVA = "0x9A50", Offset = "0x9A50", VA = "0x9A50", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06004C0D RID: 19469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C0D")]
		[Address(RVA = "0x9A51", Offset = "0x9A51", VA = "0x9A51", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06004C0E RID: 19470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C0E")]
		[Address(RVA = "0x9A52", Offset = "0x9A52", VA = "0x9A52")]
		private void HandleBossTotalNotificationNumChangedEvent()
		{
		}

		// Token: 0x06004C0F RID: 19471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C0F")]
		[Address(RVA = "0x9A53", Offset = "0x9A53", VA = "0x9A53")]
		private void HandleUserLevelChangedEvent()
		{
		}

		// Token: 0x06004C10 RID: 19472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C10")]
		[Address(RVA = "0x9A54", Offset = "0x9A54", VA = "0x9A54")]
		public void SetNotificationCount(int value)
		{
		}
	}
}
