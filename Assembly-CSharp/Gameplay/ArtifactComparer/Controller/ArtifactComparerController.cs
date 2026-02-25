using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Skills;
using Gameplay.ArtifactComparer.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.ArtifactComparer.Controller
{
	// Token: 0x02000CEA RID: 3306
	[Token(Token = "0x2000CEA")]
	public class ArtifactComparerController : AbstractController<ArtifactComparerModel, ArtifactComparerEvents>
	{
		// Token: 0x06005069 RID: 20585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005069")]
		[Address(RVA = "0x9E7A", Offset = "0x9E7A", VA = "0x9E7A")]
		public ArtifactComparerController(ArtifactComparerModel model, ArtifactComparerEvents events)
		{
		}

		// Token: 0x0600506A RID: 20586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600506A")]
		[Address(RVA = "0x9E7B", Offset = "0x9E7B", VA = "0x9E7B", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x0600506B RID: 20587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600506B")]
		[Address(RVA = "0x9E7C", Offset = "0x9E7C", VA = "0x9E7C")]
		private void ArtifactReforgedEvent(ArtifactData artifactData)
		{
		}

		// Token: 0x0600506C RID: 20588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600506C")]
		[Address(RVA = "0x9E7D", Offset = "0x9E7D", VA = "0x9E7D")]
		private void NewEquipEvent()
		{
		}

		// Token: 0x0600506D RID: 20589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600506D")]
		[Address(RVA = "0x9E7E", Offset = "0x9E7E", VA = "0x9E7E")]
		private void InventoryControllerInitEvent()
		{
		}

		// Token: 0x0600506E RID: 20590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600506E")]
		[Address(RVA = "0x9E7F", Offset = "0x9E7F", VA = "0x9E7F")]
		private void UserOnUserSkillsChangedEvent()
		{
		}

		// Token: 0x0600506F RID: 20591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600506F")]
		[Address(RVA = "0x9E80", Offset = "0x9E80", VA = "0x9E80")]
		private void InventoryChangedEvent()
		{
		}

		// Token: 0x06005070 RID: 20592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005070")]
		[Address(RVA = "0x9E81", Offset = "0x9E81", VA = "0x9E81", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06005071 RID: 20593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005071")]
		[Address(RVA = "0x9E82", Offset = "0x9E82", VA = "0x9E82")]
		public void Compare(out List<ComparedSkillData> artifactSkills1, out List<ComparedSkillData> artifactSkills2)
		{
		}

		// Token: 0x06005072 RID: 20594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005072")]
		[Address(RVA = "0x9E83", Offset = "0x9E83", VA = "0x9E83")]
		public void SetSkillEnable(int skillId, bool enabled)
		{
		}

		// Token: 0x06005073 RID: 20595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005073")]
		[Address(RVA = "0x9E84", Offset = "0x9E84", VA = "0x9E84")]
		public void SetTargetArtifact(ArtifactData targetArtifact)
		{
		}

		// Token: 0x06005074 RID: 20596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005074")]
		[Address(RVA = "0x9E85", Offset = "0x9E85", VA = "0x9E85")]
		private void RecalculateTargetArtifactPowerIfNeeded()
		{
		}

		// Token: 0x06005075 RID: 20597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005075")]
		[Address(RVA = "0x9E86", Offset = "0x9E86", VA = "0x9E86")]
		private void RecalculateArtifactsPower()
		{
		}

		// Token: 0x06005076 RID: 20598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005076")]
		[Address(RVA = "0x1D9D", Offset = "0x1D9D", VA = "0x1D9D")]
		public void RecalculateArtifactPower(ArtifactData artifactData)
		{
		}

		// Token: 0x06005077 RID: 20599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005077")]
		[Address(RVA = "0x1D9E", Offset = "0x1D9E", VA = "0x1D9E")]
		[CompilerGenerated]
		internal static void <RecalculateArtifactsPower>g__CheckIfBest|12_0(ArtifactData artifact, ref ArtifactComparerController.<>c__DisplayClass12_0 A_1)
		{
		}

		// Token: 0x06005078 RID: 20600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005078")]
		[Address(RVA = "0x9E87", Offset = "0x9E87", VA = "0x9E87")]
		[CompilerGenerated]
		private void <RecalculateArtifactPower>g__SetArtifactPower|13_0(ArtifactData artifact, SkillCollection power)
		{
		}

		// Token: 0x06005079 RID: 20601 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005079")]
		[Address(RVA = "0x9E88", Offset = "0x9E88", VA = "0x9E88")]
		[CompilerGenerated]
		private ArtifactData <RecalculateArtifactPower>g__GetEquippedArtifactFor|13_1(ArtifactData artifact)
		{
			return null;
		}
	}
}
