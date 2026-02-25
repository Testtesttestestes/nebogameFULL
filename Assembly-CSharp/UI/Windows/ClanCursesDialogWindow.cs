using System;
using System.Collections.Generic;
using Gameplay.Clans.Office.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x0200025F RID: 607
	[Token(Token = "0x200025F")]
	public class ClanCursesDialogWindow : BaseDialogWindow<ClanCursesDialogWindow.ClanCursesDialogWindowArgs>
	{
		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001FC")]
		public override string WindowId
		{
			[Token(Token = "0x6000EA6")]
			[Address(RVA = "0x6126", Offset = "0x6126", VA = "0x6126", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA7")]
		[Address(RVA = "0x6127", Offset = "0x6127", VA = "0x6127", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0x6128", Offset = "0x6128", VA = "0x6128")]
		public ClanCursesDialogWindow()
		{
		}

		// Token: 0x0400075F RID: 1887
		[Token(Token = "0x400075F")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Clans/ClanCursesDialogWindow";

		// Token: 0x04000760 RID: 1888
		[Token(Token = "0x4000760")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ClanCurseView _cursePrefab;

		// Token: 0x02000260 RID: 608
		[Token(Token = "0x2000260")]
		public class ClanCursesDialogWindowArgs : BaseDialogWindow<ClanCursesDialogWindow.ClanCursesDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06000EA9 RID: 3753 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000EA9")]
			[Address(RVA = "0x6129", Offset = "0x6129", VA = "0x6129")]
			public ClanCursesDialogWindowArgs(IList<ClanCurseData> restrictions)
			{
			}

			// Token: 0x04000761 RID: 1889
			[Token(Token = "0x4000761")]
			[FieldOffset(Offset = "0x2C")]
			public IList<ClanCurseData> Restrictions;
		}
	}
}
