using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Bank.Model;
using Gameplay.Fresco.View.Groups;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Fresco;

namespace Gameplay.Fresco.Model
{
	// Token: 0x02000803 RID: 2051
	[Token(Token = "0x2000803")]
	public class FrescoModel : AbstractModel
	{
		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06003014 RID: 12308 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003015 RID: 12309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096A")]
		public RepeatedField<Protocol.Fresco.Fresco> Frescoes
		{
			[Token(Token = "0x6003014")]
			[Address(RVA = "0x8079", Offset = "0x8079", VA = "0x8079")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003015")]
			[Address(RVA = "0x807A", Offset = "0x807A", VA = "0x807A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06003016 RID: 12310 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003017 RID: 12311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096B")]
		public Protocol.Fresco.Fresco CurrentFresco
		{
			[Token(Token = "0x6003016")]
			[Address(RVA = "0x807B", Offset = "0x807B", VA = "0x807B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003017")]
			[Address(RVA = "0x807C", Offset = "0x807C", VA = "0x807C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06003018 RID: 12312 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003019 RID: 12313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096C")]
		public Protocol.Fresco.Fresco CurrentLobbyFresco
		{
			[Token(Token = "0x6003018")]
			[Address(RVA = "0x807D", Offset = "0x807D", VA = "0x807D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003019")]
			[Address(RVA = "0x807E", Offset = "0x807E", VA = "0x807E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x0600301A RID: 12314 RVA: 0x00009B40 File Offset: 0x00007D40
		[Token(Token = "0x1700096D")]
		public int CurrentFrescoIndex
		{
			[Token(Token = "0x600301A")]
			[Address(RVA = "0x807F", Offset = "0x807F", VA = "0x807F")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x0600301B RID: 12315 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600301C RID: 12316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096E")]
		public Protocol.Dic.Fresco.Types.FrescoDic CurrentFrescoDic
		{
			[Token(Token = "0x600301B")]
			[Address(RVA = "0x8080", Offset = "0x8080", VA = "0x8080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600301C")]
			[Address(RVA = "0x8081", Offset = "0x8081", VA = "0x8081")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x0600301D RID: 12317 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600301E RID: 12318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096F")]
		public Protocol.Dic.Fresco.Types.FrescoDic CurrentLobbyFrescoDic
		{
			[Token(Token = "0x600301D")]
			[Address(RVA = "0x8082", Offset = "0x8082", VA = "0x8082")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600301E")]
			[Address(RVA = "0x8083", Offset = "0x8083", VA = "0x8083")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x0600301F RID: 12319 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003020 RID: 12320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000970")]
		public SortedDictionary<Protocol.Fresco.Fresco, Protocol.Dic.Fresco.Types.FrescoDic> CurrentGroup
		{
			[Token(Token = "0x600301F")]
			[Address(RVA = "0x8084", Offset = "0x8084", VA = "0x8084")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003020")]
			[Address(RVA = "0x8085", Offset = "0x8085", VA = "0x8085")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06003021 RID: 12321 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003022 RID: 12322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000971")]
		public uint[] SelectedCellsIndex
		{
			[Token(Token = "0x6003021")]
			[Address(RVA = "0x8086", Offset = "0x8086", VA = "0x8086")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003022")]
			[Address(RVA = "0x8087", Offset = "0x8087", VA = "0x8087")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06003023 RID: 12323 RVA: 0x00009B58 File Offset: 0x00007D58
		[Token(Token = "0x17000972")]
		public bool HasSelectedCells
		{
			[Token(Token = "0x6003023")]
			[Address(RVA = "0x8088", Offset = "0x8088", VA = "0x8088")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06003024 RID: 12324 RVA: 0x00009B70 File Offset: 0x00007D70
		[Token(Token = "0x17000973")]
		public bool CanSelectUniversalFragment
		{
			[Token(Token = "0x6003024")]
			[Address(RVA = "0x8089", Offset = "0x8089", VA = "0x8089")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06003025 RID: 12325 RVA: 0x00009B88 File Offset: 0x00007D88
		[Token(Token = "0x17000974")]
		public int EmptyCellsCount
		{
			[Token(Token = "0x6003025")]
			[Address(RVA = "0x808A", Offset = "0x808A", VA = "0x808A")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06003026 RID: 12326 RVA: 0x00009BA0 File Offset: 0x00007DA0
		// (set) Token: 0x06003027 RID: 12327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000975")]
		public uint UniversalFragmentsCount
		{
			[Token(Token = "0x6003026")]
			[Address(RVA = "0x808B", Offset = "0x808B", VA = "0x808B")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6003027")]
			[Address(RVA = "0x808C", Offset = "0x808C", VA = "0x808C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06003028 RID: 12328 RVA: 0x00009BB8 File Offset: 0x00007DB8
		[Token(Token = "0x17000976")]
		public bool CanInstallUniversalFragment
		{
			[Token(Token = "0x6003028")]
			[Address(RVA = "0x808D", Offset = "0x808D", VA = "0x808D")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06003029 RID: 12329 RVA: 0x00009BD0 File Offset: 0x00007DD0
		[Token(Token = "0x17000977")]
		public bool CanInstallAllUniversalFragments
		{
			[Token(Token = "0x6003029")]
			[Address(RVA = "0x808E", Offset = "0x808E", VA = "0x808E")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x0600302A RID: 12330 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600302B RID: 12331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000978")]
		public List<FrescoGroupListElementArgs> FrescoData
		{
			[Token(Token = "0x600302A")]
			[Address(RVA = "0x808F", Offset = "0x808F", VA = "0x808F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600302B")]
			[Address(RVA = "0x8090", Offset = "0x8090", VA = "0x8090")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x0600302C RID: 12332 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000979")]
		public Dictionary<ulong, List<FrescoGroupListElementArgs>> OtherFrescoData
		{
			[Token(Token = "0x600302C")]
			[Address(RVA = "0x8091", Offset = "0x8091", VA = "0x8091")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x0600302D RID: 12333 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700097A")]
		public Protocol.Dic.Fresco.Types.Cell KeyCell
		{
			[Token(Token = "0x600302D")]
			[Address(RVA = "0x8092", Offset = "0x8092", VA = "0x8092")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x0600302E RID: 12334 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700097B")]
		public FrescoCell KeyFrescoCell
		{
			[Token(Token = "0x600302E")]
			[Address(RVA = "0x8093", Offset = "0x8093", VA = "0x8093")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x0600302F RID: 12335 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700097C")]
		public Protocol.Dic.Fresco.Types.Cell KeyDicFrescoCell
		{
			[Token(Token = "0x600302F")]
			[Address(RVA = "0x8094", Offset = "0x8094", VA = "0x8094")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06003030 RID: 12336 RVA: 0x00009BE8 File Offset: 0x00007DE8
		[Token(Token = "0x1700097D")]
		public bool HasKeyCell
		{
			[Token(Token = "0x6003030")]
			[Address(RVA = "0x8095", Offset = "0x8095", VA = "0x8095")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06003031 RID: 12337 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003032 RID: 12338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700097E")]
		public UserData Owner
		{
			[Token(Token = "0x6003031")]
			[Address(RVA = "0x8096", Offset = "0x8096", VA = "0x8096")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003032")]
			[Address(RVA = "0x8097", Offset = "0x8097", VA = "0x8097")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06003033 RID: 12339 RVA: 0x00009C00 File Offset: 0x00007E00
		[Token(Token = "0x1700097F")]
		public bool IsOwn
		{
			[Token(Token = "0x6003033")]
			[Address(RVA = "0x8098", Offset = "0x8098", VA = "0x8098")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x00009C18 File Offset: 0x00007E18
		[Token(Token = "0x6003034")]
		[Address(RVA = "0x8099", Offset = "0x8099", VA = "0x8099")]
		public bool HasAvailableCells(bool includeKeyObject)
		{
			return default(bool);
		}

		// Token: 0x06003035 RID: 12341 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003035")]
		[Address(RVA = "0x809A", Offset = "0x809A", VA = "0x809A")]
		public uint[] GetAllAvailableCellsIndex(bool includeKeyObject)
		{
			return null;
		}

		// Token: 0x06003036 RID: 12342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003036")]
		[Address(RVA = "0x809B", Offset = "0x809B", VA = "0x809B")]
		public FrescoModel(UserData user, Dependencies dependencies)
		{
		}

		// Token: 0x06003037 RID: 12343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003037")]
		[Address(RVA = "0x809C", Offset = "0x809C", VA = "0x809C")]
		public void UpdateFresco(Protocol.Fresco.Fresco newFresco)
		{
		}

		// Token: 0x06003038 RID: 12344 RVA: 0x00009C30 File Offset: 0x00007E30
		[Token(Token = "0x6003038")]
		[Address(RVA = "0x809D", Offset = "0x809D", VA = "0x809D")]
		public bool TryGetNextFresco(out Protocol.Fresco.Fresco fresco)
		{
			return default(bool);
		}

		// Token: 0x06003039 RID: 12345 RVA: 0x00009C48 File Offset: 0x00007E48
		[Token(Token = "0x6003039")]
		[Address(RVA = "0x809E", Offset = "0x809E", VA = "0x809E")]
		public bool TryGetPrevFresco(out Protocol.Fresco.Fresco fresco)
		{
			return default(bool);
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600303A")]
		[Address(RVA = "0x809F", Offset = "0x809F", VA = "0x809F")]
		public void SetOptions(IList<BankOptionData> options)
		{
		}

		// Token: 0x0600303B RID: 12347 RVA: 0x00009C60 File Offset: 0x00007E60
		[Token(Token = "0x600303B")]
		[Address(RVA = "0x80A0", Offset = "0x80A0", VA = "0x80A0")]
		public uint GetArtikulIdByIndex(uint index)
		{
			return 0U;
		}

		// Token: 0x0600303C RID: 12348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600303C")]
		[Address(RVA = "0x80A1", Offset = "0x80A1", VA = "0x80A1")]
		public void SetOtherFrescoData(ulong userId, List<FrescoGroupListElementArgs> frescoData)
		{
		}

		// Token: 0x0600303D RID: 12349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600303D")]
		[Address(RVA = "0x80A2", Offset = "0x80A2", VA = "0x80A2")]
		public void SetCurrentFresco(Protocol.Fresco.Fresco fresco)
		{
		}

		// Token: 0x0600303E RID: 12350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600303E")]
		[Address(RVA = "0x80A3", Offset = "0x80A3", VA = "0x80A3")]
		public void SetCurrentLobbyFresco(Protocol.Fresco.Fresco fresco)
		{
		}

		// Token: 0x0600303F RID: 12351 RVA: 0x00009C78 File Offset: 0x00007E78
		[Token(Token = "0x600303F")]
		[Address(RVA = "0x80A4", Offset = "0x80A4", VA = "0x80A4")]
		public bool TryGetFrescoForLobby(out Protocol.Fresco.Fresco fresco)
		{
			return default(bool);
		}

		// Token: 0x04001A5C RID: 6748
		[Token(Token = "0x4001A5C")]
		[FieldOffset(Offset = "0xC")]
		public readonly Dependencies Dependencies;

		// Token: 0x04001A68 RID: 6760
		[Token(Token = "0x4001A68")]
		[FieldOffset(Offset = "0x3C")]
		public readonly List<BankOptionData> Options;
	}
}
