using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Balance;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using UI.Requirements;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x0200029B RID: 667
	[Token(Token = "0x200029B")]
	public class RequirementsWindow : BaseDialogWindow<RequirementsWindow.RequirementsWindowArgs>
	{
		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000231")]
		public override string WindowId
		{
			[Token(Token = "0x6000FA4")]
			[Address(RVA = "0x61CD", Offset = "0x61CD", VA = "0x61CD", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FA5")]
		[Address(RVA = "0x61CE", Offset = "0x61CE", VA = "0x61CE", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FA6")]
		[Address(RVA = "0x61CF", Offset = "0x61CF", VA = "0x61CF")]
		public static RequirementsWindow Show(RequirementsWindow.RequirementsWindowArgs args)
		{
			return null;
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FA7")]
		[Address(RVA = "0x61D0", Offset = "0x61D0", VA = "0x61D0")]
		public RequirementsWindow()
		{
		}

		// Token: 0x040007F2 RID: 2034
		[Token(Token = "0x40007F2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RequirementsView _viewPrefab;

		// Token: 0x040007F3 RID: 2035
		[Token(Token = "0x40007F3")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/RequirementsWindow";

		// Token: 0x0200029C RID: 668
		[Token(Token = "0x200029C")]
		public class RequirementsWindowArgs : BaseDialogWindow<RequirementsWindow.RequirementsWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x17000232 RID: 562
			// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000232")]
			public IBalanceSource BalanceSource
			{
				[Token(Token = "0x6000FA8")]
				[Address(RVA = "0x61D1", Offset = "0x61D1", VA = "0x61D1")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000FA9")]
				[Address(RVA = "0x61D2", Offset = "0x61D2", VA = "0x61D2")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000233 RID: 563
			// (get) Token: 0x06000FAA RID: 4010 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000FAB RID: 4011 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000233")]
			public UserData User
			{
				[Token(Token = "0x6000FAA")]
				[Address(RVA = "0x61D3", Offset = "0x61D3", VA = "0x61D3")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000FAB")]
				[Address(RVA = "0x61D4", Offset = "0x61D4", VA = "0x61D4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000FAC RID: 4012 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000FAC")]
			[Address(RVA = "0x61D5", Offset = "0x61D5", VA = "0x61D5")]
			public RequirementsWindowArgs(IBalanceSource balanceSource, UserData user, RequirementDic requirements)
			{
			}

			// Token: 0x06000FAD RID: 4013 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000FAD")]
			[Address(RVA = "0x61D6", Offset = "0x61D6", VA = "0x61D6")]
			public RequirementsWindowArgs(IBalanceSource balanceSource, UserData user, ResourceSet cost, IList<RestrictionInfo> restrictionInfos, IList<RewardInfo> materials)
			{
			}

			// Token: 0x040007F6 RID: 2038
			[Token(Token = "0x40007F6")]
			[FieldOffset(Offset = "0x34")]
			public ResourceSet Cost;

			// Token: 0x040007F7 RID: 2039
			[Token(Token = "0x40007F7")]
			[FieldOffset(Offset = "0x38")]
			public IList<RestrictionInfo> Restrictions;

			// Token: 0x040007F8 RID: 2040
			[Token(Token = "0x40007F8")]
			[FieldOffset(Offset = "0x3C")]
			public IList<RewardInfo> Materials;
		}
	}
}
