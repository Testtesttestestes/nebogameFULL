using System;
using AssetContent;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using Utils;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B80 RID: 2944
	[Token(Token = "0x2000B80")]
	public class BossTeamCaptainView : MonoBehaviour
	{
		// Token: 0x0600477E RID: 18302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600477E")]
		[Address(RVA = "0x960E", Offset = "0x960E", VA = "0x960E")]
		private void Awake()
		{
		}

		// Token: 0x0600477F RID: 18303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600477F")]
		[Address(RVA = "0x960F", Offset = "0x960F", VA = "0x960F")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004780 RID: 18304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004780")]
		[Address(RVA = "0x9610", Offset = "0x9610", VA = "0x9610")]
		private void ClickHandlerOnOnClickEvent(PointerEventData obj)
		{
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06004781 RID: 18305 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004782 RID: 18306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E4C")]
		public TeamData.TeamCaptainData CaptainData
		{
			[Token(Token = "0x6004781")]
			[Address(RVA = "0x9611", Offset = "0x9611", VA = "0x9611")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004782")]
			[Address(RVA = "0x9612", Offset = "0x9612", VA = "0x9612")]
			set
			{
			}
		}

		// Token: 0x06004783 RID: 18307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004783")]
		[Address(RVA = "0x9613", Offset = "0x9613", VA = "0x9613")]
		public BossTeamCaptainView()
		{
		}

		// Token: 0x0400274A RID: 10058
		[Token(Token = "0x400274A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAssetViewRawImage _avatar;

		// Token: 0x0400274B RID: 10059
		[Token(Token = "0x400274B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MonoPointerClickHandler _clickHandler;

		// Token: 0x0400274C RID: 10060
		[Token(Token = "0x400274C")]
		[FieldOffset(Offset = "0x18")]
		private TeamData.TeamCaptainData _captainData;
	}
}
