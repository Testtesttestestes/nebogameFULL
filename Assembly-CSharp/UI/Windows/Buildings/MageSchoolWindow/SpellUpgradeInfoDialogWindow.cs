using System;
using Gameplay.School.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace UI.Windows.Buildings.MageSchoolWindow
{
	// Token: 0x020002C1 RID: 705
	[Token(Token = "0x20002C1")]
	public class SpellUpgradeInfoDialogWindow : BaseDialogWindow<SpellUpgradeInfoDialogWindow.SpellUpgradeInfoDialogWindowArgs>
	{
		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700026F")]
		public override string WindowId
		{
			[Token(Token = "0x6001099")]
			[Address(RVA = "0x6296", Offset = "0x6296", VA = "0x6296", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600109A")]
		[Address(RVA = "0x6297", Offset = "0x6297", VA = "0x6297", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600109B")]
		[Address(RVA = "0x6298", Offset = "0x6298", VA = "0x6298")]
		public static SpellUpgradeInfoDialogWindow Show(SchoolSpellData spellData, SpellDic nextSpellDic, SpellLevelDic nextSpellLevelDic)
		{
			return null;
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600109C")]
		[Address(RVA = "0x6299", Offset = "0x6299", VA = "0x6299")]
		public static SpellUpgradeInfoDialogWindow Show(SchoolSpellData spellData)
		{
			return null;
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600109D")]
		[Address(RVA = "0x629A", Offset = "0x629A", VA = "0x629A")]
		public SpellUpgradeInfoDialogWindow()
		{
		}

		// Token: 0x04000895 RID: 2197
		[Token(Token = "0x4000895")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/MageSchool/SpellUpgradeInfoDialogWindow";

		// Token: 0x04000896 RID: 2198
		[Token(Token = "0x4000896")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SpellDescriptionGroup _currentDescription;

		// Token: 0x04000897 RID: 2199
		[Token(Token = "0x4000897")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private SpellDescriptionGroup _nextDescription;

		// Token: 0x04000898 RID: 2200
		[Token(Token = "0x4000898")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _spacer;

		// Token: 0x020002C2 RID: 706
		[Token(Token = "0x20002C2")]
		public class SpellUpgradeInfoDialogWindowArgs : BaseDialogWindow<SpellUpgradeInfoDialogWindow.SpellUpgradeInfoDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x0600109E RID: 4254 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600109E")]
			[Address(RVA = "0x629B", Offset = "0x629B", VA = "0x629B")]
			public SpellUpgradeInfoDialogWindowArgs()
			{
			}

			// Token: 0x04000899 RID: 2201
			[Token(Token = "0x4000899")]
			[FieldOffset(Offset = "0x2C")]
			public SchoolSpellData SpellData;

			// Token: 0x0400089A RID: 2202
			[Token(Token = "0x400089A")]
			[FieldOffset(Offset = "0x30")]
			public SpellDic NextSpellDic;

			// Token: 0x0400089B RID: 2203
			[Token(Token = "0x400089B")]
			[FieldOffset(Offset = "0x34")]
			public SpellLevelDic NextSpellLevelDic;
		}
	}
}
