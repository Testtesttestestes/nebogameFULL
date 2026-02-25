using System;
using Gameplay.Isles.User;
using Gameplay.Tree.Control;
using Il2CppDummyDll;
using UI.Windows.Buildings;

namespace Gameplay.Tree.View
{
	// Token: 0x02000492 RID: 1170
	[Token(Token = "0x2000492")]
	public class TreeView2 : MainBuildingView2<UserIsle>, IDisposable
	{
		// Token: 0x06001BB4 RID: 7092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB4")]
		[Address(RVA = "0x6D33", Offset = "0x6D33", VA = "0x6D33", Slot = "4")]
		public override void Init(UserIsle isle)
		{
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB5")]
		[Address(RVA = "0x6D34", Offset = "0x6D34", VA = "0x6D34", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB6")]
		[Address(RVA = "0x6D35", Offset = "0x6D35", VA = "0x6D35")]
		public TreeView2()
		{
		}

		// Token: 0x04000EF9 RID: 3833
		[Token(Token = "0x4000EF9")]
		[FieldOffset(Offset = "0x1C")]
		private TreeViewMediator2 _mediator;
	}
}
