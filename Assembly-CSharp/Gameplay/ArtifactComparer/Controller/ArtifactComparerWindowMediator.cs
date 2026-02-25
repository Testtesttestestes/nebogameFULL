using System;
using System.Collections.Generic;
using Core.Data;
using Core.Data.InfoRows;
using Gameplay.ArtifactComparer.Model;
using Gameplay.ArtifactComparer.View;
using Gameplay.ArtifactComparer.View.SkillSelector;
using Gameplay.Inventory.Controller.Filters;
using Il2CppDummyDll;
using MVC;
using UI;
using UI.Filters;

namespace Gameplay.ArtifactComparer.Controller
{
	// Token: 0x02000CED RID: 3309
	[Token(Token = "0x2000CED")]
	public class ArtifactComparerWindowMediator : AbstractViewMediator<ArtifactComparerModel, ArtifactComparerEvents, ArtifactComparerController, ArtifactComparerWindow>
	{
		// Token: 0x0600507B RID: 20603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600507B")]
		[Address(RVA = "0x9E8A", Offset = "0x9E8A", VA = "0x9E8A")]
		public ArtifactComparerWindowMediator(ArtifactComparerModel model, ArtifactComparerEvents events, ArtifactComparerController controller, bool sameArticulTypeOnly)
		{
		}

		// Token: 0x17001048 RID: 4168
		// (set) Token: 0x0600507C RID: 20604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001048")]
		public override ArtifactComparerEvents Events
		{
			[Token(Token = "0x600507C")]
			[Address(RVA = "0x9E8B", Offset = "0x9E8B", VA = "0x9E8B", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600507D RID: 20605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600507D")]
		[Address(RVA = "0x9E8C", Offset = "0x9E8C", VA = "0x9E8C")]
		private void PowersChangedEvent()
		{
		}

		// Token: 0x0600507E RID: 20606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600507E")]
		[Address(RVA = "0x9E8D", Offset = "0x9E8D", VA = "0x9E8D")]
		private void InventoryChangedEvent()
		{
		}

		// Token: 0x0600507F RID: 20607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600507F")]
		[Address(RVA = "0x9E8E", Offset = "0x9E8E", VA = "0x9E8E")]
		private void TargetArtifactChangedEvent()
		{
		}

		// Token: 0x17001049 RID: 4169
		// (set) Token: 0x06005080 RID: 20608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001049")]
		public override ArtifactComparerWindow View
		{
			[Token(Token = "0x6005080")]
			[Address(RVA = "0x9E8F", Offset = "0x9E8F", VA = "0x9E8F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06005081 RID: 20609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005081")]
		[Address(RVA = "0x9E90", Offset = "0x9E90", VA = "0x9E90")]
		private void SkillSelectorButtonClickHandler(ToggleButton toggleButton)
		{
		}

		// Token: 0x06005082 RID: 20610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005082")]
		[Address(RVA = "0x9E91", Offset = "0x9E91", VA = "0x9E91")]
		private void SkillSelectorViewOnSelectEvent(SkillSelectorItemView skill)
		{
		}

		// Token: 0x06005083 RID: 20611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005083")]
		[Address(RVA = "0x9E92", Offset = "0x9E92", VA = "0x9E92")]
		private void Render()
		{
		}

		// Token: 0x06005084 RID: 20612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005084")]
		[Address(RVA = "0x9E93", Offset = "0x9E93", VA = "0x9E93")]
		private void RenderTargetArtifact()
		{
		}

		// Token: 0x06005085 RID: 20613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005085")]
		[Address(RVA = "0x9E94", Offset = "0x9E94", VA = "0x9E94")]
		private void ViewOnNewDataEvent(ArtifactComparerWindow.ArtifactComparerWindowArgs newData)
		{
		}

		// Token: 0x06005086 RID: 20614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005086")]
		[Address(RVA = "0x9E95", Offset = "0x9E95", VA = "0x9E95")]
		private void FiltersViewOnChangedEvent()
		{
		}

		// Token: 0x06005087 RID: 20615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005087")]
		[Address(RVA = "0x9E96", Offset = "0x9E96", VA = "0x9E96")]
		private void SetFiltersData()
		{
		}

		// Token: 0x06005088 RID: 20616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005088")]
		[Address(RVA = "0x9E97", Offset = "0x9E97", VA = "0x9E97")]
		private void ViewOnSelectArtifactEvent(ArtifactData artifactData)
		{
		}

		// Token: 0x06005089 RID: 20617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005089")]
		[Address(RVA = "0x9E98", Offset = "0x9E98", VA = "0x9E98")]
		private void RenderPossibleArtifacts()
		{
		}

		// Token: 0x0600508A RID: 20618 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600508A")]
		[Address(RVA = "0x9E99", Offset = "0x9E99", VA = "0x9E99")]
		private IList<ArtifactData> FilterArtifacts(IList<ArtifactData> rawData)
		{
			return null;
		}

		// Token: 0x0600508B RID: 20619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600508B")]
		[Address(RVA = "0x9E9A", Offset = "0x9E9A", VA = "0x9E9A")]
		private void RenderCurrentComparison()
		{
		}

		// Token: 0x0600508C RID: 20620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600508C")]
		[Address(RVA = "0x9E9B", Offset = "0x9E9B", VA = "0x9E9B")]
		private void RenderTable()
		{
		}

		// Token: 0x0600508D RID: 20621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600508D")]
		[Address(RVA = "0x9E9C", Offset = "0x9E9C", VA = "0x9E9C")]
		private void AddSkills(in List<ArtifactComparerRowData> list, List<ComparedSkillData> skills1, List<ComparedSkillData> skills2)
		{
		}

		// Token: 0x0600508E RID: 20622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600508E")]
		[Address(RVA = "0x9E9D", Offset = "0x9E9D", VA = "0x9E9D")]
		private void AddTitle(in List<ArtifactComparerRowData> list, string title)
		{
		}

		// Token: 0x0600508F RID: 20623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600508F")]
		[Address(RVA = "0x9E9E", Offset = "0x9E9E", VA = "0x9E9E")]
		private void AddRow(in List<ArtifactComparerRowData> list, ArtifactComparerRowData.RowType rowType, IInformationRow targetProp, IInformationRow comparableProp)
		{
		}

		// Token: 0x06005090 RID: 20624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005090")]
		[Address(RVA = "0x9E9F", Offset = "0x9E9F", VA = "0x9E9F")]
		private void AddRows(in List<ArtifactComparerRowData> result, ArtifactComparerRowData.RowType rowType, List<IInformationRow> targetProps, List<IInformationRow> comparableProps)
		{
		}

		// Token: 0x04002C05 RID: 11269
		[Token(Token = "0x4002C05")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<FilterInfo.FilterType, IArtifactFilter> _filters;

		// Token: 0x04002C06 RID: 11270
		[Token(Token = "0x4002C06")]
		[FieldOffset(Offset = "0x1C")]
		private readonly bool _sameArticulTypeOnly;
	}
}
