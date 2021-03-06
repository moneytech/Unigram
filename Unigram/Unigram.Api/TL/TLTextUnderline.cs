// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLTextUnderline : TLRichTextBase 
	{
		public TLRichTextBase Text { get; set; }

		public TLTextUnderline() { }
		public TLTextUnderline(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.TextUnderline; } }

		public override void Read(TLBinaryReader from)
		{
			Text = TLFactory.Read<TLRichTextBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Text);
		}
	}
}