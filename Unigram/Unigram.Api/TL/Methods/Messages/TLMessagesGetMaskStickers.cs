// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.getMaskStickers
	/// </summary>
	public partial class TLMessagesGetMaskStickers : TLObject
	{
		public Int32 Hash { get; set; }

		public TLMessagesGetMaskStickers() { }
		public TLMessagesGetMaskStickers(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.MessagesGetMaskStickers; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Hash = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x65B8C79F);
			to.Write(Hash);
			if (cache) WriteToCache(to);
		}
	}
}