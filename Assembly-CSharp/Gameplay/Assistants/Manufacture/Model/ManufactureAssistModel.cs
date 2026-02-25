using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Accounts;
using Core.Gameplay;
using Gameplay.Assistants.Model;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Craft;
using Protocol.Dic;

namespace Gameplay.Assistants.Manufacture.Model
{
	// Token: 0x02000CAE RID: 3246
	[Token(Token = "0x2000CAE")]
	public class ManufactureAssistModel : BaseAssistantModel
	{
		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x06004F06 RID: 20230 RVA: 0x0000E868 File Offset: 0x0000CA68
		// (set) Token: 0x06004F07 RID: 20231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001012")]
		public int LastSlotId
		{
			[Token(Token = "0x6004F06")]
			[Address(RVA = "0x9D2E", Offset = "0x9D2E", VA = "0x9D2E")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004F07")]
			[Address(RVA = "0x9D2F", Offset = "0x9D2F", VA = "0x9D2F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x06004F08 RID: 20232 RVA: 0x0000E880 File Offset: 0x0000CA80
		// (set) Token: 0x06004F09 RID: 20233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001013")]
		public bool SortByTypeRewardsEnabled
		{
			[Token(Token = "0x6004F08")]
			[Address(RVA = "0x9D30", Offset = "0x9D30", VA = "0x9D30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004F09")]
			[Address(RVA = "0x9D31", Offset = "0x9D31", VA = "0x9D31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06004F0A RID: 20234 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004F0B RID: 20235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001014")]
		public ProtoManufactureGetInfoAns Info
		{
			[Token(Token = "0x6004F0A")]
			[Address(RVA = "0x9D32", Offset = "0x9D32", VA = "0x9D32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F0B")]
			[Address(RVA = "0x9D33", Offset = "0x9D33", VA = "0x9D33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06004F0C RID: 20236 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001015")]
		public ArtifactInfo CurrentDismantledArtifact
		{
			[Token(Token = "0x6004F0C")]
			[Address(RVA = "0x9D34", Offset = "0x9D34", VA = "0x9D34")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004F0D RID: 20237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F0D")]
		[Address(RVA = "0x9D35", Offset = "0x9D35", VA = "0x9D35")]
		public ManufactureAssistModel(AssistantsDic dic, AssistantStatus status, IGame game, UserData user)
		{
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x06004F0E RID: 20238 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001016")]
		public IAccountData Account
		{
			[Token(Token = "0x6004F0E")]
			[Address(RVA = "0x9D36", Offset = "0x9D36", VA = "0x9D36")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x06004F0F RID: 20239 RVA: 0x0000E898 File Offset: 0x0000CA98
		[Token(Token = "0x17001017")]
		public double TotalStackSize
		{
			[Token(Token = "0x6004F0F")]
			[Address(RVA = "0x9D37", Offset = "0x9D37", VA = "0x9D37")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06004F10 RID: 20240 RVA: 0x0000E8B0 File Offset: 0x0000CAB0
		[Token(Token = "0x6004F10")]
		[Address(RVA = "0x9D38", Offset = "0x9D38", VA = "0x9D38")]
		public bool CheckStartDisassembleCommon(ArtifactData artifact, out ManufactureAssistModel.StartFailDisassembleReasons reason)
		{
			return default(bool);
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x06004F11 RID: 20241 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001018")]
		public IEnumerable<ArtifactData> Drop
		{
			[Token(Token = "0x6004F11")]
			[Address(RVA = "0x9D39", Offset = "0x9D39", VA = "0x9D39")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004F12 RID: 20242 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
		[Token(Token = "0x6004F12")]
		[Address(RVA = "0x9D3A", Offset = "0x9D3A", VA = "0x9D3A")]
		public bool CheckStartDisassemblePart(ArtifactData artifact, out ManufactureAssistModel.StartFailDisassembleReasons reason)
		{
			return default(bool);
		}

		// Token: 0x02000CAF RID: 3247
		[Token(Token = "0x2000CAF")]
		public enum StartFailDisassembleReasons
		{
			// Token: 0x04002B22 RID: 11042
			[Token(Token = "0x4002B22")]
			UNKNOWN,
			// Token: 0x04002B23 RID: 11043
			[Token(Token = "0x4002B23")]
			NO_ARTIFACT_IN_SLOT,
			// Token: 0x04002B24 RID: 11044
			[Token(Token = "0x4002B24")]
			IS_NO_STACKABLE,
			// Token: 0x04002B25 RID: 11045
			[Token(Token = "0x4002B25")]
			ACCOUNT_EXPIRED,
			// Token: 0x04002B26 RID: 11046
			[Token(Token = "0x4002B26")]
			REQUIRED_PICKUP_DROP
		}
	}
}
