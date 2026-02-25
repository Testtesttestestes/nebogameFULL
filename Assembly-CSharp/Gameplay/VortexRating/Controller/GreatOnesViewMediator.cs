using System;
using System.Runtime.CompilerServices;
using Gameplay.VortexRating.Events;
using Gameplay.VortexRating.Model;
using Gameplay.VortexRating.View.GreatOnesTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.VortexRating.Controller
{
	// Token: 0x02000397 RID: 919
	[Token(Token = "0x2000397")]
	public class GreatOnesViewMediator : AbstractViewMediator<VortexRatingModel, VortexRatingEvents, VortexRatingController, GreatOnesView>, IHideableMediator
	{
		// Token: 0x06001566 RID: 5478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001566")]
		[Address(RVA = "0x6728", Offset = "0x6728", VA = "0x6728")]
		public GreatOnesViewMediator(VortexRatingModel model, VortexRatingEvents events, VortexRatingController controller)
		{
		}

		// Token: 0x1700038C RID: 908
		// (set) Token: 0x06001567 RID: 5479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038C")]
		public override GreatOnesView View
		{
			[Token(Token = "0x6001567")]
			[Address(RVA = "0x6729", Offset = "0x6729", VA = "0x6729", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x1700038D RID: 909
		// (set) Token: 0x06001568 RID: 5480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038D")]
		public override VortexRatingEvents Events
		{
			[Token(Token = "0x6001568")]
			[Address(RVA = "0x672A", Offset = "0x672A", VA = "0x672A", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001569")]
		[Address(RVA = "0x672B", Offset = "0x672B", VA = "0x672B")]
		private void VotedEventHandler(ulong userId)
		{
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156A")]
		[Address(RVA = "0x672C", Offset = "0x672C", VA = "0x672C")]
		private void GreatUserSetChangedEventHandler(ulong userId)
		{
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156B")]
		[Address(RVA = "0x672D", Offset = "0x672D", VA = "0x672D")]
		private void LikeButtonClickedEventHandler(GreatUserView user)
		{
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156C")]
		[Address(RVA = "0x672E", Offset = "0x672E", VA = "0x672E")]
		private void GreatTopRequestedEventHandler()
		{
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156D")]
		[Address(RVA = "0x672F", Offset = "0x672F", VA = "0x672F")]
		private void RenderUsers()
		{
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156E")]
		[Address(RVA = "0x6730", Offset = "0x6730", VA = "0x6730")]
		private void CheckForMaxVotes()
		{
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156F")]
		[Address(RVA = "0x6731", Offset = "0x6731", VA = "0x6731", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001570")]
		[Address(RVA = "0x6732", Offset = "0x6732", VA = "0x6732")]
		[CompilerGenerated]
		private void <CheckForMaxVotes>g__DisableAllLikeButtons|11_0()
		{
		}

		// Token: 0x04000B67 RID: 2919
		[Token(Token = "0x4000B67")]
		[FieldOffset(Offset = "0x18")]
		private GreatUserView[] _userViews;
	}
}
