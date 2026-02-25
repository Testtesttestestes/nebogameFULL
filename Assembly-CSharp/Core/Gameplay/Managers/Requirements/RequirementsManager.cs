using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;

namespace Core.Gameplay.Managers.Requirements
{
	// Token: 0x02001197 RID: 4503
	[Token(Token = "0x2001197")]
	public class RequirementsManager : IGameManager, IBaseManager, IRequirementValidator
	{
		// Token: 0x140002BA RID: 698
		// (add) Token: 0x06006AFE RID: 27390 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006AFF RID: 27391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002BA")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006AFE")]
			[Address(RVA = "0xB605", Offset = "0xB605", VA = "0xB605", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006AFF")]
			[Address(RVA = "0xB606", Offset = "0xB606", VA = "0xB606", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002BB RID: 699
		// (add) Token: 0x06006B00 RID: 27392 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006B01 RID: 27393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002BB")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006B00")]
			[Address(RVA = "0xB607", Offset = "0xB607", VA = "0xB607", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006B01")]
			[Address(RVA = "0xB608", Offset = "0xB608", VA = "0xB608", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x06006B02 RID: 27394 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015DA")]
		public string Name
		{
			[Token(Token = "0x6006B02")]
			[Address(RVA = "0xB609", Offset = "0xB609", VA = "0xB609", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006B03 RID: 27395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B03")]
		[Address(RVA = "0xB60A", Offset = "0xB60A", VA = "0xB60A", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006B04 RID: 27396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B04")]
		[Address(RVA = "0xB60B", Offset = "0xB60B", VA = "0xB60B", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006B05 RID: 27397 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006B05")]
		[Address(RVA = "0xB60C", Offset = "0xB60C", VA = "0xB60C")]
		public RequirementDic GetRequirementDic(uint requirementId)
		{
			return null;
		}

		// Token: 0x06006B06 RID: 27398 RVA: 0x00013B90 File Offset: 0x00011D90
		[Token(Token = "0x6006B06")]
		[Address(RVA = "0xB60D", Offset = "0xB60D", VA = "0xB60D", Slot = "11")]
		public bool Check(uint requirementId, UserData user)
		{
			return default(bool);
		}

		// Token: 0x06006B07 RID: 27399 RVA: 0x00013BA8 File Offset: 0x00011DA8
		[Token(Token = "0x6006B07")]
		[Address(RVA = "0xB60E", Offset = "0xB60E", VA = "0xB60E", Slot = "12")]
		public bool CheckRestrictions(uint requirementId, UserData user)
		{
			return default(bool);
		}

		// Token: 0x06006B08 RID: 27400 RVA: 0x00013BC0 File Offset: 0x00011DC0
		[Token(Token = "0x6006B08")]
		[Address(RVA = "0xB60F", Offset = "0xB60F", VA = "0xB60F", Slot = "14")]
		public bool CheckRestriction(RestrictionInfo restrictionInfo, TriggerValue triggerValue)
		{
			return default(bool);
		}

		// Token: 0x06006B09 RID: 27401 RVA: 0x00013BD8 File Offset: 0x00011DD8
		[Token(Token = "0x6006B09")]
		[Address(RVA = "0xB610", Offset = "0xB610", VA = "0xB610", Slot = "13")]
		public bool CheckRestrictions(IList<RestrictionInfo> restrictionsInfo, UserData user)
		{
			return default(bool);
		}

		// Token: 0x06006B0A RID: 27402 RVA: 0x00013BF0 File Offset: 0x00011DF0
		[Token(Token = "0x6006B0A")]
		[Address(RVA = "0xB611", Offset = "0xB611", VA = "0xB611", Slot = "15")]
		public bool CheckPrice(ResourceSet price, UserData user)
		{
			return default(bool);
		}

		// Token: 0x06006B0B RID: 27403 RVA: 0x00013C08 File Offset: 0x00011E08
		[Token(Token = "0x6006B0B")]
		[Address(RVA = "0xB612", Offset = "0xB612", VA = "0xB612", Slot = "16")]
		public bool CheckPrice(uint requirementId, UserData user)
		{
			return default(bool);
		}

		// Token: 0x06006B0C RID: 27404 RVA: 0x00013C20 File Offset: 0x00011E20
		[Token(Token = "0x6006B0C")]
		[Address(RVA = "0xB613", Offset = "0xB613", VA = "0xB613", Slot = "17")]
		public bool CheckMaterials(uint requirementId, UserData user)
		{
			return default(bool);
		}

		// Token: 0x06006B0D RID: 27405 RVA: 0x00013C38 File Offset: 0x00011E38
		[Token(Token = "0x6006B0D")]
		[Address(RVA = "0xB614", Offset = "0xB614", VA = "0xB614", Slot = "18")]
		public bool CheckMaterials(RepeatedField<RewardInfo> materials, UserData user)
		{
			return default(bool);
		}

		// Token: 0x06006B0E RID: 27406 RVA: 0x00013C50 File Offset: 0x00011E50
		[Token(Token = "0x6006B0E")]
		[Address(RVA = "0xB615", Offset = "0xB615", VA = "0xB615")]
		public uint GetMaxQuotient(uint requirementId, UserData user)
		{
			return 0U;
		}

		// Token: 0x06006B0F RID: 27407 RVA: 0x00013C68 File Offset: 0x00011E68
		[Token(Token = "0x6006B0F")]
		[Address(RVA = "0xB616", Offset = "0xB616", VA = "0xB616")]
		public uint GetMaterialsMaxQuotient(RepeatedField<RewardInfo> materials, UserData user)
		{
			return 0U;
		}

		// Token: 0x06006B10 RID: 27408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B10")]
		[Address(RVA = "0xB617", Offset = "0xB617", VA = "0xB617")]
		public RequirementsManager()
		{
		}

		// Token: 0x04003896 RID: 14486
		[Token(Token = "0x4003896")]
		[FieldOffset(Offset = "0x10")]
		private UserData _loggedUser;

		// Token: 0x04003897 RID: 14487
		[Token(Token = "0x4003897")]
		[FieldOffset(Offset = "0x14")]
		private DictManager _dictManager;
	}
}
