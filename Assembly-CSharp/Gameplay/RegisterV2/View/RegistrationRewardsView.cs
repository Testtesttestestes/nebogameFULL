using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.RegisterV2.View
{
	// Token: 0x0200055C RID: 1372
	[Token(Token = "0x200055C")]
	public class RegistrationRewardsView : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x060020FD RID: 8445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FD")]
		[Address(RVA = "0x1CD8", Offset = "0x1CD8", VA = "0x1CD8")]
		public void Add(string assetId, double value)
		{
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FE")]
		[Address(RVA = "0x7260", Offset = "0x7260", VA = "0x7260", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FF")]
		[Address(RVA = "0x7261", Offset = "0x7261", VA = "0x7261")]
		public RegistrationRewardsView()
		{
		}

		// Token: 0x04001202 RID: 4610
		[Token(Token = "0x4001202")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RegistrationResourceView registrationResourcePrefab;

		// Token: 0x04001203 RID: 4611
		[Token(Token = "0x4001203")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _resourceContainer;
	}
}
