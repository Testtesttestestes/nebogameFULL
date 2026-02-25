using System;
using System.Collections.Generic;
using Core.Sorting;
using Gameplay.Auchan.Controller.Filters;
using Gameplay.Auchan.Events;
using Gameplay.Auchan.Model;
using Gameplay.Auchan.View;
using Il2CppDummyDll;
using MVC;
using UI.Filters;

namespace Gameplay.Auchan.Controller
{
	// Token: 0x02000C9F RID: 3231
	[Token(Token = "0x2000C9F")]
	public class AuchanViewMediator : AbstractViewMediator<AuchanModel, AuchanEvents, AuchanController, AuchanView>
	{
		// Token: 0x06004E9E RID: 20126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E9E")]
		[Address(RVA = "0x9CCF", Offset = "0x9CCF", VA = "0x9CCF")]
		public AuchanViewMediator(AuchanModel model, AuchanEvents events, AuchanController controller)
		{
		}

		// Token: 0x17000FE9 RID: 4073
		// (set) Token: 0x06004E9F RID: 20127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FE9")]
		public override AuchanView View
		{
			[Token(Token = "0x6004E9F")]
			[Address(RVA = "0x9CD0", Offset = "0x9CD0", VA = "0x9CD0", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000FEA RID: 4074
		// (set) Token: 0x06004EA0 RID: 20128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FEA")]
		public override AuchanEvents Events
		{
			[Token(Token = "0x6004EA0")]
			[Address(RVA = "0x9CD1", Offset = "0x9CD1", VA = "0x9CD1", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000FEB RID: 4075
		// (set) Token: 0x06004EA1 RID: 20129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FEB")]
		public override AuchanController Controller
		{
			[Token(Token = "0x6004EA1")]
			[Address(RVA = "0x9CD2", Offset = "0x9CD2", VA = "0x9CD2", Slot = "18")]
			set
			{
			}
		}

		// Token: 0x06004EA2 RID: 20130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EA2")]
		[Address(RVA = "0x9CD3", Offset = "0x9CD3", VA = "0x9CD3")]
		private void HandleAuchanItemBought()
		{
		}

		// Token: 0x06004EA3 RID: 20131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EA3")]
		[Address(RVA = "0x9CD4", Offset = "0x9CD4", VA = "0x9CD4")]
		private void HandleComparerChangedEvent(IGameDataComparer<AuchanArtifactData> comparer)
		{
		}

		// Token: 0x06004EA4 RID: 20132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EA4")]
		[Address(RVA = "0x9CD5", Offset = "0x9CD5", VA = "0x9CD5")]
		private void HandleToggleChanged()
		{
		}

		// Token: 0x06004EA5 RID: 20133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EA5")]
		[Address(RVA = "0x9CD6", Offset = "0x9CD6", VA = "0x9CD6")]
		private void FilterInputChanged(string str)
		{
		}

		// Token: 0x06004EA6 RID: 20134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EA6")]
		[Address(RVA = "0x9CD7", Offset = "0x9CD7", VA = "0x9CD7")]
		private void RedrawCurrentTab()
		{
		}

		// Token: 0x06004EA7 RID: 20135 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004EA7")]
		[Address(RVA = "0x9CD8", Offset = "0x9CD8", VA = "0x9CD8")]
		private Dictionary<uint, List<AuchanArtifactData>> Filter(Dictionary<uint, List<AuchanArtifactData>> items)
		{
			return null;
		}

		// Token: 0x06004EA8 RID: 20136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EA8")]
		[Address(RVA = "0x9CD9", Offset = "0x9CD9", VA = "0x9CD9")]
		private void HandleAuchanItemsInfoRequested()
		{
		}

		// Token: 0x04002AF0 RID: 10992
		[Token(Token = "0x4002AF0")]
		private const int DETECTION_LENGTH_THRESHOLD = 2;

		// Token: 0x04002AF1 RID: 10993
		[Token(Token = "0x4002AF1")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<FilterInfo.FilterType, IAuchanItemFilter> _filters;

		// Token: 0x04002AF2 RID: 10994
		[Token(Token = "0x4002AF2")]
		[FieldOffset(Offset = "0x1C")]
		private IGameDataComparer<AuchanArtifactData> _comparer;
	}
}
