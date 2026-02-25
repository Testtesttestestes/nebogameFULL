using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Sorting;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.CaptainTab;
using Il2CppDummyDll;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BB4 RID: 2996
	[Token(Token = "0x2000BB4")]
	public class BossTeamEditViewMediator : AbstractBossWindowViewMediator<BossTeamEditView>
	{
		// Token: 0x0600497D RID: 18813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600497D")]
		[Address(RVA = "0x97EF", Offset = "0x97EF", VA = "0x97EF")]
		public BossTeamEditViewMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		}

		// Token: 0x0600497E RID: 18814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600497E")]
		[Address(RVA = "0x97F0", Offset = "0x97F0", VA = "0x97F0", Slot = "21")]
		protected override void ResetEvents(BossInstanceEvents events)
		{
		}

		// Token: 0x0600497F RID: 18815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600497F")]
		[Address(RVA = "0x97F1", Offset = "0x97F1", VA = "0x97F1", Slot = "22")]
		protected override void SetupEvents(BossInstanceEvents events)
		{
		}

		// Token: 0x06004980 RID: 18816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004980")]
		[Address(RVA = "0x97F2", Offset = "0x97F2", VA = "0x97F2", Slot = "23")]
		protected override void ResetView(BossTeamEditView view)
		{
		}

		// Token: 0x06004981 RID: 18817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004981")]
		[Address(RVA = "0x97F3", Offset = "0x97F3", VA = "0x97F3", Slot = "24")]
		protected override void SetupView(BossTeamEditView view)
		{
		}

		// Token: 0x06004982 RID: 18818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004982")]
		[Address(RVA = "0x97F4", Offset = "0x97F4", VA = "0x97F4")]
		private void SortControlOnComparerChangedEvent(IGameDataComparer<UserData> comparer)
		{
		}

		// Token: 0x06004983 RID: 18819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004983")]
		[Address(RVA = "0x97F5", Offset = "0x97F5", VA = "0x97F5")]
		private void ConfirmButtonClickedHandler()
		{
		}

		// Token: 0x06004984 RID: 18820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004984")]
		[Address(RVA = "0x97F6", Offset = "0x97F6", VA = "0x97F6")]
		private void HandleModifyQueue()
		{
		}

		// Token: 0x06004985 RID: 18821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004985")]
		[Address(RVA = "0x97F7", Offset = "0x97F7", VA = "0x97F7")]
		private void CancelButtonClickedHandler()
		{
		}

		// Token: 0x06004986 RID: 18822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004986")]
		[Address(RVA = "0x97F8", Offset = "0x97F8", VA = "0x97F8")]
		private void CloseEditWindow()
		{
		}

		// Token: 0x06004987 RID: 18823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004987")]
		[Address(RVA = "0x97F9", Offset = "0x97F9", VA = "0x97F9")]
		private void ViewOnClickOnTeamMemberClickedEvent(TeamData.TeamAssistantData assistantData)
		{
		}

		// Token: 0x06004988 RID: 18824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004988")]
		[Address(RVA = "0x97FA", Offset = "0x97FA", VA = "0x97FA")]
		private void ViewOnClickOnPossibleAssistantEvent(UserData userData)
		{
		}

		// Token: 0x06004989 RID: 18825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004989")]
		[Address(RVA = "0x97FB", Offset = "0x97FB", VA = "0x97FB")]
		private void MoveToTeam(UserData userData)
		{
		}

		// Token: 0x0600498A RID: 18826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600498A")]
		[Address(RVA = "0x97FC", Offset = "0x97FC", VA = "0x97FC")]
		private void RemoveFromTeam(TeamData.TeamAssistantData assistantData)
		{
		}

		// Token: 0x0600498B RID: 18827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600498B")]
		[Address(RVA = "0x97FD", Offset = "0x97FD", VA = "0x97FD")]
		private void HandleInviteOrKickEvent(ulong uid)
		{
		}

		// Token: 0x0600498C RID: 18828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600498C")]
		[Address(RVA = "0x97FE", Offset = "0x97FE", VA = "0x97FE")]
		private void PossibleAssistantsReceivedEvent(IList<ulong> list)
		{
		}

		// Token: 0x0600498D RID: 18829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600498D")]
		[Address(RVA = "0x97FF", Offset = "0x97FF", VA = "0x97FF")]
		private void ResultCallback(long operationIndex, params UserData[] data)
		{
		}

		// Token: 0x0600498E RID: 18830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600498E")]
		[Address(RVA = "0x9800", Offset = "0x9800", VA = "0x9800")]
		private void RenderPossibleAssistants()
		{
		}

		// Token: 0x0600498F RID: 18831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600498F")]
		[Address(RVA = "0x9801", Offset = "0x9801", VA = "0x9801", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x04002800 RID: 10240
		[Token(Token = "0x4002800")]
		[FieldOffset(Offset = "0x18")]
		private TeamData _temporaryTeamData;

		// Token: 0x04002801 RID: 10241
		[Token(Token = "0x4002801")]
		[FieldOffset(Offset = "0x1C")]
		private List<UserData> _possibleAssistantsUserData;

		// Token: 0x04002802 RID: 10242
		[Token(Token = "0x4002802")]
		[FieldOffset(Offset = "0x20")]
		private BossTeamEditViewMediator.ModifyTeamQueueData _modifyQueue;

		// Token: 0x04002803 RID: 10243
		[Token(Token = "0x4002803")]
		[FieldOffset(Offset = "0x24")]
		private bool _isDisposed;

		// Token: 0x02000BB5 RID: 2997
		[Token(Token = "0x2000BB5")]
		private class ModifyTeamQueueData : IEnumerator<ulong>, IEnumerator, IDisposable
		{
			// Token: 0x17000EDE RID: 3806
			// (get) Token: 0x06004990 RID: 18832 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
			// (set) Token: 0x06004991 RID: 18833 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EDE")]
			public BossTeamEditViewMediator.ModifyTeamQueueData.ModifyType CurrentOperation
			{
				[Token(Token = "0x6004990")]
				[Address(RVA = "0x9802", Offset = "0x9802", VA = "0x9802")]
				[CompilerGenerated]
				get
				{
					return (BossTeamEditViewMediator.ModifyTeamQueueData.ModifyType)0;
				}
				[Token(Token = "0x6004991")]
				[Address(RVA = "0x9803", Offset = "0x9803", VA = "0x9803")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06004992 RID: 18834 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
			[Token(Token = "0x6004992")]
			[Address(RVA = "0x9804", Offset = "0x9804", VA = "0x9804", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06004993 RID: 18835 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004993")]
			[Address(RVA = "0x9805", Offset = "0x9805", VA = "0x9805", Slot = "8")]
			public void Reset()
			{
			}

			// Token: 0x17000EDF RID: 3807
			// (get) Token: 0x06004994 RID: 18836 RVA: 0x0000D908 File Offset: 0x0000BB08
			[Token(Token = "0x17000EDF")]
			public ulong Current
			{
				[Token(Token = "0x6004994")]
				[Address(RVA = "0x9806", Offset = "0x9806", VA = "0x9806", Slot = "4")]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x17000EE0 RID: 3808
			// (get) Token: 0x06004995 RID: 18837 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000EE0")]
			private object Current
			{
				[Token(Token = "0x6004995")]
				[Address(RVA = "0x9807", Offset = "0x9807", VA = "0x9807", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x06004996 RID: 18838 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004996")]
			[Address(RVA = "0x9808", Offset = "0x9808", VA = "0x9808", Slot = "5")]
			public void Dispose()
			{
			}

			// Token: 0x06004997 RID: 18839 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004997")]
			[Address(RVA = "0x9809", Offset = "0x9809", VA = "0x9809")]
			public ModifyTeamQueueData()
			{
			}

			// Token: 0x04002804 RID: 10244
			[Token(Token = "0x4002804")]
			[FieldOffset(Offset = "0x8")]
			public List<ulong> UsersToAdd;

			// Token: 0x04002805 RID: 10245
			[Token(Token = "0x4002805")]
			[FieldOffset(Offset = "0xC")]
			public List<ulong> UsersToRemove;

			// Token: 0x04002807 RID: 10247
			[Token(Token = "0x4002807")]
			[FieldOffset(Offset = "0x18")]
			private ulong _current;

			// Token: 0x02000BB6 RID: 2998
			[Token(Token = "0x2000BB6")]
			public enum ModifyType
			{
				// Token: 0x04002809 RID: 10249
				[Token(Token = "0x4002809")]
				ADD = 1,
				// Token: 0x0400280A RID: 10250
				[Token(Token = "0x400280A")]
				REMOVE
			}
		}
	}
}
